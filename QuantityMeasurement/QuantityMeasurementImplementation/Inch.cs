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
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || object.ReferenceEquals(obj, this))
            {
                return true;
            }
            return false;
        }
    }
}
