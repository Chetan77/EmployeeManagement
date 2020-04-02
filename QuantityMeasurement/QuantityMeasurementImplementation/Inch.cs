using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementImplementation
{
    public class Inch
    {
        private double inchValue;

        public Inch()
        {
        }

        public double CheckForEquality(double inchVlaue)
        {
            return this.inchValue = inchVlaue;
        }
    }
}
