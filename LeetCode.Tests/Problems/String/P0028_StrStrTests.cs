using LeetCode.Core.Problems.String;

namespace LeetCode.Tests.Problems.String
{
    [Trait("Category", "Unit")]
    public class P0028_StrStrTests
    {
        [Theory(DisplayName = "Should return the index if substring is found, otherwise should return -1")]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        public void StrStrTests(string haystack, string needle, int expectedResult)
        {
            // Arrange
            var solver = new P0028_StrStr();

            // Act
            var solution = solver.StrStr(haystack, needle);

            // Assert
            Assert.Equal(expectedResult, solution);
        }
    }
}
