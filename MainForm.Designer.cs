namespace SerialSpectrogramTool
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pnLeftSide = new System.Windows.Forms.Panel();
            this.gbDeviceParameters = new System.Windows.Forms.GroupBox();
            this.lblModifyDeviceParams = new System.Windows.Forms.Button();
            this.cmbSampleRate = new System.Windows.Forms.ComboBox();
            this.lblSampleRate = new System.Windows.Forms.Label();
            this.cmbFftSize = new System.Windows.Forms.ComboBox();
            this.lblFftSize = new System.Windows.Forms.Label();
            this.gbDevice = new System.Windows.Forms.GroupBox();
            this.btnConectionPort = new System.Windows.Forms.Button();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.lnkDevName = new System.Windows.Forms.LinkLabel();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.splitContainerRightSide = new System.Windows.Forms.SplitContainer();
            this.pnMainTop = new System.Windows.Forms.Panel();
            this.scpTimeSeries = new ScottPlot.FormsPlot();
            this.pnMainBottom = new System.Windows.Forms.Panel();
            this.pbSpectrogram = new System.Windows.Forms.PictureBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblStatusApp = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tmrSpectrogramGraphRender = new System.Windows.Forms.Timer(this.components);
            this.tmrSerialPort = new System.Windows.Forms.Timer(this.components);
            this.tmrTimeSeriesGraphRender = new System.Windows.Forms.Timer(this.components);
            this.pbScaleVert = new System.Windows.Forms.PictureBox();
            this.chkNotch50Hz = new System.Windows.Forms.CheckBox();
            this.pnLeftSide.SuspendLayout();
            this.gbDeviceParameters.SuspendLayout();
            this.gbDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightSide)).BeginInit();
            this.splitContainerRightSide.Panel1.SuspendLayout();
            this.splitContainerRightSide.Panel2.SuspendLayout();
            this.splitContainerRightSide.SuspendLayout();
            this.pnMainTop.SuspendLayout();
            this.pnMainBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpectrogram)).BeginInit();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScaleVert)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeftSide
            // 
            this.pnLeftSide.Controls.Add(this.gbDeviceParameters);
            this.pnLeftSide.Controls.Add(this.gbDevice);
            this.pnLeftSide.Controls.Add(this.lnkDevName);
            this.pnLeftSide.Controls.Add(this.lblBy);
            this.pnLeftSide.Controls.Add(this.lblAppName);
            this.pnLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnLeftSide.Name = "pnLeftSide";
            this.pnLeftSide.Size = new System.Drawing.Size(182, 587);
            this.pnLeftSide.TabIndex = 0;
            // 
            // gbDeviceParameters
            // 
            this.gbDeviceParameters.Controls.Add(this.chkNotch50Hz);
            this.gbDeviceParameters.Controls.Add(this.lblModifyDeviceParams);
            this.gbDeviceParameters.Controls.Add(this.cmbSampleRate);
            this.gbDeviceParameters.Controls.Add(this.lblSampleRate);
            this.gbDeviceParameters.Controls.Add(this.cmbFftSize);
            this.gbDeviceParameters.Controls.Add(this.lblFftSize);
            this.gbDeviceParameters.Location = new System.Drawing.Point(10, 141);
            this.gbDeviceParameters.Name = "gbDeviceParameters";
            this.gbDeviceParameters.Size = new System.Drawing.Size(162, 127);
            this.gbDeviceParameters.TabIndex = 4;
            this.gbDeviceParameters.TabStop = false;
            this.gbDeviceParameters.Text = "Device Parameters";
            // 
            // lblModifyDeviceParams
            // 
            this.lblModifyDeviceParams.Location = new System.Drawing.Point(76, 71);
            this.lblModifyDeviceParams.Name = "lblModifyDeviceParams";
            this.lblModifyDeviceParams.Size = new System.Drawing.Size(75, 23);
            this.lblModifyDeviceParams.TabIndex = 5;
            this.lblModifyDeviceParams.Text = "Modify";
            this.lblModifyDeviceParams.UseVisualStyleBackColor = true;
            // 
            // cmbSampleRate
            // 
            this.cmbSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSampleRate.FormattingEnabled = true;
            this.cmbSampleRate.Location = new System.Drawing.Point(76, 44);
            this.cmbSampleRate.Name = "cmbSampleRate";
            this.cmbSampleRate.Size = new System.Drawing.Size(75, 21);
            this.cmbSampleRate.TabIndex = 4;
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(6, 47);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(71, 13);
            this.lblSampleRate.TabIndex = 3;
            this.lblSampleRate.Text = "Sample Rate:";
            // 
            // cmbFftSize
            // 
            this.cmbFftSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFftSize.FormattingEnabled = true;
            this.cmbFftSize.Location = new System.Drawing.Point(76, 17);
            this.cmbFftSize.Name = "cmbFftSize";
            this.cmbFftSize.Size = new System.Drawing.Size(75, 21);
            this.cmbFftSize.TabIndex = 2;
            // 
            // lblFftSize
            // 
            this.lblFftSize.AutoSize = true;
            this.lblFftSize.Location = new System.Drawing.Point(6, 20);
            this.lblFftSize.Name = "lblFftSize";
            this.lblFftSize.Size = new System.Drawing.Size(52, 13);
            this.lblFftSize.TabIndex = 1;
            this.lblFftSize.Text = "FFT Size:";
            // 
            // gbDevice
            // 
            this.gbDevice.Controls.Add(this.btnConectionPort);
            this.gbDevice.Controls.Add(this.cmbComPort);
            this.gbDevice.Controls.Add(this.lblSerialPort);
            this.gbDevice.Location = new System.Drawing.Point(10, 57);
            this.gbDevice.Name = "gbDevice";
            this.gbDevice.Size = new System.Drawing.Size(162, 78);
            this.gbDevice.TabIndex = 3;
            this.gbDevice.TabStop = false;
            this.gbDevice.Text = "Device";
            // 
            // btnConectionPort
            // 
            this.btnConectionPort.Location = new System.Drawing.Point(76, 44);
            this.btnConectionPort.Name = "btnConectionPort";
            this.btnConectionPort.Size = new System.Drawing.Size(75, 23);
            this.btnConectionPort.TabIndex = 2;
            this.btnConectionPort.Text = "Open";
            this.btnConectionPort.UseVisualStyleBackColor = true;
            this.btnConectionPort.Click += new System.EventHandler(this.btnConectionPort_Click);
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(76, 17);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(75, 21);
            this.cmbComPort.TabIndex = 1;
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(6, 20);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(58, 13);
            this.lblSerialPort.TabIndex = 0;
            this.lblSerialPort.Text = "Serial Port:";
            // 
            // lnkDevName
            // 
            this.lnkDevName.AutoSize = true;
            this.lnkDevName.Location = new System.Drawing.Point(28, 31);
            this.lnkDevName.Name = "lnkDevName";
            this.lnkDevName.Size = new System.Drawing.Size(76, 13);
            this.lnkDevName.TabIndex = 2;
            this.lnkDevName.TabStop = true;
            this.lnkDevName.Text = "Dhanabhon S.";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(12, 31);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(18, 13);
            this.lblBy.TabIndex = 1;
            this.lblBy.Text = "by";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAppName.Location = new System.Drawing.Point(12, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(143, 13);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Serial Spectrogram Tool";
            // 
            // splitContainerRightSide
            // 
            this.splitContainerRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRightSide.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRightSide.Name = "splitContainerRightSide";
            this.splitContainerRightSide.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRightSide.Panel1
            // 
            this.splitContainerRightSide.Panel1.Controls.Add(this.pnMainTop);
            // 
            // splitContainerRightSide.Panel2
            // 
            this.splitContainerRightSide.Panel2.Controls.Add(this.pnMainBottom);
            this.splitContainerRightSide.Size = new System.Drawing.Size(662, 587);
            this.splitContainerRightSide.SplitterDistance = 287;
            this.splitContainerRightSide.TabIndex = 0;
            // 
            // pnMainTop
            // 
            this.pnMainTop.Controls.Add(this.scpTimeSeries);
            this.pnMainTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainTop.Location = new System.Drawing.Point(0, 0);
            this.pnMainTop.Name = "pnMainTop";
            this.pnMainTop.Size = new System.Drawing.Size(662, 287);
            this.pnMainTop.TabIndex = 0;
            // 
            // scpTimeSeries
            // 
            this.scpTimeSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scpTimeSeries.Location = new System.Drawing.Point(0, 0);
            this.scpTimeSeries.Name = "scpTimeSeries";
            this.scpTimeSeries.Size = new System.Drawing.Size(662, 287);
            this.scpTimeSeries.TabIndex = 1;
            // 
            // pnMainBottom
            // 
            this.pnMainBottom.Controls.Add(this.pbScaleVert);
            this.pnMainBottom.Controls.Add(this.pbSpectrogram);
            this.pnMainBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainBottom.Location = new System.Drawing.Point(0, 0);
            this.pnMainBottom.Name = "pnMainBottom";
            this.pnMainBottom.Size = new System.Drawing.Size(662, 296);
            this.pnMainBottom.TabIndex = 0;
            // 
            // pbSpectrogram
            // 
            this.pbSpectrogram.BackColor = System.Drawing.Color.White;
            this.pbSpectrogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSpectrogram.Location = new System.Drawing.Point(0, 0);
            this.pbSpectrogram.Name = "pbSpectrogram";
            this.pbSpectrogram.Size = new System.Drawing.Size(662, 296);
            this.pbSpectrogram.TabIndex = 0;
            this.pbSpectrogram.TabStop = false;
            // 
            // statusStripMain
            // 
            this.statusStripMain.AllowMerge = false;
            this.statusStripMain.AutoSize = false;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblStatusApp});
            this.statusStripMain.Location = new System.Drawing.Point(0, 587);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(848, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLblStatusApp
            // 
            this.toolStripStatusLblStatusApp.AutoSize = false;
            this.toolStripStatusLblStatusApp.Name = "toolStripStatusLblStatusApp";
            this.toolStripStatusLblStatusApp.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLblStatusApp.Text = "toolStripStatusLabel1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnLeftSide);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRightSide);
            this.splitContainerMain.Size = new System.Drawing.Size(848, 587);
            this.splitContainerMain.SplitterDistance = 182;
            this.splitContainerMain.TabIndex = 2;
            // 
            // tmrSpectrogramGraphRender
            // 
            this.tmrSpectrogramGraphRender.Interval = 10;
            this.tmrSpectrogramGraphRender.Tick += new System.EventHandler(this.tmrSpectrogramGraphRender_Tick);
            // 
            // tmrSerialPort
            // 
            this.tmrSerialPort.Enabled = true;
            this.tmrSerialPort.Interval = 50;
            this.tmrSerialPort.Tick += new System.EventHandler(this.tmrSerialPort_Tick);
            // 
            // tmrTimeSeriesGraphRender
            // 
            this.tmrTimeSeriesGraphRender.Interval = 10;
            this.tmrTimeSeriesGraphRender.Tick += new System.EventHandler(this.tmrTimeSeriesGraphRender_Tick);
            // 
            // pbScaleVert
            // 
            this.pbScaleVert.BackColor = System.Drawing.Color.White;
            this.pbScaleVert.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbScaleVert.Location = new System.Drawing.Point(586, 0);
            this.pbScaleVert.Name = "pbScaleVert";
            this.pbScaleVert.Size = new System.Drawing.Size(76, 296);
            this.pbScaleVert.TabIndex = 1;
            this.pbScaleVert.TabStop = false;
            // 
            // chkNotch50Hz
            // 
            this.chkNotch50Hz.AutoSize = true;
            this.chkNotch50Hz.Location = new System.Drawing.Point(9, 100);
            this.chkNotch50Hz.Name = "chkNotch50Hz";
            this.chkNotch50Hz.Size = new System.Drawing.Size(86, 17);
            this.chkNotch50Hz.TabIndex = 6;
            this.chkNotch50Hz.Text = "Notch 50 Hz";
            this.chkNotch50Hz.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 609);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Spectrogram Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnLeftSide.ResumeLayout(false);
            this.pnLeftSide.PerformLayout();
            this.gbDeviceParameters.ResumeLayout(false);
            this.gbDeviceParameters.PerformLayout();
            this.gbDevice.ResumeLayout(false);
            this.gbDevice.PerformLayout();
            this.splitContainerRightSide.Panel1.ResumeLayout(false);
            this.splitContainerRightSide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightSide)).EndInit();
            this.splitContainerRightSide.ResumeLayout(false);
            this.pnMainTop.ResumeLayout(false);
            this.pnMainBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpectrogram)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbScaleVert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLeftSide;
        private System.Windows.Forms.SplitContainer splitContainerRightSide;
        private System.Windows.Forms.Panel pnMainTop;
        private System.Windows.Forms.Panel pnMainBottom;
        private System.Windows.Forms.GroupBox gbDevice;
        private System.Windows.Forms.Button btnConectionPort;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.LinkLabel lnkDevName;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pbSpectrogram;
        private System.Windows.Forms.GroupBox gbDeviceParameters;
        private System.Windows.Forms.Label lblFftSize;
        private System.Windows.Forms.ComboBox cmbSampleRate;
        private System.Windows.Forms.Label lblSampleRate;
        private System.Windows.Forms.ComboBox cmbFftSize;
        private System.Windows.Forms.Button lblModifyDeviceParams;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblStatusApp;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Timer tmrSpectrogramGraphRender;
        private ScottPlot.FormsPlot scpTimeSeries;
        private System.Windows.Forms.Timer tmrSerialPort;
        private System.Windows.Forms.Timer tmrTimeSeriesGraphRender;
        private System.Windows.Forms.PictureBox pbScaleVert;
        private System.Windows.Forms.CheckBox chkNotch50Hz;
    }
}

