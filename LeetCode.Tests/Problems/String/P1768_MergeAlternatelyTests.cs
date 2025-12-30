using LeetCode.Core.Problems.String;

namespace LeetCode.Tests.Problems.String
{
    public class P1768_MergeAlternatelyTests
    {

        [Theory(DisplayName = "Should merge word1 and word2 alternating their characters")]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("ab", "pqrs", "apbqrs")]
        [InlineData("abcd", "pq", "apbqcd")]
        [InlineData("cdf", "a", "cadf")]
        public void MergeAlternatelyTest(string word1, string word2, string expectedOutput)
        {
            // Arrange
            var solver = new P1768_MergeAlternately();

            // Act
            var solution = solver.MergeAlternately(word1, word2);

            // Assert
            Assert.Equal(expectedOutput, solution);
        }
    }
}
