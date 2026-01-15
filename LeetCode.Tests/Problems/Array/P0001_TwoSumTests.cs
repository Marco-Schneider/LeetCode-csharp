using LeetCode.Core.Problems.Array;

namespace LeetCode.Tests.Problems.Array
{
    [Trait("Category", "Unit")]
    public class P0001_TwoSumTests
    {
        [Theory(DisplayName = "Should return the two indexes that sum up to the target value")]
        [InlineData((int[])[2, 5, 5, 11], 10, (int[])[1, 2])]
        [InlineData((int[])[2, 7, 11, 15], 9, (int[])[0, 1])]
        [InlineData((int[])[3, 2, 4], 6, (int[])[1, 2])]
        [InlineData((int[])[3, 3], 6, (int[])[0, 1])]
        public void TwoSumTest(int[] nums, int target, int[] expectedOutput)
        {
            // Arrange
            var solver = new P0001_TwoSum();

            // Act
            var solution = solver.TwoSum(nums, target);

            // Assert
            Assert.Equal(expectedOutput, solution);
        }
    }
}
