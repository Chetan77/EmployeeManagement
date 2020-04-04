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
            Feet feet = new Feet(0);
            bool act=feet.CheckForEqual(feet);
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Tests for equality null check should return true or false.
        /// </summary>
        [Test]
        public void TestFor_EqualityNullCheck_ShouldReturnTrueOrFalse()
        {
            Feet feet = new Feet(0);
            bool act=feet.Equals(null);
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Tests for reference check should return true or false.
        /// </summary>
        [Test]
        public void TestFor_ReferenceCheck_ShouldReturnTrueOrFalse()
        {
            Feet feet = new Feet(23);
            bool act = feet.Equals(feet);
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Tests for type check should return true or false.
        /// </summary>
        [Test]
        public void TestFor_TypeCheck_ShouldReturnTrueOrFalse()
        {
            Feet feet = new Feet(10);
            bool act = feet.Equals(feet.GetType());
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Tests for value equality should return value equal.
        /// </summary>
        [Test]
        public void TestForValueEquality_ShouldReturnValueEqual()
        {
            Feet feet = new Feet(10);
            bool act =feet.CheckForEqual(feet);
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Givens the zero to inch zero inch should retorn equality.
        /// </summary>
        [Test]
        public void GivenZeroToInch_ZeroInchShouldRetorn_Equality()
        {
            Inch inch = new Inch(0);
            bool act=inch.CheckForEquality(inch);
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Tests for inch equality null check should return true or false.
        /// </summary>
        [Test]
        public void TestFor_InchEqualityNullCheck_ShouldReturnTrueOrFalse()
        {
            Inch inch = new Inch(0);
            bool act = inch.Equals(null);
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Tests for inch reference check should return true or false.
        /// </summary>
        [Test]
        public void TestFor_InchReferenceCheck_ShouldReturnTrueOrFalse()
        {
            Inch inch = new Inch(0);
            bool act = inch.Equals(inch);
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Tests for inch type check should return true or false.
        /// </summary>
        [Test]
        public void TestFor_InchTypeCheck_ShouldReturnTrueOrFalse()
        {
            Inch inch = new Inch(0);
            bool act = inch.Equals(inch.GetType());
            Assert.IsTrue(act);
        }

        /// <summary>
        /// Tests for value equality in inch should return value equal.
        /// </summary>
        [Test]
        public void TestForValueEqualityInInch_ShouldReturnValueEqual()
        {
            Inch inch = new Inch(10);
            bool act=inch.CheckForEquality(inch);
            Assert.IsTrue(act);
        }

        [Test]
        public void GivenZeroToYard_ZeroYardShouldRetorn_Equality()
        {
            Yard yard = new Yard(0);
            bool act = yard.CheckForEqual(yard);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenNullToYardEqualityNullCheck_ShouldReturnTrueOrFalse()
        {
            Yard yard = new Yard(0);
            bool act = yard.Equals(null);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenReference_WhenCheck_ShouldReturnTrueOrFalse()
        {
            Yard yard = new Yard(0);
            bool act = yard.Equals(yard);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenYardType_TypeCheck_ShouldReturnTrueOrFalse()
        {
            Yard yard = new Yard(0);
            bool act = yard.Equals(yard.GetType());
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenYardvalue_ToEqualityInYard_ShouldReturnValueEqual()
        {
            Yard yard = new Yard(10);
            bool act = yard.CheckForEqual(yard);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenNullToKiloGramEqualityNullCheck_ShouldReturnTrueOrFalse()
        {
            KiloGram kiloGram = new KiloGram(0);
            bool act = kiloGram.Equals(null);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenReferenceOfKilogram_WhenCheck_ShouldReturnTrueOrFalse()
        {
            KiloGram kiloGram = new KiloGram(0);
            bool act = kiloGram .Equals(kiloGram);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenKilogramsType_TypeCheck_ShouldReturnTrueOrFalse()
        {
            KiloGram kiloGram = new KiloGram(0);
            bool act = kiloGram.Equals(kiloGram.GetType());
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenKilogramdvalue_ToEqualityInYard_ShouldReturnValueEqual()
        {
            KiloGram kiloGram = new KiloGram(10);
            bool act = kiloGram.CheckForEqual(kiloGram);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenNullToGramEqualityNullCheck_ShouldReturnTrueOrFalse()
        {
            Gram gram = new Gram(0);
            bool act = gram.Equals(null);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenReferenceOfGram_WhenCheck_ShouldReturnTrueOrFalse()
        {
            Gram gram = new Gram(0);
            bool act = gram.Equals(gram);
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenGramType_TypeCheck_ShouldReturnTrueOrFalse()
        {
            Gram gram = new Gram(0);
            bool act = gram.Equals(gram.GetType());
            Assert.IsTrue(act);
        }
        [Test]
        public void GivenGramdvalue_ToEqualityInYard_ShouldReturnValueEqual()
        {
            Gram gram = new Gram(8);
            bool act = gram.CheckForEqual(gram);
            Assert.IsTrue(act);
        }
    }
}