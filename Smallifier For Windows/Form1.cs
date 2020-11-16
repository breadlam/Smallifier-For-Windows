using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;
using System.Windows.Forms;

namespace Smallifier_For_Windows
{
    public partial class Form1 : Form
    {
        private static string origFilename;
        private static string tempFilename;
        private static IMediaInfo mediaInfoOriginal;

        public Form1()
        {
            InitializeComponent();
            Dictionary<string, int> vidSizeDict = new Dictionary<string, int>();
            foreach (int enumValue in Enum.GetValues(typeof(VideoSize)))
            {
                vidSizeDict.Add(Enum.GetName(typeof(VideoSize), enumValue), enumValue);
            }
            vidSizeDict.Add("Original", 53);
            vidSizeDict.Add("Half", 54);
            vidSizeDict.Add("Quarter", 55);
            comboBoxResolutions.DisplayMember = "Key"; ;
            comboBoxResolutions.ValueMember = "Value";
            comboBoxResolutions.DataSource = new BindingSource(vidSizeDict, null);
            comboBoxResolutions.SelectedIndex = 54;
            checkFFmpeg();
        }

        private async void checkFFmpeg()
        {
            if (!File.Exists("ffmpeg.exe") || !File.Exists("ffprobe.exe"))
            {
                buttonOpenFile.Enabled = false;
                logToConsole("FFmpeg doesn't exist.");
                logToConsole("Downloading FFmpeg...");
                await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official);
                logToConsole("FFmpeg downloaded.");
                buttonOpenFile.Enabled = true;
            }
        }

        private void logToConsole(string textline)
        {
            textBoxStatusLog.AppendText(textline + "\r\n");
        }

