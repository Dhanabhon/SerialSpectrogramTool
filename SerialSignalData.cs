using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Import
using System.IO.Ports;
using System.Runtime.CompilerServices;
#endregion Import

namespace SerialSpectrogramTool
{
    public class SerialSignalData
    {
        private SerialPort serialPort = null;

        private double[] values = { 0.0 };

        public int SAMPLE_RATE = 128;

        private int count = 0;
       
        public SerialSignalData(string port, int baudRate = 115200)
        {
            this.values = new double[SAMPLE_RATE];

            this.serialPort = new SerialPort(port, baudRate);
            this.serialPort.Open();
            this.serialPort.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string newData = this.serialPort.ReadLine();
            string[] textValues = newData.Split(new char[] { '\r', '\n' });
            this.ProcessOnDataAvailable(textValues[0]);
        }

        private void ProcessOnDataAvailable(string newData)
        {
            if (this.count == this.values.Length)
            {
                this.count = 0;
            }


            if (!this.IsDouble(newData))
                values[this.count] = 0;
            else
                values[this.count] = double.Parse(newData);

            this.count++;

            //for (int i = 0; i < values.Length; i++)
            //{
            //    if (!this.IsDouble(newData))
            //        values[i] = 0;
            //    else
            //        values[i] = double.Parse(newData);
            //}
        }

        public double[] GetValues() => this.values;

        public bool IsDouble(string text)
        {
            double num = 0;
            bool isDouble = false;

            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            isDouble = Double.TryParse(text, out num);

            return isDouble;
        }
    } // class
} // namespace
