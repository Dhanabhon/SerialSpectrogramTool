/*
 * This is a class for the serial data logger
 * Written by Scott W Harden, DMD, PhD
 * Link: https://github.com/swharden/SeriPlot/blob/main/src/SeriPlot/SerialDataLogger.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Import
using System.IO.Ports;
using System.Diagnostics;
#endregion Import

namespace SerialSpectrogramTool
{
    public class SerialDataLogger
    {
        private readonly List<DateTime> Timestamps = new List<DateTime>();
        private readonly List<double>[] Data;
        private readonly SerialPort SP;
        private readonly string LineEnding;
        public int ChannelCount { get => Data.Length; }
        public int DataPointCount { get => Timestamps.Count; }
        private readonly string Port;

        public double[] GetValues(int channelIndex = 0) => Data[channelIndex].ToArray();

        public double[] GetOADates() => Timestamps.Select(x => x.ToOADate()).ToArray();
        public DateTime LastUpdate => Timestamps.Last();

        public SerialDataLogger(string port, int channelCount, int sampleRate = 115200, string lineEnding = "\r\n\r\n")
        {
            Port = port;
            LineEnding = lineEnding;

            Data = Enumerable.Range(0, channelCount).Select(x => new List<double>()).ToArray();
            SP = new SerialPort(port, sampleRate);
            try
            {
                SP.Open();
                Debug.WriteLine($"Connected to {Port}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error Exception: {ex.ToString()}");
            }
            
            SP.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //string newData = sp.ReadExisting() + sp.ReadTo(LineEnding);
            string newData = sp.ReadLine();
            //Debug.WriteLine("New Data: " + newData);
            ProcessNewData2(newData);
        }

        private void ProcessNewData2(string newData)
        {
            //string[] textValues = newData.Split(new char[] { '\r', '\n' });
            string[] textValues = newData.Split('\n');

            double[] values = { 0.0 };

            for (int i = 0; i < textValues.Length; i++)
            {
                if (!this.IsDouble(textValues[i]))
                    return;

                values[i] = double.Parse(textValues[i]);
            }

            Timestamps.Add(DateTime.Now);
            for (int i = 0; i < ChannelCount; i++)
            {
                Data[i].Add(values[i]);
                Debug.WriteLine($"Data: {values[i]}");
            }
        }

        public bool IsDouble(string text)
        {
            Double num = 0;
            bool isDouble = false;

            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            isDouble = Double.TryParse(text, out num);

            return isDouble;
        }

        // TODO: allow this to be injected somehow
        private void ProcessNewData(string newData)
        {
            string[] lines = newData.Split('\n')
                                    .Select(x => x.Trim())
                                    .Where(x => x.StartsWith("CH"))
                                    .ToArray();

            if (lines.Count() != ChannelCount)
            {
                Debug.WriteLine($"invalid packet");
                return;
            }

            double[] values = lines.Select(x => x.Split('\t')[0])
                                   .Select(x => x.Split(':')[1])
                                   .Select(x => Math.Round(double.Parse(x) * 3.3 / 4096, 3))
                                   .ToArray();

            string valuesText = string.Join("\t", values.Select(x => x.ToString()));
            Debug.WriteLine($"logged: {valuesText}");

            Timestamps.Add(DateTime.Now);
            for (int i = 0; i < ChannelCount; i++)
                Data[i].Add(values[i]);
        }

        public void Dispose()
        {
            SP.Close();
            Debug.WriteLine($"Disconnected from {Port}");
        }

        public void Clear()
        {
            for (int i = 0; i < ChannelCount; i++)
                Data[i].Clear();
            Timestamps.Clear();
        }

        public double GetLatestValue(int channel = 0) => (DataPointCount == 0) ? double.NaN : Data[channel].Last();
    } // class
} // namepace
