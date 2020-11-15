using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Import
using System.IO.Ports;
using ScottPlot;
using Spectrogram;
#endregion Import

namespace SerialSpectrogramTool
{
    public partial class MainForm : Form
    {
        private SerialDataLogger logger = null;

        private SerialSignalData ssd = null;

        private bool busyRedering = false;

        private double[] sineWave = null;

        private Spectrogram.Spectrogram spectrogram = null;

        IIRFilter Notch50;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void InitializeApp()
        {
            //double[] init = { 0 };

            //this.scatterPlot = this.scpTimeSeries.plt.PlotScatter(init, init, markerSize: 0);
            //this.scpTimeSeries.plt.Ticks(dateTimeX: true);
            //this.scpTimeSeries.plt.YLabel("ADC Reading (V)");

            this.ScanSerialPorts();

            this.InitializeTimeSeriesStyleGraph();
            this.InitializeSpectrogramGraph();
        }

        private void InitializeTimeSeriesStyleGraph()
        {
            this.scpTimeSeries.plt.YLabel("Amplitude (V)");
            this.scpTimeSeries.plt.XLabel("Time (seconds)");
            this.scpTimeSeries.Render();
        }

        private void InitializeSpectrogramGraph()
        {
            this.cmbFftSize.Items.Clear();
            for (int i = 9; i < 16; i++)
                this.cmbFftSize.Items.Add($"{1 << i:N0}");
            this.cmbFftSize.SelectedIndex = 0;

            this.cmbSampleRate.Items.Clear();
            this.cmbSampleRate.Items.Add("500");
            this.cmbSampleRate.Items.Add("1000");
            this.cmbSampleRate.Items.Add("2000");
            this.cmbSampleRate.SelectedIndex = 0;

            this.pbSpectrogram.Image?.Dispose();
            this.pbSpectrogram.Image = null;
        }

        private void ScanSerialPorts()
        {
            this.cmbComPort.Items.Clear();
            this.cmbComPort.Items.AddRange(SerialPort.GetPortNames());

            if (this.cmbComPort.Items.Count > 0)
            {
                this.cmbComPort.SelectedIndex = 0;
            }
        }
        #endregion Methods

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.InitializeApp();
        }

        private void btnConectionPort_Click(object sender, EventArgs e)
        {
            //if (this.logger is null)
            //{
            //    string comPort = this.cmbComPort.SelectedItem.ToString();
            //    this.logger = new SerialDataLogger(comPort, channelCount: 1);
            //    this.btnConectionPort.Text = "Close";
            //} 
            //else
            //{
            //    this.logger.Dispose();
            //    this.logger = null;
            //    this.cmbComPort.Text = "Open";
            //}
#if DEBUG
            if(this.btnConectionPort.Text == "Open")
            {
                string comPort = this.cmbComPort.SelectedItem.ToString();
                this.ssd = new SerialSignalData(comPort, baudRate: 115200);
                this.btnConectionPort.Text = "Close";
                this.tmrTimeSeriesGraphRender.Enabled = true;
                this.tmrSpectrogramGraphRender.Enabled = true;

                this.Notch50 = new IIRFilter(int.Parse(this.cmbSampleRate.SelectedItem.ToString()), 50, 5);

                this.spectrogram = new Spectrogram.Spectrogram(128, 128, 25);
                this.pbSpectrogram.Height = this.spectrogram.Height;

                this.pbScaleVert.Image?.Dispose();
                this.pbScaleVert.Image = this.spectrogram.GetVerticalScale(this.pbScaleVert.Width);
                this.pbScaleVert.Height = this.spectrogram.Height;
            }
            else
            {
                this.btnConectionPort.Text = "Open";
                this.tmrTimeSeriesGraphRender.Enabled = false;
                this.tmrSpectrogramGraphRender.Enabled = false;
            }
#else
             
             Console.WriteLine("Mode=Other");
#endif
        }

        private void tmrSerialPort_Tick(object sender, EventArgs e)
        {
            //if (this.logger is null || this.logger.DataPointCount == 0)
            //    return;

            //if (this.logger.LastUpdate == this.dtLastUpdate)
            //    return;
            //else
            //    this.dtLastUpdate = this.logger.LastUpdate;

            //this.scatterPlot.xs = this.logger.GetOADates();
            //this.scatterPlot.ys = this.logger.GetValues();

            //this.scpTimeSeries.plt.AxisAuto();

            //this.scpTimeSeries.Render();
        }

