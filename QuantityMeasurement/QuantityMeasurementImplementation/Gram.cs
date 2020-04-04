using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementImplementation
{
    public class Gram
    {
        double grams;
        public Gram(double grams)
        {
            this.grams = grams;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || object.ReferenceEquals(obj, this) || obj.Equals(this.GetType()))
            {
                return true;
            }
            return false;

        }
        public bool CheckForEqual(Gram gram)
        {
            if (this.grams.Equals(gram.grams))
            {
                return true;
            }
            return false;
        }
    }
}
