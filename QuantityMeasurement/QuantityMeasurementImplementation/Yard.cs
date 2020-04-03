using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementImplementation
{
    public class Yard
    {
        double yard;

        public Yard(double yard)
        {
            this.yard = yard;
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


        public bool CheckForEqual(Yard yard)
        {
            if (this.yard.Equals(yard.yard))
            {
                return true;
            }
            return false;
        }

    }
}