        private double[] GenerateSineWave(int sampleRate, double amplitude, double frequency)
        {
            double[] buffer = new double[sampleRate];
            for(int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = amplitude * Math.Sin((2 * Math.PI * i * frequency) / sampleRate);
            }
            return buffer;
        }

        private void tmrTimeSeriesGraphRender_Tick(object sender, EventArgs e)
        {
            if (this.busyRedering)
                return;

            busyRedering = true;

            this.scpTimeSeries.plt.Clear();
            //this.sineWave = this.GenerateSineWave(10000, 2, 10);
            //this.sineWave = DataGen.Sin(int.Parse(this.cmbSampleRate.SelectedItem.ToString()) + 12, oscillations: 10, mult: 2, offset: 0);
            this.ssd.SAMPLE_RATE = int.Parse(this.cmbSampleRate.SelectedItem.ToString());
            this.sineWave = this.ssd.GetValues();

            if (this.chkNotch50Hz.Checked)
            {
                for (int i = 0; i < this.sineWave.Length; i++)
                {
                    this.sineWave[i] = this.filter(this.sineWave[i], this.Notch50);
                }
            }    
            
            //double lastValueUpdate = this.sineWave[this.sineWave.Length - 1];
            this.scpTimeSeries.plt.PlotSignal(this.sineWave, 1, color: ColorTranslator.FromHtml("#d62728"));
            //this.scpTimeSeries.plt.PlotVLine(lastValueUpdate / this.sineWave.Length, color: ColorTranslator.FromHtml("#636363"));
            this.scpTimeSeries.Render();

            busyRedering = false;
        }

        private void tmrSpectrogramGraphRender_Tick(object sender, EventArgs e)
        {
            int fftSize = 1 << (9 + this.cmbFftSize.SelectedIndex);
            //int stepSize = fftSize / 20;
            //this.sineWave = DataGen.Sin(int.Parse(this.cmbSampleRate.SelectedItem.ToString()) + 12, oscillations: 10, mult: 2, offset: 0);
            this.ssd.SAMPLE_RATE = int.Parse(this.cmbSampleRate.SelectedItem.ToString());
            this.sineWave = this.ssd.GetValues();

            if (this.chkNotch50Hz.Checked)
            {
                for (int i = 0; i < this.sineWave.Length; i++)
                {
                    this.sineWave[i] = this.filter(this.sineWave[i], this.Notch50);
                }
            }
            
            this.spectrogram.SetColormap(Colormap.Turbo);

            this.spectrogram.Add(this.sineWave, process: false);
            if (this.spectrogram.FftsToProcess > 0)
            {
                this.spectrogram.Process();
                this.spectrogram.SetFixedWidth(this.pbSpectrogram.Width);
                Bitmap bmpSpec = new Bitmap(this.spectrogram.Width, this.spectrogram.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                using (var bmpSpecIndexed = this.spectrogram.GetBitmap(100.0, false, false))
                using (var gfx = Graphics.FromImage(bmpSpec))
                using (var pen = new Pen(Color.White))
                {
                    gfx.DrawImage(bmpSpecIndexed, 0, 0);
                    if (false)
                    {
                        gfx.DrawLine(pen, this.spectrogram.NextColumnIndex, 0, this.spectrogram.NextColumnIndex, this.pbSpectrogram.Height);
                    }
                }

                this.pbSpectrogram.Image?.Dispose();
                this.pbSpectrogram.Image = bmpSpec;
            }
        }

        public double filter(double x0, IIRFilter iirfilter)
        {
            double y = iirfilter.a0 * x0 + iirfilter.a1 * iirfilter.x1 + iirfilter.a2 * iirfilter.x2 + iirfilter.b1 * iirfilter.y1 + iirfilter.b2 * iirfilter.y2;

            iirfilter.x2 = iirfilter.x1;
            iirfilter.x1 = x0;
            iirfilter.y2 = iirfilter.y1;
            iirfilter.y1 = y;

            return y;
        }
    } // class
} // namespace
