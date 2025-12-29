namespace LeetCode.Core.Problems.Array
{
    public class P0001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] solution = [0, 0];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j ++)
                {
                    if ((nums[i] + nums[j]) == target && i != j)
                    {
                        solution[0] = i;
                        solution[1] = j;
                        return solution;
                    }
                }
            }

            return solution;
        }
    }
}
