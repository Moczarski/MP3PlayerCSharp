using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.IO;
using System.Threading;
using WaveFormRendererLib;
using System.Timers;

namespace Zadanie5_Mateusz_Moczarski
{
    public partial class Form : System.Windows.Forms.Form
    {

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private MediaFoundationReader fromURL;
        private string[] list;
        private bool loop;
        private bool playlistLoop;
        private bool random;
        private string title;
        private TimeSpan duration;
        private Pen penGray = new Pen(Color.Gray);
        private Pen penWhite = new Pen(Color.White);
        private System.Timers.Timer aTimer;
        private TimeSpan total;


        public Form()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private void Visualization()
        {
            var rmsPeakProvider = new RmsPeakProvider(200);
            var myRendererSettings = new StandardWaveFormRendererSettings();
            myRendererSettings.Width = 1376;
            myRendererSettings.TopHeight = 91;
            myRendererSettings.BottomHeight = 91;
            myRendererSettings.BackgroundColor = Color.Black;
            myRendererSettings.TopPeakPen = penWhite;
            myRendererSettings.BottomPeakPen = penGray;
            var renderer = new WaveFormRenderer();
            Image image = renderer.Render(filepath.Text, rmsPeakProvider, myRendererSettings);
            pictureBoxWave.Image = image;
        }

        private void InitializeBrowser()
        {
            list = Directory.GetFiles(@"D:\Users\MoczuPC");
            foreach (string name in list)
            {
                if (File.Exists(name))
                {
                    filesList.Items.Add(name);
                }
            }
            list = Directory.GetDirectories(@"D:\Users\MoczuPC");
            foreach (string name in list)
            {
                if (Directory.Exists(name))
                {
                    directoriesList.Items.Add(name);
                }
            }
        }

        private void selectDir(object sender, EventArgs e)
        {
            string temp;
            try
            {
                temp = directoriesList.SelectedItem.ToString();
                list = Directory.GetFiles(temp);
                filesList.Items.Clear();

                foreach (string name in list)
                {
                    if (File.Exists(name))
                    {
                        filesList.Items.Add(name);
                    }
                }

                temp = directoriesList.SelectedItem.ToString();
                list = Directory.GetDirectories(temp);
                directoriesList.Items.Clear();

                foreach (string name in list)
                {
                    if (Directory.Exists(name))
                    {
                        directoriesList.Items.Add(name);
                    }

                }
            }
            catch (Exception ex)
            {
                toolStripLabel.Text = "Problem z otwarciem folderu - " + ex.ToString();
            }

        }

