using System;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class FizzbuzzTest
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(99)]
        public void Number_DivisibleBy3_ReturnsFizz(int value) {
            Assert.AreEqual("Fizz", Fizzbuzz.Convert(value));
        }

        [Test]
        public void Number_Beyond_100_NotSupported() {
            Assert.That(() => Fizzbuzz.Convert(101), Throws.ArgumentException.With.Message.EqualTo("bar"));
        }
        
    }


    
    
    public static class Fizzbuzz {
        public static string Convert(int number) {
            if (number > 100) {
                throw new ArgumentException("bar");
            }
            return "Fizz";
        }
    }
}