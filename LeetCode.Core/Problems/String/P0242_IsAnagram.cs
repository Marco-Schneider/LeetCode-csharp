namespace LeetCode.Core.Problems.String
{
    public class P0242_IsAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) 
                return false;

            Dictionary<char, int> frequenciesOfFirstString = [];
            Dictionary<char, int> frequenciesOfSecondString = [];
    
            for (int i = 0; i < s.Length; i++)
            {
                if (!frequenciesOfFirstString.TryGetValue(s[i], out int _))
                {
                    frequenciesOfFirstString.Add(s[i], 1);
                }
                else 
                {
                    frequenciesOfFirstString[s[i]] += 1;
                }

                if (!frequenciesOfSecondString.TryGetValue(t[i], out int _))
                {
                    frequenciesOfSecondString.Add(t[i], 1);
                }
                else {
                    frequenciesOfSecondString[t[i]] += 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (!frequenciesOfSecondString.TryGetValue(s[i], out int _))
                {
                    return false;
                }

                if (frequenciesOfSecondString[s[i]] != frequenciesOfFirstString[s[i]])
                {
                    return false;
                }

            }

            return true;
        }
    }
}
