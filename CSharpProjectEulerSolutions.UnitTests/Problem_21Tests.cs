using FluentAssertions;

namespace CSharpProjectEulerSolutions.UnitTests;

public class Problem_21Tests
{
    [Theory]
    [InlineData(220, new int[] { 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110 })]
    [InlineData(284, new int[] { 1, 2, 4, 71, 142 })]    
    public void ReturnAnArrayOfProperDivisorsOfGivenNumber(int number, int[] expected)
    {
        var sut = new AmicableNumbers();
        List<int> properDivisors = expected.ToList();
        var actual = sut.ProperDivisors(number);

        actual.Should().BeEquivalentTo(properDivisors);
    }
}

/*
* 1. Create function that gets an array of proper divisors of n
* 2. Sum the array of proper divisors of n
* 3. Find if the numbers are amicable
* 
*/
