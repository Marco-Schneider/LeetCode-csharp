using System.Text;

namespace LeetCode.Core.Problems.String
{
    public class P1768_MergeAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            int largestLength = word1.Length > word2.Length ? word1.Length : word2.Length;
            int indexWord1 = 0;
            int indexWord2 = 0;

            StringBuilder mergedString = new();

            for (var i = 0; i < largestLength; i++)
            {
                if (indexWord1 < word1.Length)
                {
                    mergedString.Append(word1[i]);
                    indexWord1 += 1;
                }
                if (indexWord2 < word2.Length)
                {
                    mergedString.Append(word2[i]);
                    indexWord2 += 1;
                }
            }

            return mergedString.ToString();
        }
    }
}
