using NUnit.Framework;
using Euler;

namespace EulerTest
{
    public class PrimeTest
    { 
        [Test]
        public void GivenPrime_IsPrime_ReturnTrue()
        {
            Assert.That(Program.IsPrime(7), Is.EqualTo(true));
            
        }

        [Test]
        public void GivenNotPrime_IsPrime_ReturnFalse()
        {
            Assert.That(Program.IsPrime(4), Is.EqualTo(false));
        }

        public void GivenMaxIs2_SumPrime_ReturnSumOfPrimes()
        {
            Assert.That(Program.SumPrime(2), Is.EqualTo(2));
        }

        [TestCase(10, 17)]
        [TestCase(20, 77)]
        [TestCase(2000000, 142913828922)]
        public void GivenMaxNumber_SumPrime_ReturnSumOfPrimes(long max, long expectedSum)
        {
            Assert.That(Program.SumPrime(max), Is.EqualTo(expectedSum));
        }
    }
}