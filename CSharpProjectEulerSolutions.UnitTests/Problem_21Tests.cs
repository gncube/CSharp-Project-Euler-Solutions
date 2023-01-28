using FluentAssertions;

namespace CSharpProjectEulerSolutions.UnitTests;

public class Problem_21Tests
{
    [Fact]
    public void ReturnAnArrayOfProperDivisorsOf220()
    {
        var number = 220;
        var sut = new AmicableNumbers();
        List<int> properDivisors = new List<int>() { 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110 };
        var actual = sut.ProperDivisors(number);

        actual.Should().BeEquivalentTo(properDivisors);
    }

    [Fact]
    public void ReturnAnArrayOfProperDivisorsOf284()
    {
        var number = 284;
        var sut = new AmicableNumbers();
        List<int> properDivisors = new List<int>() { 1, 2, 4, 71, 142 };
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
