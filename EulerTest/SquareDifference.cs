using NUnit.Framework;
using Euler;

namespace EulerTest
{
    public class SquareDifference
    {
        [Test]
        public void GivenMaxIs1_SumOfSquareNumbers_Return1()
        {
            Assert.That(Program.SumOfSquareNumbers(1), Is.EqualTo(1));
        }

        [Test]
        public void GivenMaxIs1_SquareOfTotal_Return1()
        {
            Assert.That(Program.SquareOfTotal(1), Is.EqualTo(1));
        }

        [Test]
        public void GivenMaxIs1_DifferenceOfSumSquares_Return0()
        {
            Assert.That(Program.DifferenceOfSumSquares(1), Is.Zero);
        }
        [Test]
        public void GivenMaxIs10_SumOfSquareNumbers_Return385()
        {
            Assert.That(Program.SumOfSquareNumbers(10), Is.EqualTo(385));
        }

        [Test]
        public void GivenMaxIs10_SquareOfTotal_Return3025()
        {
            Assert.That(Program.SquareOfTotal(10), Is.EqualTo(3025));
        }

        [Test]
        public void GivenMaxIs10_DifferenceOfSumSquares_Return2640()
        {
            Assert.That(Program.DifferenceOfSumSquares(10), Is.EqualTo(2640));
        }

        [Test]
        public void GivenMaxIs100_SumOfSquareNumbers_Return338350()
        {
            Assert.That(Program.SumOfSquareNumbers(100), Is.EqualTo(338350));
        }

        [Test]
        public void GivenMaxIs100_SquareOfTotal_Return25502500()
        {
            Assert.That(Program.SquareOfTotal(100), Is.EqualTo(25502500));
        }

        [Test]
        public void GivenMaxIs100_DifferenceOfSumSquares_Return25164150()
        {
            Assert.That(Program.DifferenceOfSumSquares(100), Is.EqualTo(25164150));
        }
    }
}