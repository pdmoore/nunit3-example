using System;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class FizzbuzzTest
    {
        [Test]
        public void Number_NotDivisibleBy_3or5_ReturnsNumber() {
            Assert.AreEqual("1", Fizzbuzz.Of(1));
        }
        
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(99)]
        public void Number_DivisibleBy3_ReturnsFizz(int value) {
            Assert.AreEqual("Fizz", Fizzbuzz.Of(value));
        }

        [Test]
        public void Number_Beyond_100_NotSupported() {
            ArgumentException ex = Assert.Throws<ArgumentException>(
                () => Fizzbuzz.Of(101));
            Assert.AreEqual("Number must be within 1 to 100", ex.Message);
        }

        [Test]
        public void Alternative_Style_Expecting_Exception() {
            Assert.That(() => Fizzbuzz.Of(101), 
                Throws.ArgumentException.With.Message.EqualTo("Number must be within 1 to 100"));
        }

        [Test]
        [Ignore("Ask PO how to correctly handle this case")]
        public void Negative_Numbers() {
            Assert.Fail("unknown behavior");
        }
        
    }
}