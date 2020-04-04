using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Celcius
    {
        double celcius;

        public Celcius(double celcius)
        {
            this.celcius = celcius;
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
        public bool CheckForEqual(Celcius celcius)
        {
            if (this.celcius.Equals(celcius.celcius))
            {
                return true;
            }
            return false;
        }
    }
}
