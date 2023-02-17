using FluentAssertions;

namespace CSharpProjectEulerSolutions.UnitTests;

public class Problem_22Tests
{
    [Fact]
    public void AlphabeticalValue_Colin_Returns53()
    {
        var sut = new NameScores();

        int expected = 53;
        int actual = sut.AlphabeticalValue("COLIN");

        actual.Should().Be(expected);
    }

    [Fact]
    public void Solve_SampleNames_ReturnsCorrectSum()
    {
        var sut = new NameScores();
        string[] names = { "AARON", "AMELIA", "COLIN" };
        int expected = 290;
        int actual = sut.Solve(names);

        actual.Should().Be(expected);
    }
}

/*
* 1. Create function that gets an array of proper divisors of n
* 2. Sum the array of proper divisors of n
* 3. Find if the numbers are amicable
* 4. 
*/
