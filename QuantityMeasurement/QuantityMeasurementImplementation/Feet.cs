using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementImplementation
{
    public class Feet
    {
        double length;

        public Feet(double length)
        {
            this.length = length;
        }

        public bool CheckForEqual(Feet length)
        {
            if (this.length.Equals(length.length))
            {
                return true;
            }
            return false;
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || object.ReferenceEquals(obj, this) || obj.Equals(this.GetType()))
            {
                return true;
            }
            return false;
        }
    }
}
