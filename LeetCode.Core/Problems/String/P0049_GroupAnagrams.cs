namespace LeetCode.Core.Problems.String
{
    public class P0049_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> groupedAnagrams = [];

            foreach (string word in strs)
            {
                int[] frequencyCount = new int[26];
                foreach (char c in word)
                {
                    frequencyCount[c - 'a'] += 1;
                }

                string key = string.Join(",", frequencyCount);

                if (!groupedAnagrams.ContainsKey(key.ToString()))
                {
                    groupedAnagrams[key.ToString()] = [];
                }

                groupedAnagrams[key.ToString()].Add(word);
            }

            return [.. groupedAnagrams.Values];
        }
    }
}
