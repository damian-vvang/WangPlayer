using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.Flac;
using NAudio.CoreAudioApi;
using NAudio.Dsp;

namespace WangPlayer
{
    public partial class Player : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();

        private IWavePlayer outputDevice;
        private WaveStream audioFile;
        List<string> files;
        List<string> paths;

        int NumberOfClick = 0;

        string currentFilePathLCDText;
        string currentNamePathLCDText;
        int currentNamePathLCDCounter=0;

        // Windows ribbon control disable
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }

        // Main function
        public Player()
        {
            files = new List<string>();
            paths = new List<string>();
            InitializeComponent();
            volumeLvl.Value = 10;
            volumeLCD.Text = "Vol: 100 %";
            this.Width = 1040;
        }

        // Sample test #1 - sequence test
        void Test1()
        {
            for (int t = 0; t < 50; t++)
            {
                for (int i = 0; i < this.playlistBox.Items.Count; i++)
                {
                    this.playlistBox.SelectedIndex = i;
                }
                for (int i = this.playlistBox.Items.Count - 1; i >= 0; i--)
                {
                    this.playlistBox.SelectedIndex = i;
                }
            }
        }

        // Sample test #2 - selecting random track's from playlistBox
        void Test2()
        {
            for (int t = 0; t < 50; t++)
            {
                Random random = new Random();

                int startValue = 0;
                int endValue = playlistBox.Items.Count;
                int randomValue = random.Next(startValue, endValue);

                playlistBox.SelectedIndex = randomValue;
            }
        }

        // Play - Button
        private void playButton_Click(object sender, EventArgs e)
        {
            CleanUp();
            rightVU.Visible = true;
            leftVU.Visible = true;
            loadButton.Enabled = true;
            playButton.Enabled = true;
            clearButton.Enabled = true;
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            revDown.Enabled = true;
            revUp.Enabled = true;
            pauseButton.Enabled = true;
            stopButton.Enabled = true;
            randomButton.Enabled = true;
            volumeLvl.Enabled = true;

            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
            else
            {
                playlistBox.SelectedIndex = 0;
            }

            if (audioFile == null)
            {
                if ((paths[playlistBox.SelectedIndex]).EndsWith(".flac", StringComparison.OrdinalIgnoreCase))
                {
                    audioFile = new FlacReader(paths[playlistBox.SelectedIndex]);
                    outputDevice.Init(audioFile);
                    timer2.Start();
                    outputDevice.Play();
                }
                else
                {
                    audioFile = new AudioFileReader(paths[playlistBox.SelectedIndex]);
                    outputDevice.Init(audioFile);
                    timer2.Start();
                    outputDevice.Play();
                }
                var file = TagLib.File.Create(paths[playlistBox.SelectedIndex]);

                if (file.Tag.Pictures.Length == 0)
                {
                    albumART.Image = null;
                }
                else
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    albumART.Image = Image.FromStream(new MemoryStream(bin));
                    this.albumART.SizeMode = PictureBoxSizeMode.Zoom;
                }
                bitrateLCD.Text = Convert.ToString(file.Properties.AudioBitrate + "kbs");
                currentNamePathLCDText = DynamicText(paths[playlistBox.SelectedIndex]);
                currentFilePathLCDText = DynamicText(Path.GetFileName((paths[playlistBox.SelectedIndex])));
                artistLCD.Text = Convert.ToString("Artist: " + file.Tag.FirstArtist);
                titleLCD.Text = Convert.ToString("Title: " + file.Tag.Title);
                albumLCD.Text = Convert.ToString("Album: " + file.Tag.Album);
                yearLCD.Text = Convert.ToString("Year: " + file.Tag.Year);
                genresLCD.Text = Convert.ToString("Genre: " + file.Tag.FirstGenre);
            }
            else
            {
                playlistBox.SelectedIndex = 0;
            }
        }

        // Pause - Button
        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                if (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    outputDevice.Pause();
                    pauseButton.BackgroundImage = ((System.Drawing.Bitmap)(Properties.Resources.pauseButton_active));
                    rightVU.Visible = false;
                    leftVU.Visible = false;
                    loadButton.Enabled = true;
                    playButton.Enabled = false;
                    clearButton.Enabled = false;
                    previousButton.Enabled = false;
                    nextButton.Enabled = false;
                    revDown.Enabled = false;
                    revUp.Enabled = false;
                    stopButton.Enabled = false;
                    randomButton.Enabled = false;
                    volumeLvl.Enabled = false;
                }
                else if (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                {
                    outputDevice.Play();
                    pauseButton.BackgroundImage = ((System.Drawing.Bitmap)(Properties.Resources.pauseButton));
                    rightVU.Visible = true;
                    leftVU.Visible = true;
                    loadButton.Enabled = false;
                    playButton.Enabled = true;
                    clearButton.Enabled = true;
                    previousButton.Enabled = true;
                    nextButton.Enabled = true;
                    revDown.Enabled = true;
                    revUp.Enabled = true;
                    stopButton.Enabled = true;
                    randomButton.Enabled = true;
                    volumeLvl.Enabled = true;
                }
            }
        }

        // Stop - Button
        private void stopButton_Click(object sender, EventArgs e)
        {
            outputDevice.Stop();
            stopButton.Enabled = false;
            CleanUp();
            rightVU.Visible = false;
            leftVU.Visible = false;
            loadButton.Enabled = true;
            playButton.Enabled = true;
            clearButton.Enabled = true;
            previousButton.Enabled = false;
            nextButton.Enabled = false;
            revDown.Enabled = false;
            revUp.Enabled = false;
            pauseButton.Enabled = false;
            randomButton.Enabled = false;
            volumeLvl.Enabled = false;
        }

        //Volume Control - Slider
        private void volumeLvl_Scroll(object sender, EventArgs e)
        {
            float volumeVal;
            volumeVal = ((volumeLvl.Value) / 10.0f);
            outputDevice.Volume = volumeVal;

            if (volumeVal < 0.1f)
            {
                Peak1.Visible = false;
                Peak2.Visible = false;
                Peak3.Visible = false;
                Peak4.Visible = false;
                Peak5.Visible = false;
                Peak6.Visible = false;
                Peak7.Visible = false;
                Peak8.Visible = false;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 0 %";
            }
            else if (volumeVal < 0.2f)
            {
                Peak1.Visible = true;
                Peak2.Visible = false;
                Peak3.Visible = false;
                Peak4.Visible = false;
                Peak5.Visible = false;
                Peak6.Visible = false;
                Peak7.Visible = false;
                Peak8.Visible = false;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 10 %";
            }
            else if (volumeVal < 0.3f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = false;
                Peak4.Visible = false;
                Peak5.Visible = false;
                Peak6.Visible = false;
                Peak7.Visible = false;
                Peak8.Visible = false;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 20 %";
            }
            else if (volumeVal < 0.4f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = true;
                Peak4.Visible = false;
                Peak5.Visible = false;
                Peak6.Visible = false;
                Peak7.Visible = false;
                Peak8.Visible = false;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 30 %";
            }
            else if (volumeVal < 0.5f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = true;
                Peak4.Visible = true;
                Peak5.Visible = false;
                Peak6.Visible = false;
                Peak7.Visible = false;
                Peak8.Visible = false;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 40 %";
            }
            else if (volumeVal < 0.6f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = true;
                Peak4.Visible = true;
                Peak5.Visible = true;
                Peak6.Visible = false;
                Peak7.Visible = false;
                Peak8.Visible = false;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 50 %";
            }
            else if (volumeVal < 0.7f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = true;
                Peak4.Visible = true;
                Peak5.Visible = true;
                Peak6.Visible = true;
                Peak7.Visible = false;
                Peak8.Visible = false;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 60 %";
            }
            else if (volumeVal < 0.8f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = true;
                Peak4.Visible = true;
                Peak5.Visible = true;
                Peak6.Visible = true;
                Peak7.Visible = true;
                Peak8.Visible = false;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 70 %";
            }
            else if (volumeVal < 0.9f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = true;
                Peak4.Visible = true;
                Peak5.Visible = true;
                Peak6.Visible = true;
                Peak7.Visible = true;
                Peak8.Visible = true;
                Peak9.Visible = false;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 80 %";
            }
            else if (volumeVal < 1.0f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = true;
                Peak4.Visible = true;
                Peak5.Visible = true;
                Peak6.Visible = true;
                Peak7.Visible = true;
                Peak8.Visible = true;
                Peak9.Visible = true;
                Peak10.Visible = false;
                volumeLCD.Text = "Vol: 90 %";
            }
            else if (volumeVal == 1.0f)
            {
                Peak1.Visible = true;
                Peak2.Visible = true;
                Peak3.Visible = true;
                Peak4.Visible = true;
                Peak5.Visible = true;
                Peak6.Visible = true;
                Peak7.Visible = true;
                Peak8.Visible = true;
                Peak9.Visible = true;
                Peak10.Visible = true;
                volumeLCD.Text = "Vol: 100 %";
            }
        }

        // Timer #1 - VU-meter's + track number
        private void timer1_Tick(object sender, EventArgs e)
        {
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            leftVU.Value = (int)(Math.Round(defaultDevice.AudioMeterInformation.PeakValues[0] * 100));
            rightVU.Value = (int)(Math.Round(defaultDevice.AudioMeterInformation.PeakValues[1] * 100));
            trackLCD.Text = Convert.ToString("Track #"+playlistBox.SelectedIndex);
        }

        // Timer #2 - LCD Data + TimeSlider
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                timeTrack.Maximum = Convert.ToInt32(audioFile.Length);
                durrationBitLCD.Text = Convert.ToString(audioFile.Length);
                currentBitPossitionLCD.Text = Convert.ToString(audioFile.Position);
                channelsCD.Text = Convert.ToString("Channels: " + audioFile.WaveFormat.Channels);
                currentTimeLCD.Text = audioFile.CurrentTime.ToString(@"hh\:mm\:ss");
                durrationTimeLCD.Text = audioFile.TotalTime.ToString(@"hh\:mm\:ss");
                sampleRateLCD.Text = Convert.ToString("Sample Rate: " + audioFile.WaveFormat.SampleRate + " Hz");

                if (currentTimeLCD.Text == durrationTimeLCD.Text)
                {
                    timer2.Stop();
                    nextButton_Click(sender, e);
                }
                else
                {
                    timeTrack.Value = Convert.ToInt32(audioFile.Position);
                }
            }
        }

        // LCD Dynamic Text Sequence
        private string DynamicText(string text)
        {
            int maxWidth = 53;
            if (text.Length > maxWidth)
            {
                return text+ "      ";
            }
            else
            {
                StringBuilder builder = new StringBuilder(text);
                for(int i=0; i< maxWidth + 1 - text.Length; i++)
                {
                    builder.Append(' ');
                }
                return builder.ToString();
            }
        }

        // Timer #3 - LCD Dynamic Text Sequence
        private void timer3_Tick(object sender, EventArgs e)
        {
            int maxWidth = 53;
            if (currentFilePathLCDText == null)
            {
                return;
            }
            int len = currentFilePathLCDText.Length;
            currentFilePathLCDText = currentFilePathLCDText.Substring(len - 1, 1) +  currentFilePathLCDText.Substring(0, len - 1);
            
            filePathLCD.Text = currentFilePathLCDText.Substring(0, maxWidth);

            currentNamePathLCDCounter++;
            if (currentNamePathLCDCounter == 3)
            {
                len = currentNamePathLCDText.Length;
                currentNamePathLCDText = currentNamePathLCDText.Substring(len - 1, 1) + currentNamePathLCDText.Substring(0, len - 1);

                fileNameLCD.Text = currentNamePathLCDText.Substring(0, maxWidth);
                currentNamePathLCDCounter = 0;
            }
        }

        // Next - Button
        private void nextButton_Click(object sender, EventArgs e)
        {
            int lastIndex = playlistBox.Items.Count-1;
            previousButton.Enabled = true;

                if (lastIndex == playlistBox.SelectedIndex)
                {
                    nextButton.Enabled = false;
                }
                else
                {
                    playlistBox.SelectedIndex++;
                }
        }

        // Previous - Button
        private void previousButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
            if (playlistBox.SelectedIndex == 0)
            {
                previousButton.Enabled = false;
            }
            else
            {
                playlistBox.SelectedIndex--;
            }
        }

        // Selecting track's from playlist
        protected void playlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanUp();
            rightVU.Visible = true;
            leftVU.Visible = true;
            loadButton.Enabled = true;
            playButton.Enabled = true;
            clearButton.Enabled = true;
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            revDown.Enabled = true;
            revUp.Enabled = true;
            pauseButton.Enabled = true;
            stopButton.Enabled = true;
            randomButton.Enabled = true;
            volumeLvl.Enabled = true;
            playlistBox.AllowDrop = true;


            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
            else
            {
                playlistBox.SelectedIndex = 0;
            }

            if (audioFile == null)
            {
                if ((paths[playlistBox.SelectedIndex]).EndsWith(".flac", StringComparison.OrdinalIgnoreCase))
                {
                    audioFile = new FlacReader(paths[playlistBox.SelectedIndex]);
                    outputDevice.Init(audioFile);
                    timer2.Start();
                    outputDevice.Play();
                }
                else
                {
                    audioFile = new AudioFileReader(paths[playlistBox.SelectedIndex]);
                    outputDevice.Init(audioFile);
                    timer2.Start();
                    outputDevice.Play();
                } 
                var file = TagLib.File.Create(paths[playlistBox.SelectedIndex]);
            
                    if (file.Tag.Pictures.Length == 0)
                    {
                        albumART.Image = null;
                    }
                    else
                    {
                        var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                        albumART.Image = Image.FromStream(new MemoryStream(bin));
                        this.albumART.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                bitrateLCD.Text = Convert.ToString(file.Properties.AudioBitrate+"kbs");
                currentNamePathLCDText = DynamicText(paths[playlistBox.SelectedIndex]);
                currentFilePathLCDText = DynamicText(Path.GetFileName((paths[playlistBox.SelectedIndex])));
                artistLCD.Text = Convert.ToString("Artist: " + file.Tag.FirstArtist);
                titleLCD.Text = Convert.ToString("Title: " + file.Tag.Title);
                albumLCD.Text = Convert.ToString("Album: " + file.Tag.Album);
                yearLCD.Text = Convert.ToString("Year: " + file.Tag.Year);
                genresLCD.Text = Convert.ToString("Genre: " + file.Tag.FirstGenre);
            }
            else
            {
                playlistBox.SelectedIndex = 0;
            }
        }

        // RevUP - Button
        private void revUp_Click(object sender, EventArgs e)
        {
            audioFile.Position += audioFile.WaveFormat.AverageBytesPerSecond;
            timeTrack.Maximum = Convert.ToInt32(audioFile.Length);

            long newPos = audioFile.Position + (long)(audioFile.WaveFormat.AverageBytesPerSecond * 2.5);
            if ((newPos % audioFile.WaveFormat.BlockAlign) != 0)
                newPos += newPos % audioFile.WaveFormat.BlockAlign;

            newPos = Math.Max(0, Math.Min(audioFile.Length, newPos));
            audioFile.Position = newPos;
        }

        // Exit - Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            CleanUp();
            this.Close();
        }

        // RevDown - Button
        private void revDown_Click(object sender, EventArgs e)
        {
            audioFile.Position -= audioFile.WaveFormat.AverageBytesPerSecond;
            timeTrack.Maximum = Convert.ToInt32(audioFile.Length);

            long newPos = audioFile.Position - (long)(audioFile.WaveFormat.AverageBytesPerSecond * 2.5);
            if ((newPos % audioFile.WaveFormat.BlockAlign) != 0)
                newPos -= newPos % audioFile.WaveFormat.BlockAlign;

            newPos = Math.Max(0, Math.Min(audioFile.Length, newPos));
            audioFile.Position = newPos;
        }

        // Cleaning the data buffer.
        private bool Clean()
        {
            try
            {
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    outputDevice = null;
                }
                if (audioFile != null)
                {
                    audioFile.Close();
                    audioFile.Dispose();
                    audioFile = null;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
            return true;
        }

        // Clear - Button - Applicaton Restart
        private void clearButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Load - Button
        private void loadButton_Click(object sender, EventArgs e)
        {
            ofd.Filter = ("Music files|*.mp3;*.flac;*.wav;*.wma");
            ofd.Multiselect = true;

            if ((ofd.ShowDialog()) == (System.Windows.Forms.DialogResult.OK))
            {
                string[] newFiles = ofd.SafeFileNames;
                string[] newPaths = ofd.FileNames;

                files.AddRange(newFiles);
                paths.AddRange(newPaths);
                bool startFromEmptyList = false;

                    if(playlistBox.Items.Count == 0)
                    {
                        startFromEmptyList = true;
                        currentNamePathLCDText = DynamicText(ofd.FileName);
                        currentFilePathLCDText = DynamicText(ofd.SafeFileName);
                }
                    for (int i = 0; i < newFiles.Length; i++)
                        {
                            playlistBox.Items.Add(newFiles[i]);
                        }

                if(startFromEmptyList)
                {
                    playlistBox.SelectedIndex = 0;
                }
             
                loadButton.Enabled = true;
                playButton.Enabled = true;
                clearButton.Enabled = true;
                previousButton.Enabled = true;
                nextButton.Enabled = true;
                revDown.Enabled = true;
                revUp.Enabled = true;
                pauseButton.Enabled = true;
                randomButton.Enabled = true;
                volumeLvl.Enabled = true;
            }
           
        }
        // Now Playing - Button
        private void nowPlayingButton_Click(object sender, EventArgs e)
        {
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    this.Width = 1355;
                    break;
                case 2:
                    this.Width = 1040;
                    NumberOfClick = 0;
                    break;
            }
        }

        // Minimalize - Button
        private void minimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Random - Button - Selecting random track.
        private void randomButton_Click(object sender, EventArgs e)
        {            
            Random random = new Random();

            int startValue = 0;
            int endValue = playlistBox.Items.Count;
            int randomValue = random.Next(startValue, endValue);

            playlistBox.SelectedIndex = randomValue;
        }

        // CleanUP - sequence
        private void CleanUp()
        {
            while (!Clean())
            {
                this.TopMost = true;
            }
        }

        // Drag&Drop Feature - PlaylistBOX
        private void playlistBox_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy; // Okay
            string[] newPaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            string[] newFiles = newPaths.Select(p => Path.GetFileName(p)).ToArray();

            paths.AddRange(newPaths);
            files.AddRange(newFiles);

            bool startFromEmptyList = false;
            if (playlistBox.Items.Count == 0)
            {
                startFromEmptyList = true;
                currentNamePathLCDText = DynamicText(ofd.FileName);
                currentFilePathLCDText = DynamicText(ofd.SafeFileName);
            }
            for (int i = 0; i < newFiles.Length; i++)
            {
                playlistBox.Items.Add(newFiles[i]);
            }

            if (startFromEmptyList)
            {
                playlistBox.SelectedIndex = 0;
            }

            loadButton.Enabled = true;
            playButton.Enabled = true;
            clearButton.Enabled = true;
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            revDown.Enabled = true;
            revUp.Enabled = true;
            pauseButton.Enabled = true;
            randomButton.Enabled = true;
            volumeLvl.Enabled = true;
        }

        // Drag&Enter Feature - File extension restrictions.
        private void playlistBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                
                foreach (string filename in filenames)
                {
                    if (Path.GetExtension(filename) == ".flac" || Path.GetExtension(filename) == ".mp3" || Path.GetExtension(filename) == ".wav" || Path.GetExtension(filename) == ".wma")
                    {
                        e.Effect = DragDropEffects.Copy; // Okay
                    }
                    else
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
            }

        }
    }
}