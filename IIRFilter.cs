using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSpectrogramTool
{
    public class IIRFilter
    {
        public double a0;
        public double a1;
        public double a2;
        public double b1;
        public double b2;

        public double x1;
        public double x2;
        public double y1;
        public double y2;

        // three parameters indicates a notch filter
        // equation obtained here http://dspguide.com/ch19/3.htm
        public IIRFilter(double samplingrate, double frequency, double Bandwidth)
        {
            double BW = Bandwidth / samplingrate;
            double f = frequency / samplingrate;
            double R = 1 - 3 * BW;
            double K = (1 - 2 * R * Math.Cos(2 * Math.PI * f) + R * R) / (2 - 2 * Math.Cos(2 * Math.PI * f));
            a0 = K;
            a1 = -2 * K * Math.Cos(2 * Math.PI * f);
            a2 = K;
            b1 = 2 * R * Math.Cos(2 * Math.PI * f);
            b2 = -R * R;

            x1 = x2 = y1 = y2 = 0;
        }

        // two parameters indicates a 2nd order Butterworth low-pass filter
        // equation obtained here: https://www.codeproject.com/Tips/1092012/A-Butterworth-Filter-in-Csharp
        public IIRFilter(double samplingrate, double frequency)
        {
            double wc = Math.Tan(frequency * Math.PI / samplingrate);
            double k1 = 1.414213562f * wc;
            double k2 = wc * wc;
            a0 = k2 / (1 + k1 + k2);
            a1 = 2 * a0;
            a2 = a0;
            double k3 = a1 / k2;
            b1 = -2 * a0 + k3;
            b2 = 1 - (2 * a0) - k3;

            x1 = x2 = y1 = y2 = 0;
        }

        // for Butterworth high-pass filters or other IIR filters, you need to insert parameters manually.
        // Easy way to find these parameters is using R's "signal" package butter function, and convert parameters like this: 
        // a0 = $b[0]; a1 = $b[1]; a2 = $b[2]; b1 = -$a[1]; b2 = -$a[2]
        public IIRFilter(double a0in, double a1in, double a2in, double b1in, double b2in)
        {
            a0 = a0in;
            a1 = a1in;
            a2 = a2in;
            b1 = b1in;
            b2 = b2in;

            x1 = x2 = y1 = y2 = 0;
        }

    } // class 
} // namespace
