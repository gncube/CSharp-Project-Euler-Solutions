using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
        [Fact]
        public void ShouldReturnTheSumOfTheFactorial()
        {
            var number = 10;
            BigInteger factorial = 3628800;

            var sut = new FactorialDigitSum();
            var actual = sut.GetDigitsSum(factorial);

            actual.Should().Be(number);
        }
    }
}
