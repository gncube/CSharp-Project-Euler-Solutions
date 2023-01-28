using FluentAssertions;

namespace CSharpProjectEulerSolutions.UnitTests
{
    /*
     * 
     * Factorial digit sum
     *  n! means n × (n − 1) × ... × 3 × 2 × 1

        For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
        and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

        Find the sum of the digits in the number 100!
     */
    public class Problem_20Tests
    {
        [Theory]
        [InlineData(27, 10)]
        public void ShouldReturnTheSumOfTheFactorial(int expected, int number)
        {
            var sut = new FactorialDigitSum();
            var actual = sut.GetDigitsSum(number);

            actual.Should().Be(expected);
        }

        //[Fact]
        //public void ShouldReturnTheSumOfTheFactorial2()
        //{
        //    int expected = 27;
        //    int number = 10;
        //    var sut = new FactorialDigitSum();
        //    var actual = sut.GetDigitsSum(number);

        //    actual.Should().Be(expected);
        //}
    }
}
