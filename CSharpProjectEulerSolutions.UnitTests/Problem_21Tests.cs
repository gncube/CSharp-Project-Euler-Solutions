using FluentAssertions;

namespace CSharpProjectEulerSolutions.UnitTests;

public class Problem_21Tests
{
    private readonly AmicableNumbers sut;

    public Problem_21Tests()
    {
        sut = new AmicableNumbers();
    }

    [Theory]
    [InlineData(220, new int[] { 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110 })]
    [InlineData(284, new int[] { 1, 2, 4, 71, 142 })]
    public void ReturnAnArrayOfProperDivisorsOfGivenNumber(int number, int[] expected)
    {
        List<int> properDivisors = expected.ToList();
        var actual = sut.ProperDivisors(number);

        actual.Should().BeEquivalentTo(properDivisors);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110 }, 284)]
    [InlineData(new int[] { 1, 2, 4, 71, 142 }, 220)]
    public void ReturnTheSumOfArray(int[] numbers, int expected)
    {
        List<int> numbersList = numbers.ToList();
        var actual = sut.SumOfArray(numbersList);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(new int[] { 220, 284 }, 220)]
    public void ReturnAnArrayOfAmicableNumbers(int[] expected, int number)
    {
        var amicableNumbers = sut.GetAmicableNumbers(number);

        amicableNumbers.Should().BeEquivalentTo(expected);
    }
}

/*
* 1. Create function that gets an array of proper divisors of n
* 2. Sum the array of proper divisors of n
* 3. Find if the numbers are amicable
* 4. 
*/
