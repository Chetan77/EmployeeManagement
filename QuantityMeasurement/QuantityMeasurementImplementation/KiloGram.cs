using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementImplementation
{
    public class KiloGram
    {
        double kg;
        public KiloGram(double kg)
        {
            this.kg = kg;
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
        public bool CheckForEqual(KiloGram kiloGram)
        {
            if (this.kg.Equals(kiloGram.kg))
            {
                return true;
            }
            return false;
        }
    }
}
