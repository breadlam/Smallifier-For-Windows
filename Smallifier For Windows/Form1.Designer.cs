
namespace Smallifier_For_Windows
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelFilename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTargetFilesize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNewHorizontal = new System.Windows.Forms.TextBox();
            this.textBoxNewVertical = new System.Windows.Forms.TextBox();
            this.textBoxNewBitrate = new System.Windows.Forms.TextBox();
            this.textBoxNewFilesize = new System.Windows.Forms.TextBox();
            this.textBoxOrigRatio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxOrigFilesize = new System.Windows.Forms.TextBox();
            this.textBoxOrigBitrate = new System.Windows.Forms.TextBox();
            this.textBoxOrigVertical = new System.Windows.Forms.TextBox();
            this.textBoxOrigHorizontal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxOrigDuration = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxNewDuration = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxNewRatio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSmallify = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxResolutions = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBoxStatusLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTargetBitrate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTargetHeight = new System.Windows.Forms.TextBox();
            this.textBoxTargetWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP4 Files (*.mp4)|*.mp4|MOV Files (*.mov)|*.mov|MKV Files (*.mkv)|*.mkv|AVI Files" +
    " (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select a video file";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 470);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(70, 29);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelFilename
            // 
            this.labelFilename.AllowDrop = true;
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilename.Location = new System.Drawing.Point(13, 443);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(0, 15);
            this.labelFilename.TabIndex = 2;
            this.labelFilename.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelFilename_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filesize (MB)";
            // 
            // textBoxTargetFilesize
            // 
            this.textBoxTargetFilesize.Location = new System.Drawing.Point(262, 528);
            this.textBoxTargetFilesize.Name = "textBoxTargetFilesize";
            this.textBoxTargetFilesize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTargetFilesize.Size = new System.Drawing.Size(48, 20);
            this.textBoxTargetFilesize.TabIndex = 5;
            this.textBoxTargetFilesize.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filesize (MB)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bitrate (KB/s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 606);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Width";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, 626);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Height";
            // 
            // textBoxNewHorizontal
            // 
            this.textBoxNewHorizontal.Enabled = false;
            this.textBoxNewHorizontal.Location = new System.Drawing.Point(418, 606);
            this.textBoxNewHorizontal.Name = "textBoxNewHorizontal";
            this.textBoxNewHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewHorizontal.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewHorizontal.TabIndex = 15;
            // 
            // textBoxNewVertical
            // 
            this.textBoxNewVertical.Enabled = false;
            this.textBoxNewVertical.Location = new System.Drawing.Point(418, 626);
            this.textBoxNewVertical.Name = "textBoxNewVertical";
            this.textBoxNewVertical.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewVertical.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewVertical.TabIndex = 16;
            // 
            // textBoxNewBitrate
            // 
            this.textBoxNewBitrate.Enabled = false;
            this.textBoxNewBitrate.Location = new System.Drawing.Point(418, 566);
            this.textBoxNewBitrate.Name = "textBoxNewBitrate";
            this.textBoxNewBitrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewBitrate.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewBitrate.TabIndex = 17;
            // 
            // textBoxNewFilesize
            // 
            this.textBoxNewFilesize.Enabled = false;
            this.textBoxNewFilesize.Location = new System.Drawing.Point(418, 526);
            this.textBoxNewFilesize.Name = "textBoxNewFilesize";
            this.textBoxNewFilesize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewFilesize.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewFilesize.TabIndex = 18;
            // 
            // textBoxOrigRatio
            // 
            this.textBoxOrigRatio.Enabled = false;
            this.textBoxOrigRatio.Location = new System.Drawing.Point(99, 588);
            this.textBoxOrigRatio.Name = "textBoxOrigRatio";
            this.textBoxOrigRatio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigRatio.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigRatio.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 586);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ratio";
            // 
            // textBoxOrigFilesize
            // 
            this.textBoxOrigFilesize.Enabled = false;
            this.textBoxOrigFilesize.Location = new System.Drawing.Point(99, 528);
            this.textBoxOrigFilesize.Name = "textBoxOrigFilesize";
            this.textBoxOrigFilesize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigFilesize.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigFilesize.TabIndex = 30;
            // 
            // textBoxOrigBitrate
            // 
            this.textBoxOrigBitrate.Enabled = false;
            this.textBoxOrigBitrate.Location = new System.Drawing.Point(99, 568);
            this.textBoxOrigBitrate.Name = "textBoxOrigBitrate";
            this.textBoxOrigBitrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigBitrate.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigBitrate.TabIndex = 29;
            // 
            // textBoxOrigVertical
            // 
            this.textBoxOrigVertical.Enabled = false;
            this.textBoxOrigVertical.Location = new System.Drawing.Point(99, 628);
            this.textBoxOrigVertical.Name = "textBoxOrigVertical";
            this.textBoxOrigVertical.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigVertical.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigVertical.TabIndex = 28;
            // 
            // textBoxOrigHorizontal
            // 
            this.textBoxOrigHorizontal.Enabled = false;
            this.textBoxOrigHorizontal.Location = new System.Drawing.Point(99, 608);
            this.textBoxOrigHorizontal.Name = "textBoxOrigHorizontal";
            this.textBoxOrigHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigHorizontal.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigHorizontal.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 626);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Height";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Width";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 566);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "Bitrate (KB/s)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 526);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Filesize (MB)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 502);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Original";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(160, 502);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 20);
            this.label18.TabIndex = 34;
            this.label18.Text = "Target";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(327, 502);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "New";
            // 
            // textBoxOrigDuration
            // 
            this.textBoxOrigDuration.Enabled = false;
            this.textBoxOrigDuration.Location = new System.Drawing.Point(99, 548);
            this.textBoxOrigDuration.Name = "textBoxOrigDuration";
            this.textBoxOrigDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigDuration.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigDuration.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 546);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "Duration (s)";
            // 
            // textBoxNewDuration
            // 
            this.textBoxNewDuration.Enabled = false;
            this.textBoxNewDuration.Location = new System.Drawing.Point(418, 546);
            this.textBoxNewDuration.Name = "textBoxNewDuration";
            this.textBoxNewDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewDuration.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewDuration.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(327, 546);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 16);
            this.label21.TabIndex = 40;
            this.label21.Text = "Duration (s)";
            // 
            // textBoxNewRatio
            // 
            this.textBoxNewRatio.Enabled = false;
            this.textBoxNewRatio.Location = new System.Drawing.Point(418, 586);
            this.textBoxNewRatio.Name = "textBoxNewRatio";
            this.textBoxNewRatio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewRatio.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewRatio.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(327, 586);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ratio";
            // 
            // buttonSmallify
            // 
            this.buttonSmallify.Enabled = false;
            this.buttonSmallify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSmallify.Location = new System.Drawing.Point(163, 470);
            this.buttonSmallify.Name = "buttonSmallify";
            this.buttonSmallify.Size = new System.Drawing.Size(83, 29);
            this.buttonSmallify.TabIndex = 44;
            this.buttonSmallify.Text = "Smallify";
            this.buttonSmallify.UseVisualStyleBackColor = true;
            this.buttonSmallify.Click += new System.EventHandler(this.ButtonSmallify_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Location = new System.Drawing.Point(331, 469);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(72, 30);
            this.buttonSaveFile.TabIndex = 45;
            this.buttonSaveFile.Text = "Save...";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxResolutions
            // 
            this.comboBoxResolutions.FormattingEnabled = true;
            this.comboBoxResolutions.Location = new System.Drawing.Point(234, 548);
            this.comboBoxResolutions.Name = "comboBoxResolutions";
            this.comboBoxResolutions.Size = new System.Drawing.Size(76, 21);
            this.comboBoxResolutions.TabIndex = 47;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 649);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(646, 10);
            this.progressBar1.TabIndex = 49;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(640, 425);
            this.axWindowsMediaPlayer1.TabIndex = 36;
            // 
            // textBoxStatusLog
            // 
            this.textBoxStatusLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStatusLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxStatusLog.ForeColor = System.Drawing.Color.Lime;
            this.textBoxStatusLog.Location = new System.Drawing.Point(472, 470);
            this.textBoxStatusLog.Multiline = true;
            this.textBoxStatusLog.Name = "textBoxStatusLog";
            this.textBoxStatusLog.ReadOnly = true;
            this.textBoxStatusLog.Size = new System.Drawing.Size(186, 176);
            this.textBoxStatusLog.TabIndex = 51;
            this.textBoxStatusLog.VisibleChanged += new System.EventHandler(this.TextBox1_VisibleChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Resolution";
            // 
            // textBoxTargetBitrate
            // 
            this.textBoxTargetBitrate.Enabled = false;
            this.textBoxTargetBitrate.Location = new System.Drawing.Point(263, 585);
            this.textBoxTargetBitrate.Name = "textBoxTargetBitrate";
            this.textBoxTargetBitrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTargetBitrate.Size = new System.Drawing.Size(48, 20);
            this.textBoxTargetBitrate.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Bitrate (KB/s)";
            // 
            // textBoxTargetHeight
            // 
            this.textBoxTargetHeight.Enabled = false;
            this.textBoxTargetHeight.Location = new System.Drawing.Point(263, 625);
            this.textBoxTargetHeight.Name = "textBoxTargetHeight";
            this.textBoxTargetHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTargetHeight.Size = new System.Drawing.Size(48, 20);
            this.textBoxTargetHeight.TabIndex = 57;
            // 
            // textBoxTargetWidth
            // 
            this.textBoxTargetWidth.Enabled = false;
            this.textBoxTargetWidth.Location = new System.Drawing.Point(263, 605);
            this.textBoxTargetWidth.Name = "textBoxTargetWidth";
            this.textBoxTargetWidth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTargetWidth.Size = new System.Drawing.Size(48, 20);
            this.textBoxTargetWidth.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Width";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "------------>";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(262, 478);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "------------>";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 663);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxTargetHeight);
            this.Controls.Add(this.textBoxTargetWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTargetBitrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStatusLog);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxResolutions);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonSmallify);
            this.Controls.Add(this.textBoxOrigDuration);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxNewDuration);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxOrigRatio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxOrigFilesize);
            this.Controls.Add(this.textBoxOrigBitrate);
            this.Controls.Add(this.textBoxOrigVertical);
            this.Controls.Add(this.textBoxOrigHorizontal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxNewRatio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxNewFilesize);
            this.Controls.Add(this.textBoxNewBitrate);
            this.Controls.Add(this.textBoxNewVertical);
            this.Controls.Add(this.textBoxNewHorizontal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTargetFilesize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.buttonOpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Discord Video Smallifier";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTargetFilesize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNewHorizontal;
        private System.Windows.Forms.TextBox textBoxNewVertical;
        private System.Windows.Forms.TextBox textBoxNewBitrate;
        private System.Windows.Forms.TextBox textBoxNewFilesize;
        private System.Windows.Forms.TextBox textBoxOrigRatio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxOrigFilesize;
        private System.Windows.Forms.TextBox textBoxOrigBitrate;
        private System.Windows.Forms.TextBox textBoxOrigVertical;
        private System.Windows.Forms.TextBox textBoxOrigHorizontal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox textBoxOrigDuration;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxNewDuration;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxNewRatio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSmallify;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxResolutions;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxStatusLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTargetBitrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTargetHeight;
        private System.Windows.Forms.TextBox textBoxTargetWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
    }
}