        private void OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "Audio (*.MP3; *.WAV)|*.MP3; *.WAV";
            dlg.DefaultExt = ".mp3";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filepath.Text = dlg.FileName;
                    fromURL = new MediaFoundationReader(filepath.Text);
                }
                catch (Exception ex)
                {
                    toolStripLabel.Text = "Problem z otwarciem pliku - "+ex.ToString();
                }
            }
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SelectAudio(object sender, EventArgs e)
        {
            try
            {
                if (playlist.SelectedItem != null)
                {
                    filepath.Text = playlist.SelectedItem.ToString();
                    stopButton_Click(sender, e);
                    playAsync_Click(sender, e);
                }
            } catch (Exception ex)
            {
                toolStripLabel.Text = "Problem z wybraniem pliku - " + ex.ToString();
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!loop && !playlistLoop && !random)
                {
                    outputDevice?.Stop();
                }
                if (playlist.SelectedIndex < playlist.Items.Count - 1)
                {
                    playlist.SelectedIndex = playlist.SelectedIndex + 1;
                } 
                else if (playlist.SelectedIndex == playlist.Items.Count - 1)
                {
                    playlist.SelectedIndex = 0;
                }
                if (playlist.SelectedItem != null)
                {
                    filepath.Text = playlist.SelectedItem.ToString();
                    if (!loop || !random)
                    {
                        playAsync_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripLabel.Text = "Problem z następnym - "+ex.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!loop && !playlistLoop && !random)
                {
                    outputDevice?.Stop();
                }
                if (playlist.SelectedIndex > 0)
                {
                    playlist.SelectedIndex = playlist.SelectedIndex - 1;
                } 
                else if (playlist.SelectedIndex == 0)
                {
                    playlist.SelectedIndex = playlist.Items.Count - 1;
                }
                if (playlist.SelectedItem != null)
                {
                    filepath.Text = playlist.SelectedItem.ToString();
                    if (!loop || !random)
                    {
                        playAsync_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripLabel.Text = "Problem z cofnięciem - "+ex.ToString();
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (random)
            {
                random = false;
                buttonRandom.BackColor = Color.Transparent;
            }
            else
            {
                loop = false;
                playlistLoop = false;
                random = true;
                buttonRandom.BackColor = Color.Aqua;
                loopAsync.BackColor = Color.Transparent;
                loopPlaylist.BackColor = Color.Transparent;
            }
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.CurrentTime -= TimeSpan.FromSeconds(5);
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.CurrentTime += TimeSpan.FromSeconds(5);
            }
        }

        private void showInfo()
        {
            try
            {
                var tfile = TagLib.File.Create(filepath.Text);
                title = tfile.Tag.Title;
                duration = tfile.Properties.Duration;
                toolStripLabel.Text = "Tytuł: " + title + " / Długość: " + duration;
                var bin = (byte[])(tfile.Tag.Pictures[0].Data.Data);
                pictureBoxAlbum.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(174, 158, null, IntPtr.Zero);
            } catch (Exception)
            {
                toolStripLabel.Text = "Brak informacji o utworze.";
            }

        }

        private void playAsync_Click(object sender, EventArgs e)
        {
            try
            {
                if (aTimer != null)
                {
                    aTimer.Stop();
                    aTimer.Dispose();
                }
                pictureBoxAlbum.Image = null;
                pictureBoxWave.Image = null;
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                if (!(string.IsNullOrEmpty(textBoxURL.Text)))
                {
                    fromURL = new MediaFoundationReader(textBoxURL.Text); //http://media.ch9.ms/ch9/2876/fd36ef30-cfd2-4558-8412-3cf7a0852876/AzureWebJobs103.mp3
                    outputDevice.Init(fromURL);
                }
                else
                {
                    if (audioFile == null)
                    {
                        audioFile = new AudioFileReader(filepath.Text);
                        outputDevice.Init(audioFile);
                    }
                }
                hScrollBar1.Maximum = (int)audioFile.Length;
                hScrollBar1.Value = (int)audioFile.Position;
                Visualization();
                outputDevice.Play();
                SetTimer();
                showInfo();
                LengthPlaylist();
            } catch (Exception ex)
            {
                toolStripLabel.Text = "Problem z odtwarzaniem - "+ex.ToString();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }

        private void ResetAudio()
        {
            if (outputDevice != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
            if (fromURL != null)
            {
                fromURL.Dispose();
                fromURL = null;
            }
            if (aTimer != null)
            {
                aTimer.Stop();
                aTimer.Dispose();
            }
        }

        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            if (loop)
            {
                ResetAudio();
                playAsync_Click(sender, e);
            }
            else if (playlistLoop)
            {
                ResetAudio();
                nextButton_Click(sender, e);
            } 
            else if (random) 
            {
                ResetAudio();
                var random = new Random();
                int index = random.Next(0, playlist.Items.Count);
                playlist.SelectedIndex = index;
                filepath.Text = playlist.SelectedItem.ToString();
                playAsync_Click(sender, e);
            }
            else
            {
                ResetAudio();
            }
        }

        private void clearList_Click(object sender, EventArgs e)
        {
            directoriesList.Items.Clear();
            filesList.Items.Clear();
            InitializeBrowser();
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "Audio (*.MP3; *.WAV)|*.MP3; *.WAV";
            dlg.DefaultExt = ".mp3";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = dlg.FileName;
                    playlist.Items.Add(filePath);
                }
                catch (Exception ex)
                {
                    toolStripLabel.Text = "Problem z dodaniem audio do playlisty - " + ex.ToString();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = int.Parse(playlist.SelectedIndex.ToString());
                playlist.Items.RemoveAt(temp);
            } catch (Exception)
            {
                toolStripLabel.Text = "Wybierz utwór do usunięcia!";
            }

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int oldIndex = playlist.SelectedIndex;
            int newIndex = oldIndex - 1;
            if ((oldIndex == newIndex) || (0 > oldIndex) || (oldIndex >= playlist.Items.Count) || (0 > newIndex) || (newIndex >= playlist.Items.Count))
            {
                toolStripLabel.Text = "Problem ze zmianą kolejności!";
                return;
            }
            var oldItem = playlist.Items[oldIndex];
            var newItem = playlist.Items[newIndex];
            playlist.Items.RemoveAt(oldIndex);
            playlist.Items.RemoveAt(newIndex);
            playlist.Items.Insert(newIndex, oldItem);
            playlist.Items.Insert(oldIndex, newItem);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int oldIndex = playlist.SelectedIndex;
            int newIndex = oldIndex + 1;
            if ((oldIndex == newIndex) || (0 > oldIndex) || (oldIndex >= playlist.Items.Count) || (0 > newIndex) || (newIndex >= playlist.Items.Count))
            {
                toolStripLabel.Text = "Problem ze zmianą kolejności!";
                return;
            }
            var oldItem = playlist.Items[oldIndex];
            var newItem = playlist.Items[newIndex];
            playlist.Items.RemoveAt(newIndex);
            playlist.Items.RemoveAt(oldIndex);
            playlist.Items.Insert(oldIndex, newItem);
            playlist.Items.Insert(newIndex, oldItem);
        }

        private void AddToPlaylist(object sender, EventArgs e)
        {
            playlist.Items.Add(filesList.SelectedItem.ToString());
        }

        private void loopAsync_Click(object sender, EventArgs e)
        {
            if (loop)
            {
                loop = false;
                loopAsync.BackColor = Color.Transparent;
            } else
            {
                playlistLoop = false;
                random = false;
                loop = true;
                loopAsync.BackColor = Color.Aqua;
                loopPlaylist.BackColor = Color.Transparent;
                buttonRandom.BackColor = Color.Transparent;
            }
        }

        private void loopPlaylist_Click(object sender, EventArgs e)
        {
            if (playlistLoop)
            {
                playlistLoop = false;
                loopPlaylist.BackColor = Color.Transparent;
            }
            else
            {
                loop = false;
                random = false;
                playlistLoop = true;
                loopPlaylist.BackColor = Color.Aqua;
                loopAsync.BackColor = Color.Transparent;
                buttonRandom.BackColor = Color.Transparent;
            }
        }

        private void SetTimer()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000;
            aTimer.AutoReset = true;
            aTimer.Elapsed += Counting;
            aTimer.Start();
        }

        private void Counting(object sender, ElapsedEventArgs e) {
            
            if (audioFile != null)
            {
                toolStripLabelTimeLeft.Text = (audioFile.TotalTime - audioFile.CurrentTime).ToString();
                toolStripLabelTimePlay.Text = audioFile.CurrentTime.ToString();
            }
        }

        private void Slide(object sender, ScrollEventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Position = hScrollBar1.Value;
            }
        }

        private void LengthPlaylist()
        {
            try
            {
                total = new TimeSpan();
                foreach (var audio in playlist.Items)
                {
                    var tfile = TagLib.File.Create(audio.ToString());
                    total += tfile.Properties.Duration;
                }
                labelPlaylistLength.Text = "Długość playlisty: " + total.ToString();
            } finally
            {

            }
        }
    }
}
