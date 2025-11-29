namespace MusicPlayerApp
{
    partial class MusicPlayerApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            TopPanel = new Panel();
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            listBoxSongs = new ListBox();
            btnSelectSongs = new Button();
            axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            lblFooter = new Label();
            btnPlayNextSong = new Button();
            btnPlayAll = new Button();
            btnStop = new Button();
            btnClearListBox = new Button();
            btnPlayPrevSong = new Button();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerMusic).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.PaleTurquoise;
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Controls.Add(lblLogo);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 35);
            TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(761, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Bradley Hand ITC", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(7, 6);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(167, 24);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Music Player App";
            // 
            // listBoxSongs
            // 
            listBoxSongs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.ItemHeight = 17;
            listBoxSongs.Location = new Point(1, 71);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(343, 276);
            listBoxSongs.TabIndex = 1;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // btnSelectSongs
            // 
            btnSelectSongs.BackColor = Color.DeepSkyBlue;
            btnSelectSongs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectSongs.ForeColor = SystemColors.ButtonHighlight;
            btnSelectSongs.Location = new Point(0, 37);
            btnSelectSongs.Name = "btnSelectSongs";
            btnSelectSongs.Size = new Size(170, 30);
            btnSelectSongs.TabIndex = 2;
            btnSelectSongs.Text = "Select Songs";
            btnSelectSongs.UseVisualStyleBackColor = false;
            btnSelectSongs.Click += btnSelectSongs_Click;
            // 
            // axWindowsMediaPlayerMusic
            // 
            axWindowsMediaPlayerMusic.Enabled = true;
            axWindowsMediaPlayerMusic.Location = new Point(345, 37);
            axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            axWindowsMediaPlayerMusic.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayerMusic.OcxState");
            axWindowsMediaPlayerMusic.Size = new Size(452, 310);
            axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // lblFooter
            // 
            lblFooter.Anchor = AnchorStyles.Bottom;
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = SystemColors.ControlDarkDark;
            lblFooter.Location = new Point(251, 401);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(296, 15);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "Developed by: Group 2 Nick Marsh, Cynthia Hanevik";
            // 
            // btnPlayNextSong
            // 
            btnPlayNextSong.BackColor = Color.DeepSkyBlue;
            btnPlayNextSong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayNextSong.ForeColor = SystemColors.ButtonHighlight;
            btnPlayNextSong.Location = new Point(118, 350);
            btnPlayNextSong.Name = "btnPlayNextSong";
            btnPlayNextSong.Size = new Size(127, 25);
            btnPlayNextSong.TabIndex = 6;
            btnPlayNextSong.Text = "Play Next Song";
            btnPlayNextSong.UseVisualStyleBackColor = false;
            btnPlayNextSong.Click += btnPlayNextSong_Click;
            // 
            // btnPlayAll
            // 
            btnPlayAll.BackColor = Color.DeepSkyBlue;
            btnPlayAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayAll.ForeColor = SystemColors.ButtonHighlight;
            btnPlayAll.Location = new Point(3, 350);
            btnPlayAll.Name = "btnPlayAll";
            btnPlayAll.Size = new Size(110, 25);
            btnPlayAll.TabIndex = 7;
            btnPlayAll.Text = "Play All Songs";
            btnPlayAll.UseVisualStyleBackColor = false;
            btnPlayAll.Click += btnPlayAll_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.DeepSkyBlue;
            btnStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.ForeColor = SystemColors.ButtonHighlight;
            btnStop.Location = new Point(1, 381);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(110, 25);
            btnStop.TabIndex = 8;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnClearListBox
            // 
            btnClearListBox.BackColor = Color.DeepSkyBlue;
            btnClearListBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearListBox.ForeColor = SystemColors.ButtonHighlight;
            btnClearListBox.Location = new Point(176, 37);
            btnClearListBox.Name = "btnClearListBox";
            btnClearListBox.Size = new Size(168, 30);
            btnClearListBox.TabIndex = 9;
            btnClearListBox.Text = "Clear Song List";
            btnClearListBox.UseVisualStyleBackColor = false;
            btnClearListBox.Click += btnClearListBox_Click;
            // 
            // btnPlayPrevSong
            // 
            btnPlayPrevSong.BackColor = Color.DeepSkyBlue;
            btnPlayPrevSong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayPrevSong.ForeColor = SystemColors.ButtonHighlight;
            btnPlayPrevSong.Location = new Point(117, 381);
            btnPlayPrevSong.Name = "btnPlayPrevSong";
            btnPlayPrevSong.Size = new Size(128, 25);
            btnPlayPrevSong.TabIndex = 10;
            btnPlayPrevSong.Text = "Play Previous Song";
            btnPlayPrevSong.UseVisualStyleBackColor = false;
            btnPlayPrevSong.Click += btnPlayPrevSong_Click;
            // 
            // MusicPlayerApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 425);
            Controls.Add(btnPlayPrevSong);
            Controls.Add(btnClearListBox);
            Controls.Add(btnStop);
            Controls.Add(btnPlayAll);
            Controls.Add(btnPlayNextSong);
            Controls.Add(lblFooter);
            Controls.Add(axWindowsMediaPlayerMusic);
            Controls.Add(btnSelectSongs);
            Controls.Add(listBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayerApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player App";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerMusic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label lblLogo;
        private PictureBox pictureBox1;
        private ListBox listBoxSongs;
        private Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private Label lblFooter;
        private Button btnPlayNextSong;
        private Button btnPlayAll;
        private Button btnStop;
        private Button btnClearListBox;
        private Button btnPlayPrevSong;
    }
}
