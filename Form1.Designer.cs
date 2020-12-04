namespace Zadanie5_Mateusz_Moczarski
{
    partial class Form
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelTimePlay = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelTimeLeft = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearList = new System.Windows.Forms.Button();
            this.filesList = new System.Windows.Forms.ListBox();
            this.directoriesList = new System.Windows.Forms.ListBox();
            this.playlist = new System.Windows.Forms.ListBox();
            this.addFileButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.loopPlaylist = new System.Windows.Forms.Button();
            this.loopAsync = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playAsync = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.TextBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.pictureBoxWave = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.labelPlaylistLength = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel,
            this.toolStripSeparator1,
            this.toolStripLabelTimePlay,
            this.toolStripSeparator2,
            this.toolStripLabelTimeLeft});
            this.toolStrip1.Location = new System.Drawing.Point(0, 591);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1376, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel.Text = "Info";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelTimePlay
            // 
            this.toolStripLabelTimePlay.Name = "toolStripLabelTimePlay";
            this.toolStripLabelTimePlay.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelTimeLeft
            // 
            this.toolStripLabelTimeLeft.Name = "toolStripLabelTimeLeft";
            this.toolStripLabelTimeLeft.Size = new System.Drawing.Size(0, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(898, 203);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(80, 37);
            this.clearList.TabIndex = 34;
            this.clearList.Text = "Czyść";
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.ItemHeight = 16;
            this.filesList.Location = new System.Drawing.Point(898, 246);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(478, 100);
            this.filesList.TabIndex = 33;
            this.filesList.DoubleClick += new System.EventHandler(this.AddToPlaylist);
            // 
            // directoriesList
            // 
            this.directoriesList.FormattingEnabled = true;
            this.directoriesList.ItemHeight = 16;
            this.directoriesList.Location = new System.Drawing.Point(510, 246);
            this.directoriesList.Name = "directoriesList";
            this.directoriesList.Size = new System.Drawing.Size(382, 100);
            this.directoriesList.TabIndex = 32;
            this.directoriesList.DoubleClick += new System.EventHandler(this.selectDir);
            // 
            // playlist
            // 
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 16;
            this.playlist.Location = new System.Drawing.Point(510, 46);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(866, 148);
            this.playlist.TabIndex = 31;
            this.playlist.DoubleClick += new System.EventHandler(this.SelectAudio);
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(510, 203);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(382, 37);
            this.addFileButton.TabIndex = 30;
            this.addFileButton.Text = "Dodaj do playlisty";
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(424, 74);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(80, 37);
            this.nextButton.TabIndex = 29;
            this.nextButton.Text = "Następny";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(330, 74);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 37);
            this.backButton.TabIndex = 28;
            this.backButton.Text = "Poprzedni";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loopPlaylist
            // 
            this.loopPlaylist.Location = new System.Drawing.Point(12, 266);
            this.loopPlaylist.Name = "loopPlaylist";
            this.loopPlaylist.Size = new System.Drawing.Size(312, 37);
            this.loopPlaylist.TabIndex = 27;
            this.loopPlaylist.Text = "Pętla playlisty";
            this.loopPlaylist.Click += new System.EventHandler(this.loopPlaylist_Click);
            // 
            // loopAsync
            // 
            this.loopAsync.Location = new System.Drawing.Point(12, 223);
            this.loopAsync.Name = "loopAsync";
            this.loopAsync.Size = new System.Drawing.Size(312, 37);
            this.loopAsync.TabIndex = 26;
            this.loopAsync.Text = "Pętla";
            this.loopAsync.Click += new System.EventHandler(this.loopAsync_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(12, 117);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(312, 37);
            this.pauseButton.TabIndex = 25;
            this.pauseButton.Text = "Stop";
            this.pauseButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playAsync
            // 
            this.playAsync.Location = new System.Drawing.Point(12, 74);
            this.playAsync.Name = "playAsync";
            this.playAsync.Size = new System.Drawing.Size(312, 37);
            this.playAsync.TabIndex = 24;
            this.playAsync.Text = "Start";
            this.playAsync.Click += new System.EventHandler(this.playAsync_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(492, 17);
            this.label.TabIndex = 21;
            this.label.Text = "Ścieżka pliku:";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(481, 46);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(23, 21);
            this.selectFileButton.TabIndex = 20;
            this.selectFileButton.Text = "...";
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(12, 46);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(463, 22);
            this.filepath.TabIndex = 19;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(12, 309);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(312, 37);
            this.buttonRandom.TabIndex = 35;
            this.buttonRandom.Text = "Losowo";
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(330, 117);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(88, 37);
            this.buttonReverse.TabIndex = 36;
            this.buttonReverse.Text = "<<";
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(424, 117);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(80, 37);
            this.buttonForward.TabIndex = 37;
            this.buttonForward.Text = ">>";
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(510, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 37);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(596, 3);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(80, 37);
            this.buttonUp.TabIndex = 39;
            this.buttonUp.Text = "W górę";
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(682, 3);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(80, 37);
            this.buttonDown.TabIndex = 40;
            this.buttonDown.Text = "W dół";
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(60, 160);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(444, 22);
            this.textBoxURL.TabIndex = 41;
            // 
            // labelURL
            // 
            this.labelURL.Location = new System.Drawing.Point(9, 163);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(45, 17);
            this.labelURL.TabIndex = 42;
            this.labelURL.Text = "URL:";
            // 
            // pictureBoxWave
            // 
            this.pictureBoxWave.Location = new System.Drawing.Point(0, 353);
            this.pictureBoxWave.Name = "pictureBoxWave";
            this.pictureBoxWave.Size = new System.Drawing.Size(1376, 183);
            this.pictureBoxWave.TabIndex = 43;
            this.pictureBoxWave.TabStop = false;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(330, 188);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(174, 158);
            this.pictureBoxAlbum.TabIndex = 44;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 551);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1376, 21);
            this.hScrollBar1.TabIndex = 45;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Slide);
            // 
            // labelPlaylistLength
            // 
            this.labelPlaylistLength.Location = new System.Drawing.Point(768, 3);
            this.labelPlaylistLength.Name = "labelPlaylistLength";
            this.labelPlaylistLength.Size = new System.Drawing.Size(322, 37);
            this.labelPlaylistLength.TabIndex = 46;
            this.labelPlaylistLength.Text = "Długość playlisty: ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 616);
            this.Controls.Add(this.labelPlaylistLength);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.pictureBoxWave);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.directoriesList);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loopPlaylist);
            this.Controls.Add(this.loopAsync);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playAsync);
            this.Controls.Add(this.label);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "MP3 Player by Moczarski";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.ListBox directoriesList;
        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button loopPlaylist;
        private System.Windows.Forms.Button loopAsync;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button playAsync;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.PictureBox pictureBoxWave;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTimePlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTimeLeft;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label labelPlaylistLength;
    }
}

