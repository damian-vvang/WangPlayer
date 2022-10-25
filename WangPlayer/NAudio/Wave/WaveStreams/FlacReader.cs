// Decompiled with JetBrains decompiler
// Type: NAudio.Flac.FlacReader
// Assembly: NAudio.Flac, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EB2711BE-AAAF-4A3C-920D-FC9D5ECE5D70
// Assembly location: E:\Studia\VII semestr\Praca Inżynierska\Aplikacja\Wang_Multi_APK\Kalkulator - Projekt - Styczeń\NAudio\bin\Debug\NAudio.Flac.dll

using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace NAudio.Flac
{
  public class FlacReader : WaveStream, IDisposable, ISampleProvider, IWaveProvider
  {
    private readonly object _bufferLock = new object();
    private readonly Stream _stream;
    private readonly WaveFormat _waveFormat;
    private readonly FlacMetadataStreamInfo _streamInfo;
    private readonly FlacPreScan _scan;
    private byte[] _overflowBuffer;
    private int _overflowCount;
    private int _overflowOffset;
    private int _frameIndex;
    private FlacFrame _frame;
    private long _position;

    public List<FlacMetadata> Metadata { get; protected set; }

    public override WaveFormat WaveFormat
    {
      get
      {
        return this._waveFormat;
      }
    }

    public override bool CanSeek
    {
      get
      {
        return this._scan != null;
      }
    }

    private FlacFrame Frame
    {
      get
      {
        return this._frame ?? (this._frame = FlacFrame.FromStream(this._stream, this._streamInfo));
      }
    }

    public FlacReader(string fileName)
      : this((Stream) File.OpenRead(fileName))
    {
    }

    public FlacReader(Stream stream)
      : this(stream, FlacPreScanMethodMode.Default)
    {
    }

    public FlacReader(Stream stream, FlacPreScanMethodMode scanFlag)
      : this(stream, scanFlag, (Action<FlacPreScanFinishedEventArgs>) null)
    {
    }

    public FlacReader(
      Stream stream,
      FlacPreScanMethodMode scanFlag,
      Action<FlacPreScanFinishedEventArgs> onscanFinished)
    {
      if (stream == null)
        throw new ArgumentNullException();
      if (!stream.CanRead)
        throw new ArgumentException("Stream is not readable.", nameof (stream));
      this._stream = stream;
      ID3v2.SkipTag(stream);
      byte[] buffer = new byte[4];
      if (stream.Read(buffer, 0, buffer.Length) < buffer.Length)
        throw new EndOfStreamException("Can not read \"fLaC\" sync.");
      if (buffer[0] != (byte) 102 || buffer[1] != (byte) 76 || buffer[2] != (byte) 97 || buffer[3] != (byte) 67)
        throw new FlacException("Invalid Flac-File. \"fLaC\" Sync not found.", FlacLayer.Top);
      List<FlacMetadata> source = FlacMetadata.ReadAllMetadataFromStream(stream);
      this.Metadata = source;
      if (source == null || source.Count <= 0)
        throw new FlacException("No Metadata found.", FlacLayer.Metadata);
      FlacMetadataStreamInfo metadataStreamInfo = source.First<FlacMetadata>((Func<FlacMetadata, bool>) (x => x.MetaDataType == FlacMetaDataType.StreamInfo)) as FlacMetadataStreamInfo;
      if (metadataStreamInfo == null)
        throw new FlacException("No StreamInfo-Metadata found.", FlacLayer.Metadata);
      this._streamInfo = metadataStreamInfo;
      this._waveFormat = new WaveFormat(metadataStreamInfo.SampleRate, (int) (short) metadataStreamInfo.BitsPerSample, (int) (short) metadataStreamInfo.Channels);
      Debug.WriteLine("Flac StreamInfo found -> WaveFormat: " + (object) this._waveFormat);
      Debug.WriteLine("Flac-File-Metadata read.");
      if (scanFlag == FlacPreScanMethodMode.None)
        return;
      FlacPreScan flacPreScan = new FlacPreScan(stream);
      flacPreScan.ScanFinished += (EventHandler<FlacPreScanFinishedEventArgs>) ((s, e) =>
      {
        if (onscanFinished == null)
          return;
        onscanFinished(e);
      });
      flacPreScan.ScanStream(this._streamInfo, scanFlag);
      this._scan = flacPreScan;
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      int num = 0;
      count -= count % this.WaveFormat.BlockAlign;
      lock (this._bufferLock)
      {
        num += this.GetOverflows(buffer, ref offset, count);
        while (num < count)
        {
          FlacFrame frame = this.Frame;
          if (frame == null)
            return 0;
          while (!frame.NextFrame())
          {
            if (this.CanSeek)
            {
              if (++this._frameIndex >= this._scan.Frames.Count)
                return 0;
              this._stream.Position = this._scan.Frames[this._frameIndex].StreamOffset;
            }
          }
          ++this._frameIndex;
          int buffer1 = frame.GetBuffer(ref this._overflowBuffer, 0);
          int length = Math.Min(count - num, buffer1);
          Array.Copy((Array) this._overflowBuffer, 0, (Array) buffer, offset, length);
          num += length;
          offset += length;
          this._overflowCount = buffer1 > length ? buffer1 - length : 0;
          this._overflowOffset = buffer1 > length ? length : 0;
        }
      }
      this._position += (long) num;
      return num;
    }

    private int GetOverflows(byte[] buffer, ref int offset, int count)
    {
      if (this._overflowCount == 0 || this._overflowBuffer == null || count <= 0)
        return 0;
      int length = Math.Min(count, this._overflowCount);
      Array.Copy((Array) this._overflowBuffer, this._overflowOffset, (Array) buffer, offset, length);
      this._overflowCount -= length;
      this._overflowOffset += length;
      offset += length;
      return length;
    }

    public override long Position
    {
      get
      {
        if (!this.CanSeek)
          return 0;
        lock (this._bufferLock)
          return this._position;
      }
      set
      {
        if (!this.CanSeek)
          return;
        lock (this._bufferLock)
        {
          value = Math.Min(value, this.Length);
          value = value > 0L ? value : 0L;
          for (int index = 0; index < this._scan.Frames.Count; ++index)
          {
            long num = value / (long) this.WaveFormat.BlockAlign;
            FlacFrameInformation frame = this._scan.Frames[index];
            long sampleOffset = frame.SampleOffset;
            if (num <= sampleOffset)
            {
              Stream stream = this._stream;
              frame = this._scan.Frames[index];
              long streamOffset = frame.StreamOffset;
              stream.Position = streamOffset;
              this._frameIndex = index;
              if (this._stream.Position >= this._stream.Length)
                throw new EndOfStreamException("Stream got EOF.");
              frame = this._scan.Frames[index];
              this._position = frame.SampleOffset * (long) this.WaveFormat.BlockAlign;
              this._overflowCount = 0;
              this._overflowOffset = 0;
              break;
            }
          }
        }
      }
    }

    public override long Length
    {
      get
      {
        return this._scan.TotalSamples * (long) this.WaveFormat.BlockAlign;
      }
    }

    public new void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected override void Dispose(bool disposing)
    {
      lock (this._bufferLock)
      {
        if (this._frame != null)
        {
          this._frame.FreeBuffers();
          this._frame = (FlacFrame) null;
        }
        if (this._stream == null)
          return;
        this._stream.Dispose();
      }
    }

    ~FlacReader()
    {
      this.Dispose(false);
    }

    public int Read(float[] buffer, int offset, int count)
    {
      return -1;
    }
  }
}
