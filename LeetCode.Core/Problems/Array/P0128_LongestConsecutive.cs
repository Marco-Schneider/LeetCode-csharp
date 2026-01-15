namespace LeetCode.Core.Problems.Array
{
    public class P0128_LongestConsecutive
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> numsSet = new(nums);

            int longestSequence = 0;
            foreach (int number in numsSet)
            {
                var currentNumber = number;
                var sequenceCount = 0;
                if (numsSet.Contains(number) && !numsSet.Contains(number - 1))
                {
                    while (numsSet.Contains(currentNumber))
                    {
                        numsSet.Remove(currentNumber);
                        sequenceCount++;
                        currentNumber++;
                    }
                    
                    if (sequenceCount > longestSequence)
                        longestSequence = sequenceCount;
                }
            }

            return longestSequence;
        }
    }
}
