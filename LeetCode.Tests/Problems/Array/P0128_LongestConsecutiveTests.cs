using LeetCode.Core.Problems.Array;

namespace LeetCode.Tests.Problems.Array
{
    public class P0128_LongestConsecutiveTests
    {
        [Theory(DisplayName = "Should correctly calculate the count of the longest integer sequence within the array")]
        [InlineData((int[])[100, 4, 200, 1, 3, 2], 4)]
        [InlineData((int[])[0, 3, 7, 2, 5, 8, 4, 6, 0, 1], 9)]
        [InlineData((int[])[1, 0, 1, 2], 3)]
        public void LongestConsecutiveTests(int[] nums, int expectedCount)
        {
            // Arrange
            var solver = new P0128_LongestConsecutive();

            // Act
            var solution = solver.LongestConsecutive(nums);

            // Assert
            Assert.Equal(expectedCount, solution);
        }
    }
}
