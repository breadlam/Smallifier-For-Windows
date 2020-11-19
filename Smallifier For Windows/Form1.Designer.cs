
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTargetFilesize = new System.Windows.Forms.TextBox();
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
            this.textBoxNewRatio = new System.Windows.Forms.TextBox();
            this.buttonSmallify = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxResolutions = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBoxStatusLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxGPU = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFilename = new System.Windows.Forms.Label();
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
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 465);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(71, 29);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filesize (MB)";
            // 
            // textBoxTargetFilesize
            // 
            this.textBoxTargetFilesize.Location = new System.Drawing.Point(88, 550);
            this.textBoxTargetFilesize.Name = "textBoxTargetFilesize";
            this.textBoxTargetFilesize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTargetFilesize.Size = new System.Drawing.Size(23, 20);
            this.textBoxTargetFilesize.TabIndex = 5;
            this.textBoxTargetFilesize.Text = "8";
            // 
            // textBoxNewHorizontal
            // 
            this.textBoxNewHorizontal.Enabled = false;
            this.textBoxNewHorizontal.Location = new System.Drawing.Point(305, 606);
            this.textBoxNewHorizontal.Name = "textBoxNewHorizontal";
            this.textBoxNewHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewHorizontal.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewHorizontal.TabIndex = 15;
            // 
            // textBoxNewVertical
            // 
            this.textBoxNewVertical.Enabled = false;
            this.textBoxNewVertical.Location = new System.Drawing.Point(305, 626);
            this.textBoxNewVertical.Name = "textBoxNewVertical";
            this.textBoxNewVertical.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewVertical.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewVertical.TabIndex = 16;
            // 
            // textBoxNewBitrate
            // 
            this.textBoxNewBitrate.Enabled = false;
            this.textBoxNewBitrate.Location = new System.Drawing.Point(305, 566);
            this.textBoxNewBitrate.Name = "textBoxNewBitrate";
            this.textBoxNewBitrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewBitrate.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewBitrate.TabIndex = 17;
            // 
            // textBoxNewFilesize
            // 
            this.textBoxNewFilesize.Enabled = false;
            this.textBoxNewFilesize.Location = new System.Drawing.Point(305, 526);
            this.textBoxNewFilesize.Name = "textBoxNewFilesize";
            this.textBoxNewFilesize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewFilesize.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewFilesize.TabIndex = 18;
            // 
            // textBoxOrigRatio
            // 
            this.textBoxOrigRatio.Enabled = false;
            this.textBoxOrigRatio.Location = new System.Drawing.Point(251, 586);
            this.textBoxOrigRatio.Name = "textBoxOrigRatio";
            this.textBoxOrigRatio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigRatio.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigRatio.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(166, 586);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ratio";
            // 
            // textBoxOrigFilesize
            // 
            this.textBoxOrigFilesize.Enabled = false;
            this.textBoxOrigFilesize.Location = new System.Drawing.Point(251, 526);
            this.textBoxOrigFilesize.Name = "textBoxOrigFilesize";
            this.textBoxOrigFilesize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigFilesize.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigFilesize.TabIndex = 30;
            // 
            // textBoxOrigBitrate
            // 
            this.textBoxOrigBitrate.Enabled = false;
            this.textBoxOrigBitrate.Location = new System.Drawing.Point(251, 566);
            this.textBoxOrigBitrate.Name = "textBoxOrigBitrate";
            this.textBoxOrigBitrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigBitrate.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigBitrate.TabIndex = 29;
            // 
            // textBoxOrigVertical
            // 
            this.textBoxOrigVertical.Enabled = false;
            this.textBoxOrigVertical.Location = new System.Drawing.Point(251, 626);
            this.textBoxOrigVertical.Name = "textBoxOrigVertical";
            this.textBoxOrigVertical.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigVertical.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigVertical.TabIndex = 28;
            // 
            // textBoxOrigHorizontal
            // 
            this.textBoxOrigHorizontal.Enabled = false;
            this.textBoxOrigHorizontal.Location = new System.Drawing.Point(251, 606);
            this.textBoxOrigHorizontal.Name = "textBoxOrigHorizontal";
            this.textBoxOrigHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigHorizontal.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigHorizontal.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(166, 626);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Height";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(166, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Width";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(166, 566);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Bitrate (KB/s)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(166, 526);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "Filesize (MB)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(241, 503);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "Original";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 503);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 16);
            this.label18.TabIndex = 34;
            this.label18.Text = "Options";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(302, 503);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 15);
            this.label19.TabIndex = 35;
            this.label19.Text = "New";
            // 
            // textBoxOrigDuration
            // 
            this.textBoxOrigDuration.Enabled = false;
            this.textBoxOrigDuration.Location = new System.Drawing.Point(251, 546);
            this.textBoxOrigDuration.Name = "textBoxOrigDuration";
            this.textBoxOrigDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOrigDuration.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigDuration.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(166, 546);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 15);
            this.label20.TabIndex = 42;
            this.label20.Text = "Duration (s)";
            // 
            // textBoxNewDuration
            // 
            this.textBoxNewDuration.Enabled = false;
            this.textBoxNewDuration.Location = new System.Drawing.Point(305, 546);
            this.textBoxNewDuration.Name = "textBoxNewDuration";
            this.textBoxNewDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewDuration.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewDuration.TabIndex = 41;
            // 
            // textBoxNewRatio
            // 
            this.textBoxNewRatio.Enabled = false;
            this.textBoxNewRatio.Location = new System.Drawing.Point(305, 586);
            this.textBoxNewRatio.Name = "textBoxNewRatio";
            this.textBoxNewRatio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNewRatio.Size = new System.Drawing.Size(48, 20);
            this.textBoxNewRatio.TabIndex = 20;
            // 
            // buttonSmallify
            // 
            this.buttonSmallify.Enabled = false;
            this.buttonSmallify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSmallify.Location = new System.Drawing.Point(129, 464);
            this.buttonSmallify.Name = "buttonSmallify";
            this.buttonSmallify.Size = new System.Drawing.Size(76, 29);
            this.buttonSmallify.TabIndex = 44;
            this.buttonSmallify.Text = "Smallify";
            this.buttonSmallify.UseVisualStyleBackColor = true;
            this.buttonSmallify.Click += new System.EventHandler(this.ButtonSmallify_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Location = new System.Drawing.Point(251, 465);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(64, 29);
            this.buttonSaveFile.TabIndex = 45;
            this.buttonSaveFile.Text = "Save...";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxResolutions
            // 
            this.comboBoxResolutions.FormattingEnabled = true;
            this.comboBoxResolutions.Location = new System.Drawing.Point(88, 574);
            this.comboBoxResolutions.Name = "comboBoxResolutions";
            this.comboBoxResolutions.Size = new System.Drawing.Size(64, 21);
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
            this.textBoxStatusLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatusLog.ForeColor = System.Drawing.Color.Lime;
            this.textBoxStatusLog.Location = new System.Drawing.Point(359, 468);
            this.textBoxStatusLog.Multiline = true;
            this.textBoxStatusLog.Name = "textBoxStatusLog";
            this.textBoxStatusLog.ReadOnly = true;
            this.textBoxStatusLog.Size = new System.Drawing.Size(299, 177);
            this.textBoxStatusLog.TabIndex = 51;
            this.textBoxStatusLog.VisibleChanged += new System.EventHandler(this.TextBox1_VisibleChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Resolution";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "------->";
            // 
            // checkBoxGPU
            // 
            this.checkBoxGPU.AutoSize = true;
            this.checkBoxGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGPU.Location = new System.Drawing.Point(25, 526);
            this.checkBoxGPU.Name = "checkBoxGPU";
            this.checkBoxGPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxGPU.Size = new System.Drawing.Size(77, 19);
            this.checkBoxGPU.TabIndex = 61;
            this.checkBoxGPU.Text = "Use GPU";
            this.checkBoxGPU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBoxGPU.UseVisualStyleBackColor = true;
            this.checkBoxGPU.CheckedChanged += new System.EventHandler(this.checkBoxGPU_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "------->";
            // 
            // labelFilename
            // 
            this.labelFilename.AllowDrop = true;
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilename.Location = new System.Drawing.Point(9, 440);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(133, 16);
            this.labelFilename.TabIndex = 65;
            this.labelFilename.Text = "Filename Goes Here";
            this.labelFilename.Visible = false;
            this.labelFilename.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelFilename_MouseDown);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 662);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxGPU);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxStatusLog);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxResolutions);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonSmallify);
            this.Controls.Add(this.textBoxOrigDuration);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxNewDuration);
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
            this.Controls.Add(this.textBoxNewFilesize);
            this.Controls.Add(this.textBoxNewBitrate);
            this.Controls.Add(this.textBoxNewVertical);
            this.Controls.Add(this.textBoxNewHorizontal);
            this.Controls.Add(this.textBoxTargetFilesize);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTargetFilesize;
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
        private System.Windows.Forms.TextBox textBoxNewRatio;
        private System.Windows.Forms.Button buttonSmallify;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxResolutions;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxStatusLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxGPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFilename;
    }
}

