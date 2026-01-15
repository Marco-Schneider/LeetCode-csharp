using LeetCode.Core.Problems.String;

namespace LeetCode.Tests.Problems.String
{
    [Trait("Category", "Unit")]
    public class P0242_IsAnagramTests
    {
        [Theory(DisplayName = "Should correctly determine if the test string t is an anagram of s")]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        [InlineData("ggii", "eekk", false)]
        [InlineData("aacc", "ccac", false)]
        public void IsAnagramTests(string s, string t, bool expectedResult)
        {
            // Arrange
            var solver = new P0242_IsAnagram();

            // Act
            var solution = solver.IsAnagram(s, t);

            // Assert
            Assert.Equal(expectedResult, solution);
        }
    }
}
