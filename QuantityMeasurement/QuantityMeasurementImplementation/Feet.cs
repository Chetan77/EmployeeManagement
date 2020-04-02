using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementImplementation
{
    public class Feet
    {
        private double length;

        public Feet()
        {

        }

        public double CheckForEqual(double length)
        {
            return this.length = length;
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
