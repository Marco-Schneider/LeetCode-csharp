namespace LeetCode.Core.Problems.String
{
    public class P0389_FindTheDifference
    {
        public char FindTheDifference(string s, string t)
        {
            int originalSize = 0;
            int finalSize = 0;

            for (int i = 0; i < s.Length; i++)
            {
                originalSize += s[i];
            }

            for (int i = 0; i < t.Length; i++)
            {
                finalSize += t[i];
            }

            var addedCharacter = finalSize - originalSize;

            return (char)addedCharacter;
        }
    }
}
