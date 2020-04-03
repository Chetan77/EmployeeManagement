using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementImplementation
{
    public class Inch
    {
        double inchValue;

        public Inch(double inchValue)
        {
            this.inchValue = inchValue;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || object.ReferenceEquals(obj, this) || obj.Equals(this.GetType()))
            {
                return true;
            }
            return false;
        }
        public bool CheckForEquality(Inch inchValue)
        {
            if (this.inchValue.Equals(inchValue.inchValue))
            {
                return true;
            }
            return false;
        }
    }
}
