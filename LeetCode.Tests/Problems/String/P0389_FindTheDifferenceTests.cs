using LeetCode.Core.Problems.String;

namespace LeetCode.Tests.Problems.String
{
    [Trait("Category", "Unit")]
    public class P0389_FindTheDifferenceTests
    {
        [Theory(DisplayName = "Should return the character that was added")]
        [InlineData("abcd", "abcde", 'e')]
        [InlineData("", "y", 'y')]
        [InlineData("a", "aa", 'a')]
        [InlineData("uygbk", "kbtuyg", 't')]
        public void FindTheDifferenceTestsTest(string s, string t, char expectedOutput)
        {
            // Arrange
            var solver = new P0389_FindTheDifference();

            // Act
            var solution = solver.FindTheDifference(s, t);

            // Assert
            Assert.Equal(expectedOutput, solution);
        }
    }
}
