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
            Assert.That(() => Fizzbuzz.Of(101), Throws.ArgumentException.With.Message.EqualTo("bar"));
        }
        
        
    }
}