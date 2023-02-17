using FluentAssertions;

namespace CSharpProjectEulerSolutions.UnitTests
{
    public class Problem_24Tests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 2 }, 3, "102")]
        [InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1000000, "2783915460")]
        public void ShouldReturnTheNthLexicographicPermutation(int[] digits, int n, string expected)
        {
            var processor = new LexicographicPermutations();
            var result = processor.GetNthPermutation(digits, n);


            result.Should().BeEquivalentTo(expected);
        }
    }
}
