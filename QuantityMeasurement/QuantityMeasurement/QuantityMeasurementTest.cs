using NUnit.Framework;
using QuantityMeasurementImplementation;

namespace QuantityMeasurement
{
    public class QuantityMeasurementTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Givens the zero feet zero feet should return equal.
        /// </summary>
        [Test]
        public void GivenZeroFeet_ZeroFeet_ShouldReturnEqual()
        {
            Feet feet = new Feet();
            double act=feet.CheckForEqual(0);
            Assert.AreEqual(0, act);
        }
        [Test]
        public void TestFor_EqualityNullCheck_ShouldReturnTrueOrFalse()
        {
            Feet feet = new Feet();
            bool act=feet.Equals(null);
            Assert.IsTrue(act);
        }
        [Test]
        public void TestFor_ReferenceCheck_ShouldReturnTrueOrFalse()
        {
            Feet feet = new Feet();
            bool act = feet.Equals(feet);
            Assert.IsTrue(act);
        }

        [Test]
        public void TestFor_TypeCheck_ShouldReturnTrueOrFalse()
        {
            Feet feet = new Feet();
            bool act = feet.Equals(feet.GetType());
            Assert.IsTrue(act);
        }

        [Test]
        public void TestForValueEquality_ShouldReturnValueEqual()
        {
            Feet feet = new Feet();
            double act =feet.CheckForEqual(0);
            Assert.AreEqual(0,act);
        }
        [Test]
        public void GivenZeroToInch_ZeroInchShouldRetorn_Equality()
        {
            Inch inch = new Inch();
            double act=inch.CheckForEquality(0);
            Assert.AreEqual(0, act);
        }
        [Test]
        public void TestFor_InchEqualityNullCheck_ShouldReturnTrueOrFalse()
        {
            Inch inch = new Inch();
            bool act = inch.Equals(null);
            Assert.IsTrue(act);
        }
        [Test]
        public void TestFor_InchReferenceCheck_ShouldReturnTrueOrFalse()
        {
            Inch inch = new Inch();
            bool act = inch.Equals(inch);
            Assert.IsTrue(act);
        }
        [Test]
        public void TestFor_InchTypeCheck_ShouldReturnTrueOrFalse()
        {
            Inch inch = new Inch();
            bool act = inch.Equals(inch.GetType());
            Assert.IsTrue(act);
        }
        [Test]
        public void TestForValueEqualityInInch_ShouldReturnValueEqual()
        {
            Inch inch = new Inch();
            double act=inch.CheckForEquality(13);
            Assert.AreEqual(13, act);
        }
    }
}