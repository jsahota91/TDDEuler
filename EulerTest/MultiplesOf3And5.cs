using NUnit.Framework;
using Euler;

namespace EulerTest
{
    public class MultiplesOf3And5
    { 
        [Test]
        public void GivenMaxIs5_SumOfMultipleBelow3and5_Return8()
        {
            Assert.That(Program.SumOfMultiples(6), Is.EqualTo(8));           
        }

        [Test]
        public void GivenMaxIs10_SumOfMultipleBelow3and5_Return23()
        {
            Assert.That(Program.SumOfMultiples(10), Is.EqualTo(23));
        }

        [Test]
        public void GivenMaxIs1000_SumOfMultipleBelow3and5_Return233168()
        {
            Assert.That(Program.SumOfMultiples(1000), Is.EqualTo(233168));
        }
        
    }
}