        private async Task loadVideoFile(string videoFilename)
        {
            origFilename = videoFilename;
            labelFilename.Text = videoFilename;
            logToConsole("Playing back video file.");
            axWindowsMediaPlayer1.URL = videoFilename;
            buttonSmallify.Enabled = true;
            buttonSaveFile.Enabled = false;
            progressBar1.Value = 0;

            mediaInfoOriginal = await FFmpeg.GetMediaInfo(videoFilename);
            var videoStream = mediaInfoOriginal.VideoStreams.First();

            textBoxOrigFilesize.Text = Math.Round(mediaInfoOriginal.Size/1048576.0,2).ToString();
            textBoxOrigBitrate.Text = Math.Round(videoStream.Bitrate/1024.0).ToString();
            textBoxOrigHorizontal.Text = videoStream.Width.ToString();
            textBoxOrigVertical.Text = videoStream.Height.ToString();
            textBoxOrigRatio.Text = videoStream.Ratio;
            textBoxOrigDuration.Text = videoStream.Duration.TotalSeconds.ToString();
            //textBoxOrigDuration.Text = axWindowsMediaPlayer1.currentMedia.duration.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                logToConsole("Opened video file.");
                await loadVideoFile(openFileDialog1.FileName);
            }
        }

        private void form1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private async void form1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            await loadVideoFile(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0]);
        }

        private async Task<int> conversionTask(IProgress<int> progress)
        {
            string tmp = Path.GetTempFileName();
            tempFilename = Path.ChangeExtension(tmp, ".mp4");

            var videoStream = mediaInfoOriginal.VideoStreams.First();
            videoStream.SetCodec(VideoCodec.h264);
            videoStream.SetFramerate(30.0);

            long bitRate = (long)(((double.Parse(textBoxTargetFilesize.Text) * 8192000.0) / axWindowsMediaPlayer1.currentMedia.duration) * 0.99);
            //videoStream.SetBitrate(bitRate);

            var conversion = FFmpeg.Conversions.New();

            Decimal newWidth;
            Decimal newHeight;
            string newSize;
            switch (comboBoxResolutions.SelectedIndex)
            {
                case 53:
                    newSize = videoStream.Width.ToString() + "x" + videoStream.Height.ToString();
                    conversion.AddParameter("-s " + newSize);
                    logToConsole("Encode resolution: " + newSize);
                    textBoxTargetWidth.Text = textBoxOrigHorizontal.Text;
                    textBoxTargetHeight.Text = textBoxOrigVertical.Text;
                    break;
                case 54:
                    newWidth = decimal.Round((videoStream.Width / 2), 0, MidpointRounding.ToEven);
                    newHeight = decimal.Round((videoStream.Height / 2), 0, MidpointRounding.ToEven);
                    newSize = newWidth.ToString() + "x" + newHeight.ToString();
                    conversion.AddParameter("-s " + newSize);
                    logToConsole("Encode resolution: " + newSize);
                    textBoxTargetWidth.Text = newWidth.ToString();
                    textBoxTargetHeight.Text = newHeight.ToString();
                    break;
                case 55:
                    newWidth = decimal.Round((videoStream.Width / 4), 0, MidpointRounding.ToEven);
                    newHeight = decimal.Round((videoStream.Height / 4), 0, MidpointRounding.ToEven);
                    newSize = newWidth.ToString() + "x" + newHeight.ToString();
                    conversion.AddParameter("-s " + newSize);
                    logToConsole("Encode resolution: " + newSize);
                    textBoxTargetWidth.Text = newWidth.ToString();
                    textBoxTargetHeight.Text = newHeight.ToString();
                    break;
                default:
                    videoStream.SetSize((VideoSize)comboBoxResolutions.SelectedIndex);
                    logToConsole("Encode resolution: " + ((VideoSize)comboBoxResolutions.SelectedIndex).ToString());
                    break;
            }

            string bitrateKBsec = (bitRate / 1024).ToString();
            conversion.AddParameter("-b:v " + bitrateKBsec + "k");
            conversion.AddParameter("-bufsize 8028k");
            //conversion.AddParameter("-maxrate " + bitrateKBsec + "k");
            textBoxTargetBitrate.Text = bitrateKBsec;
            logToConsole("Encode bitrate: " + bitrateKBsec + " KB/s");

            conversion.AddStream(videoStream);
            conversion.SetOutput(tempFilename).SetOverwriteOutput(true);
            conversion.SetPreset(ConversionPreset.VerySlow);
            conversion.OnProgress += (s, args) =>
            {
                progress.Report(args.Percent);
            };
            logToConsole("Re-encoding video file...");
            await conversion.Start();
            return 100;
        }

        private async void buttonSmallify_Click(object sender, EventArgs e)
        {
            buttonSmallify.Enabled = false;
            buttonOpenFile.Enabled = false;
            buttonSaveFile.Enabled = false;
            textBoxNewBitrate.Clear();
            textBoxNewDuration.Clear();
            textBoxNewFilesize.Clear();
            textBoxNewHorizontal.Clear();
            textBoxNewVertical.Clear();
            textBoxNewRatio.Clear();

            int uploads = await conversionTask(new Progress<int>(percent => progressBar1.Value = percent));
            progressBar1.Value = 0;
            logToConsole("Encode complete.");
            labelFilename.Text = tempFilename;
            buttonSaveFile.Enabled = true;
            buttonOpenFile.Enabled = true;
            buttonSmallify.Enabled = true;

            IMediaInfo newMediaInfo = await FFmpeg.GetMediaInfo(tempFilename);
            var newVideoStream = newMediaInfo.VideoStreams.First();
            textBoxNewFilesize.Text = Math.Round(newMediaInfo.Size / 1048576.0, 2).ToString();
            textBoxNewDuration.Text = Math.Round(newVideoStream.Duration.TotalMilliseconds / 1000.0, 2).ToString();
            //textBoxOrigDuration.Text = axWindowsMediaPlayer1.currentMedia.duration.ToString();
            textBoxNewBitrate.Text = Math.Round(newVideoStream.Bitrate / 1024.0).ToString();
            textBoxNewHorizontal.Text = newVideoStream.Width.ToString();
            textBoxNewVertical.Text = newVideoStream.Height.ToString();
            textBoxNewRatio.Text = newVideoStream.Ratio;
            logToConsole("Size reduced by " + Math.Round(((1.0 - ((double)newMediaInfo.Size / (double)mediaInfoOriginal.Size)) * 100.0), 2).ToString() + "%");
            logToConsole("Starting playback.");
            axWindowsMediaPlayer1.URL = tempFilename;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string newFile = Path.ChangeExtension(origFilename, ".mp4");
            saveFileDialog1.FileName = "smallified-" + Path.GetFileName(newFile);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(tempFilename, saveFileDialog1.FileName, true);
            }
        }

        //private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        //{
        //    if (File.Exists(tempFilename))
        //    {
        //        string[] files = new string[] { tempFilename };
        //        DataObject clipboardFileData = new DataObject(DataFormats.FileDrop, files);
        //        //string[] fileList = new string[] { tempFilename };
        //        //StringCollection fileCollection = new StringCollection();
        //        //fileCollection.Add(tempFilename);
        //        //DataObject clipboardFileData = new DataObject(DataFormats.FileDrop, fileList);
        //        Clipboard.SetDataObject(clipboardFileData, true);
        //    }
        //}

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
            if (textBoxStatusLog.Visible)
            {
                textBoxStatusLog.SelectionStart = textBoxStatusLog.TextLength;
                textBoxStatusLog.ScrollToCaret();
            }
        }

        private void labelFilename_MouseDown(object sender, MouseEventArgs e)
        {
            string[] files = new string[] { labelFilename.Text };
            labelFilename.DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Copy);
        }
    }
}
