namespace WangPlayer
{
    partial class Player
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.currentTimeLCD = new System.Windows.Forms.TextBox();
            this.trackLCD = new System.Windows.Forms.TextBox();
            this.bitrateBackground = new System.Windows.Forms.PictureBox();
            this.fileNameLCD = new System.Windows.Forms.TextBox();
            this.fileBackground = new System.Windows.Forms.PictureBox();
            this.timeTrack = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.durrationBitLCD = new System.Windows.Forms.TextBox();
            this.timeBackground = new System.Windows.Forms.PictureBox();
            this.volumeLvl = new System.Windows.Forms.TrackBar();
            this.volumeBackground = new System.Windows.Forms.PictureBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.Peak1 = new System.Windows.Forms.PictureBox();
            this.Peak2 = new System.Windows.Forms.PictureBox();
            this.Peak3 = new System.Windows.Forms.PictureBox();
            this.Peak4 = new System.Windows.Forms.PictureBox();
            this.Peak5 = new System.Windows.Forms.PictureBox();
            this.Peak6 = new System.Windows.Forms.PictureBox();
            this.Peak7 = new System.Windows.Forms.PictureBox();
            this.Peak8 = new System.Windows.Forms.PictureBox();
            this.Peak9 = new System.Windows.Forms.PictureBox();
            this.Peak10 = new System.Windows.Forms.PictureBox();
            this.leftVU = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rightVU = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.currentBitPossitionLCD = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.filePathLCD = new System.Windows.Forms.Label();
            this.revDown = new System.Windows.Forms.Button();
            this.revUp = new System.Windows.Forms.Button();
            this.durrationTimeLCD = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.channelsCD = new System.Windows.Forms.TextBox();
            this.sampleRateLCD = new System.Windows.Forms.TextBox();
            this.volumeLCD = new System.Windows.Forms.TextBox();
            this.albumART = new System.Windows.Forms.PictureBox();
            this.bitrateLCD = new System.Windows.Forms.TextBox();
            this.nowPlayingButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.titleLCD = new System.Windows.Forms.TextBox();
            this.artistLCD = new System.Windows.Forms.TextBox();
            this.albumLCD = new System.Windows.Forms.TextBox();
            this.yearLCD = new System.Windows.Forms.TextBox();
            this.genresLCD = new System.Windows.Forms.TextBox();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // playlistBox
            // 
            this.playlistBox.AllowDrop = true;
            this.playlistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.playlistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.ItemHeight = 24;
            this.playlistBox.Location = new System.Drawing.Point(302, 388);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(423, 120);
            this.playlistBox.TabIndex = 37;
            this.playlistBox.SelectedIndexChanged += new System.EventHandler(this.playlistBox_SelectedIndexChanged);
            this.playlistBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.playlistBox_DragDrop);
            this.playlistBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.playlistBox_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WangPlayer.Properties.Resources.LCD_3;
            this.pictureBox2.Location = new System.Drawing.Point(284, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 154);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // currentTimeLCD
            // 
            this.currentTimeLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.currentTimeLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentTimeLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.currentTimeLCD.Location = new System.Drawing.Point(181, 209);
            this.currentTimeLCD.Name = "currentTimeLCD";
            this.currentTimeLCD.Size = new System.Drawing.Size(194, 34);
            this.currentTimeLCD.TabIndex = 36;
            this.currentTimeLCD.Text = "<currentTime>";
            this.currentTimeLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackLCD
            // 
            this.trackLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.trackLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trackLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trackLCD.Location = new System.Drawing.Point(176, 260);
            this.trackLCD.Name = "trackLCD";
            this.trackLCD.Size = new System.Drawing.Size(54, 14);
            this.trackLCD.TabIndex = 35;
            this.trackLCD.Text = "<track>";
            this.trackLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bitrateBackground
            // 
            this.bitrateBackground.BackgroundImage = global::WangPlayer.Properties.Resources.LCD_1;
            this.bitrateBackground.Location = new System.Drawing.Point(166, 201);
            this.bitrateBackground.Name = "bitrateBackground";
            this.bitrateBackground.Size = new System.Drawing.Size(226, 86);
            this.bitrateBackground.TabIndex = 34;
            this.bitrateBackground.TabStop = false;
            // 
            // fileNameLCD
            // 
            this.fileNameLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.fileNameLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNameLCD.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNameLCD.Location = new System.Drawing.Point(130, 65);
            this.fileNameLCD.Name = "fileNameLCD";
            this.fileNameLCD.Size = new System.Drawing.Size(758, 28);
            this.fileNameLCD.TabIndex = 32;
            this.fileNameLCD.Text = "<file_name>";
            this.fileNameLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileBackground
            // 
            this.fileBackground.BackgroundImage = global::WangPlayer.Properties.Resources.LCD_2;
            this.fileBackground.Location = new System.Drawing.Point(118, 26);
            this.fileBackground.Name = "fileBackground";
            this.fileBackground.Size = new System.Drawing.Size(786, 77);
            this.fileBackground.TabIndex = 31;
            this.fileBackground.TabStop = false;
            // 
            // timeTrack
            // 
            this.timeTrack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeTrack.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeTrack.LargeChange = 1;
            this.timeTrack.Location = new System.Drawing.Point(191, 129);
            this.timeTrack.Margin = new System.Windows.Forms.Padding(2);
            this.timeTrack.Maximum = 100;
            this.timeTrack.Name = "timeTrack";
            this.timeTrack.Size = new System.Drawing.Size(642, 45);
            this.timeTrack.TabIndex = 30;
            this.timeTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 86);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // durrationBitLCD
            // 
            this.durrationBitLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.durrationBitLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.durrationBitLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.durrationBitLCD.Location = new System.Drawing.Point(646, 241);
            this.durrationBitLCD.Name = "durrationBitLCD";
            this.durrationBitLCD.Size = new System.Drawing.Size(200, 14);
            this.durrationBitLCD.TabIndex = 28;
            this.durrationBitLCD.Text = "<durrationBit>";
            this.durrationBitLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeBackground
            // 
            this.timeBackground.BackgroundImage = global::WangPlayer.Properties.Resources.LCD_1;
            this.timeBackground.Location = new System.Drawing.Point(630, 201);
            this.timeBackground.Name = "timeBackground";
            this.timeBackground.Size = new System.Drawing.Size(226, 86);
            this.timeBackground.TabIndex = 27;
            this.timeBackground.TabStop = false;
            // 
            // volumeLvl
            // 
            this.volumeLvl.BackColor = System.Drawing.Color.Black;
            this.volumeLvl.Enabled = false;
            this.volumeLvl.LargeChange = 1;
            this.volumeLvl.Location = new System.Drawing.Point(398, 205);
            this.volumeLvl.Margin = new System.Windows.Forms.Padding(2);
            this.volumeLvl.Name = "volumeLvl";
            this.volumeLvl.Size = new System.Drawing.Size(226, 45);
            this.volumeLvl.TabIndex = 25;
            this.volumeLvl.Scroll += new System.EventHandler(this.volumeLvl_Scroll);
            // 
            // volumeBackground
            // 
            this.volumeBackground.BackgroundImage = global::WangPlayer.Properties.Resources.volumeBackground;
            this.volumeBackground.Location = new System.Drawing.Point(398, 201);
            this.volumeBackground.Name = "volumeBackground";
            this.volumeBackground.Size = new System.Drawing.Size(226, 86);
            this.volumeBackground.TabIndex = 26;
            this.volumeBackground.TabStop = false;
            // 
            // previousButton
            // 
            this.previousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousButton.BackgroundImage")));
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(268, 293);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(100, 75);
            this.previousButton.TabIndex = 24;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(652, 293);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 75);
            this.nextButton.TabIndex = 23;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(461, 293);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(100, 75);
            this.pauseButton.TabIndex = 22;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(558, 293);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 75);
            this.stopButton.TabIndex = 21;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::WangPlayer.Properties.Resources.playButton;
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(365, 293);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 75);
            this.playButton.TabIndex = 20;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Peak1
            // 
            this.Peak1.BackColor = System.Drawing.Color.Transparent;
            this.Peak1.BackgroundImage = global::WangPlayer.Properties.Resources.vol0;
            this.Peak1.Location = new System.Drawing.Point(410, 250);
            this.Peak1.Name = "Peak1";
            this.Peak1.Size = new System.Drawing.Size(33, 29);
            this.Peak1.TabIndex = 39;
            this.Peak1.TabStop = false;
            // 
            // Peak2
            // 
            this.Peak2.BackColor = System.Drawing.Color.Transparent;
            this.Peak2.BackgroundImage = global::WangPlayer.Properties.Resources.vol1;
            this.Peak2.Location = new System.Drawing.Point(449, 250);
            this.Peak2.Name = "Peak2";
            this.Peak2.Size = new System.Drawing.Size(18, 29);
            this.Peak2.TabIndex = 40;
            this.Peak2.TabStop = false;
            // 
            // Peak3
            // 
            this.Peak3.BackColor = System.Drawing.Color.Transparent;
            this.Peak3.BackgroundImage = global::WangPlayer.Properties.Resources.vol1;
            this.Peak3.Location = new System.Drawing.Point(467, 250);
            this.Peak3.Name = "Peak3";
            this.Peak3.Size = new System.Drawing.Size(18, 29);
            this.Peak3.TabIndex = 41;
            this.Peak3.TabStop = false;
            // 
            // Peak4
            // 
            this.Peak4.BackColor = System.Drawing.Color.Transparent;
            this.Peak4.BackgroundImage = global::WangPlayer.Properties.Resources.vol1;
            this.Peak4.Location = new System.Drawing.Point(485, 250);
            this.Peak4.Name = "Peak4";
            this.Peak4.Size = new System.Drawing.Size(18, 29);
            this.Peak4.TabIndex = 42;
            this.Peak4.TabStop = false;
            // 
            // Peak5
            // 
            this.Peak5.BackColor = System.Drawing.Color.Transparent;
            this.Peak5.BackgroundImage = global::WangPlayer.Properties.Resources.vol1;
            this.Peak5.Location = new System.Drawing.Point(501, 250);
            this.Peak5.Name = "Peak5";
            this.Peak5.Size = new System.Drawing.Size(18, 29);
            this.Peak5.TabIndex = 43;
            this.Peak5.TabStop = false;
            // 
            // Peak6
            // 
            this.Peak6.BackColor = System.Drawing.Color.Transparent;
            this.Peak6.BackgroundImage = global::WangPlayer.Properties.Resources.vol1;
            this.Peak6.Location = new System.Drawing.Point(519, 250);
            this.Peak6.Name = "Peak6";
            this.Peak6.Size = new System.Drawing.Size(18, 29);
            this.Peak6.TabIndex = 44;
            this.Peak6.TabStop = false;
            // 
            // Peak7
            // 
            this.Peak7.BackColor = System.Drawing.Color.Transparent;
            this.Peak7.BackgroundImage = global::WangPlayer.Properties.Resources.vol2;
            this.Peak7.Location = new System.Drawing.Point(537, 250);
            this.Peak7.Name = "Peak7";
            this.Peak7.Size = new System.Drawing.Size(18, 29);
            this.Peak7.TabIndex = 45;
            this.Peak7.TabStop = false;
            // 
            // Peak8
            // 
            this.Peak8.BackColor = System.Drawing.Color.Transparent;
            this.Peak8.BackgroundImage = global::WangPlayer.Properties.Resources.vol2;
            this.Peak8.Location = new System.Drawing.Point(555, 250);
            this.Peak8.Name = "Peak8";
            this.Peak8.Size = new System.Drawing.Size(18, 29);
            this.Peak8.TabIndex = 46;
            this.Peak8.TabStop = false;
            // 
            // Peak9
            // 
            this.Peak9.BackColor = System.Drawing.Color.Transparent;
            this.Peak9.BackgroundImage = global::WangPlayer.Properties.Resources.vol3;
            this.Peak9.Location = new System.Drawing.Point(573, 250);
            this.Peak9.Name = "Peak9";
            this.Peak9.Size = new System.Drawing.Size(18, 29);
            this.Peak9.TabIndex = 47;
            this.Peak9.TabStop = false;
            // 
            // Peak10
            // 
            this.Peak10.BackColor = System.Drawing.Color.Transparent;
            this.Peak10.BackgroundImage = global::WangPlayer.Properties.Resources.vol4;
            this.Peak10.Location = new System.Drawing.Point(590, 250);
            this.Peak10.Name = "Peak10";
            this.Peak10.Size = new System.Drawing.Size(18, 29);
            this.Peak10.TabIndex = 48;
            this.Peak10.TabStop = false;
            // 
            // leftVU
            // 
            this.leftVU.Location = new System.Drawing.Point(26, 114);
            this.leftVU.Name = "leftVU";
            this.leftVU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.leftVU.RightToLeftLayout = true;
            this.leftVU.Size = new System.Drawing.Size(128, 38);
            this.leftVU.TabIndex = 50;
            this.leftVU.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rightVU
            // 
            this.rightVU.BackColor = System.Drawing.SystemColors.Control;
            this.rightVU.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rightVU.Location = new System.Drawing.Point(868, 114);
            this.rightVU.Name = "rightVU";
            this.rightVU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rightVU.Size = new System.Drawing.Size(128, 38);
            this.rightVU.TabIndex = 50;
            this.rightVU.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WangPlayer.Properties.Resources.vuBackground;
            this.pictureBox3.Location = new System.Drawing.Point(18, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 49);
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WangPlayer.Properties.Resources.vuBackground;
            this.pictureBox4.Location = new System.Drawing.Point(859, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 49);
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // currentBitPossitionLCD
            // 
            this.currentBitPossitionLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.currentBitPossitionLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentBitPossitionLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentBitPossitionLCD.Location = new System.Drawing.Point(181, 241);
            this.currentBitPossitionLCD.Name = "currentBitPossitionLCD";
            this.currentBitPossitionLCD.Size = new System.Drawing.Size(200, 14);
            this.currentBitPossitionLCD.TabIndex = 53;
            this.currentBitPossitionLCD.Text = "<currentBitPossition>";
            this.currentBitPossitionLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // filePathLCD
            // 
            this.filePathLCD.AutoSize = true;
            this.filePathLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.filePathLCD.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filePathLCD.Location = new System.Drawing.Point(135, 33);
            this.filePathLCD.Name = "filePathLCD";
            this.filePathLCD.Size = new System.Drawing.Size(180, 27);
            this.filePathLCD.TabIndex = 57;
            this.filePathLCD.Text = "<file_paths>";
            // 
            // revDown
            // 
            this.revDown.BackgroundImage = global::WangPlayer.Properties.Resources.rev_downButton;
            this.revDown.Enabled = false;
            this.revDown.Location = new System.Drawing.Point(202, 151);
            this.revDown.Name = "revDown";
            this.revDown.Size = new System.Drawing.Size(75, 18);
            this.revDown.TabIndex = 58;
            this.revDown.UseVisualStyleBackColor = true;
            this.revDown.Click += new System.EventHandler(this.revDown_Click);
            // 
            // revUp
            // 
            this.revUp.BackgroundImage = global::WangPlayer.Properties.Resources.rev_upButton;
            this.revUp.Enabled = false;
            this.revUp.Location = new System.Drawing.Point(748, 151);
            this.revUp.Name = "revUp";
            this.revUp.Size = new System.Drawing.Size(75, 18);
            this.revUp.TabIndex = 59;
            this.revUp.UseVisualStyleBackColor = true;
            this.revUp.Click += new System.EventHandler(this.revUp_Click);
            // 
            // durrationTimeLCD
            // 
            this.durrationTimeLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.durrationTimeLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.durrationTimeLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.durrationTimeLCD.Location = new System.Drawing.Point(646, 209);
            this.durrationTimeLCD.Name = "durrationTimeLCD";
            this.durrationTimeLCD.Size = new System.Drawing.Size(194, 34);
            this.durrationTimeLCD.TabIndex = 60;
            this.durrationTimeLCD.Text = "<durration>";
            this.durrationTimeLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::WangPlayer.Properties.Resources.exitButton;
            this.exitButton.Location = new System.Drawing.Point(910, 53);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 61;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = global::WangPlayer.Properties.Resources.clearButton;
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(660, 151);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 18);
            this.clearButton.TabIndex = 62;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackgroundImage = global::WangPlayer.Properties.Resources.loadButton;
            this.loadButton.Location = new System.Drawing.Point(290, 151);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 18);
            this.loadButton.TabIndex = 63;
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // channelsCD
            // 
            this.channelsCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.channelsCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.channelsCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channelsCD.Location = new System.Drawing.Point(236, 260);
            this.channelsCD.Name = "channelsCD";
            this.channelsCD.Size = new System.Drawing.Size(85, 14);
            this.channelsCD.TabIndex = 64;
            this.channelsCD.Text = "<channels>";
            this.channelsCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sampleRateLCD
            // 
            this.sampleRateLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.sampleRateLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampleRateLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sampleRateLCD.Location = new System.Drawing.Point(646, 260);
            this.sampleRateLCD.Name = "sampleRateLCD";
            this.sampleRateLCD.Size = new System.Drawing.Size(141, 14);
            this.sampleRateLCD.TabIndex = 65;
            this.sampleRateLCD.Text = "<sample_rate>";
            this.sampleRateLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeLCD
            // 
            this.volumeLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.volumeLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volumeLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volumeLCD.Location = new System.Drawing.Point(322, 260);
            this.volumeLCD.Name = "volumeLCD";
            this.volumeLCD.Size = new System.Drawing.Size(59, 14);
            this.volumeLCD.TabIndex = 66;
            this.volumeLCD.Text = "<vol>";
            this.volumeLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // albumART
            // 
            this.albumART.BackgroundImage = global::WangPlayer.Properties.Resources.albumArt_background;
            this.albumART.Location = new System.Drawing.Point(1051, 141);
            this.albumART.Name = "albumART";
            this.albumART.Size = new System.Drawing.Size(260, 260);
            this.albumART.TabIndex = 67;
            this.albumART.TabStop = false;
            // 
            // bitrateLCD
            // 
            this.bitrateLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.bitrateLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bitrateLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bitrateLCD.Location = new System.Drawing.Point(780, 261);
            this.bitrateLCD.Name = "bitrateLCD";
            this.bitrateLCD.Size = new System.Drawing.Size(66, 14);
            this.bitrateLCD.TabIndex = 68;
            this.bitrateLCD.Text = "<bitrate>";
            this.bitrateLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nowPlayingButton
            // 
            this.nowPlayingButton.BackgroundImage = global::WangPlayer.Properties.Resources.now_playingButton;
            this.nowPlayingButton.Location = new System.Drawing.Point(378, 151);
            this.nowPlayingButton.Name = "nowPlayingButton";
            this.nowPlayingButton.Size = new System.Drawing.Size(151, 18);
            this.nowPlayingButton.TabIndex = 69;
            this.nowPlayingButton.UseVisualStyleBackColor = true;
            this.nowPlayingButton.Click += new System.EventHandler(this.nowPlayingButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WangPlayer.Properties.Resources.albumArt_Border;
            this.pictureBox5.Location = new System.Drawing.Point(1046, 136);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(270, 270);
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WangPlayer.Properties.Resources.LCD_4;
            this.pictureBox6.Location = new System.Drawing.Point(1046, 413);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(269, 154);
            this.pictureBox6.TabIndex = 71;
            this.pictureBox6.TabStop = false;
            // 
            // titleLCD
            // 
            this.titleLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.titleLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titleLCD.Location = new System.Drawing.Point(1065, 458);
            this.titleLCD.Name = "titleLCD";
            this.titleLCD.Size = new System.Drawing.Size(235, 25);
            this.titleLCD.TabIndex = 72;
            this.titleLCD.Text = "<title>";
            this.titleLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // artistLCD
            // 
            this.artistLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.artistLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.artistLCD.Location = new System.Drawing.Point(1065, 426);
            this.artistLCD.Name = "artistLCD";
            this.artistLCD.Size = new System.Drawing.Size(235, 25);
            this.artistLCD.TabIndex = 73;
            this.artistLCD.Text = "<artist>";
            this.artistLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // albumLCD
            // 
            this.albumLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.albumLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.albumLCD.Location = new System.Drawing.Point(1065, 492);
            this.albumLCD.Name = "albumLCD";
            this.albumLCD.Size = new System.Drawing.Size(235, 16);
            this.albumLCD.TabIndex = 74;
            this.albumLCD.Text = "<album>";
            this.albumLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearLCD
            // 
            this.yearLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.yearLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yearLCD.Location = new System.Drawing.Point(1065, 514);
            this.yearLCD.Name = "yearLCD";
            this.yearLCD.Size = new System.Drawing.Size(235, 16);
            this.yearLCD.TabIndex = 75;
            this.yearLCD.Text = "<year>";
            this.yearLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genresLCD
            // 
            this.genresLCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.genresLCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genresLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genresLCD.Location = new System.Drawing.Point(1065, 536);
            this.genresLCD.Name = "genresLCD";
            this.genresLCD.Size = new System.Drawing.Size(235, 16);
            this.genresLCD.TabIndex = 76;
            this.genresLCD.Text = "<genre>";
            this.genresLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minimalizeButton
            // 
            this.minimalizeButton.BackgroundImage = global::WangPlayer.Properties.Resources.minimizeButton;
            this.minimalizeButton.Location = new System.Drawing.Point(62, 52);
            this.minimalizeButton.Name = "minimalizeButton";
            this.minimalizeButton.Size = new System.Drawing.Size(50, 50);
            this.minimalizeButton.TabIndex = 77;
            this.minimalizeButton.UseVisualStyleBackColor = true;
            this.minimalizeButton.Click += new System.EventHandler(this.minimalizeButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.BackgroundImage = global::WangPlayer.Properties.Resources.randomButton;
            this.randomButton.Enabled = false;
            this.randomButton.Location = new System.Drawing.Point(542, 151);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(105, 18);
            this.randomButton.TabIndex = 78;
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // Player
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1339, 600);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.minimalizeButton);
            this.Controls.Add(this.genresLCD);
            this.Controls.Add(this.yearLCD);
            this.Controls.Add(this.albumLCD);
            this.Controls.Add(this.artistLCD);
            this.Controls.Add(this.titleLCD);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.albumART);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.nowPlayingButton);
            this.Controls.Add(this.bitrateLCD);
            this.Controls.Add(this.volumeLCD);
            this.Controls.Add(this.sampleRateLCD);
            this.Controls.Add(this.channelsCD);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.playlistBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.durrationTimeLCD);
            this.Controls.Add(this.revUp);
            this.Controls.Add(this.revDown);
            this.Controls.Add(this.filePathLCD);
            this.Controls.Add(this.currentBitPossitionLCD);
            this.Controls.Add(this.rightVU);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.leftVU);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Peak10);
            this.Controls.Add(this.Peak9);
            this.Controls.Add(this.Peak8);
            this.Controls.Add(this.Peak7);
            this.Controls.Add(this.Peak6);
            this.Controls.Add(this.Peak5);
            this.Controls.Add(this.Peak4);
            this.Controls.Add(this.Peak3);
            this.Controls.Add(this.Peak2);
            this.Controls.Add(this.Peak1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.currentTimeLCD);
            this.Controls.Add(this.trackLCD);
            this.Controls.Add(this.fileNameLCD);
            this.Controls.Add(this.fileBackground);
            this.Controls.Add(this.timeTrack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.durrationBitLCD);
            this.Controls.Add(this.timeBackground);
            this.Controls.Add(this.volumeLvl);
            this.Controls.Add(this.volumeBackground);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.bitrateBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WangPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peak10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox currentTimeLCD;
        private System.Windows.Forms.TextBox trackLCD;
        private System.Windows.Forms.PictureBox bitrateBackground;
        private System.Windows.Forms.TextBox fileNameLCD;
        private System.Windows.Forms.PictureBox fileBackground;
        public System.Windows.Forms.TrackBar timeTrack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox durrationBitLCD;
        private System.Windows.Forms.PictureBox timeBackground;
        private System.Windows.Forms.TrackBar volumeLvl;
        private System.Windows.Forms.PictureBox volumeBackground;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox Peak1;
        private System.Windows.Forms.PictureBox Peak2;
        private System.Windows.Forms.PictureBox Peak3;
        private System.Windows.Forms.PictureBox Peak4;
        private System.Windows.Forms.PictureBox Peak5;
        private System.Windows.Forms.PictureBox Peak6;
        private System.Windows.Forms.PictureBox Peak7;
        private System.Windows.Forms.PictureBox Peak8;
        private System.Windows.Forms.PictureBox Peak9;
        private System.Windows.Forms.PictureBox Peak10;
        private System.Windows.Forms.ProgressBar leftVU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar rightVU;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox currentBitPossitionLCD;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label filePathLCD;
        private System.Windows.Forms.Button revDown;
        private System.Windows.Forms.Button revUp;
        private System.Windows.Forms.TextBox durrationTimeLCD;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox channelsCD;
        private System.Windows.Forms.TextBox sampleRateLCD;
        private System.Windows.Forms.TextBox volumeLCD;
        private System.Windows.Forms.PictureBox albumART;
        private System.Windows.Forms.TextBox bitrateLCD;
        private System.Windows.Forms.Button nowPlayingButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox titleLCD;
        private System.Windows.Forms.TextBox artistLCD;
        private System.Windows.Forms.TextBox albumLCD;
        private System.Windows.Forms.TextBox yearLCD;
        private System.Windows.Forms.TextBox genresLCD;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button randomButton;
    }
}

