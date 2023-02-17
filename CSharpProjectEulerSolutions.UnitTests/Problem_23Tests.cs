using FluentAssertions;

namespace CSharpProjectEulerSolutions.UnitTests;

public class Problem_23Tests
{
    [Fact]
    public void NonAbundantSums_Returns_The_Sum()
    {
        var sut = new NonAbundantSums();

        int expected = 4179871;
        int actual = sut.SumOfNonAbundantSums();

        actual.Should().Be(expected);
    }
}

