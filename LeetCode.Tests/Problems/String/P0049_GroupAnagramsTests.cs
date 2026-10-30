using LeetCode.Core.Problems.String;

namespace LeetCode.Tests.Problems.String
{
    [Trait("Category", "Unit")]
    public class P0049_GroupAnagramsTests
    {
        [Theory(DisplayName = "Should correctly group anagrams")]
        [MemberData(nameof(TestCases))]
        public void GroupAnagramsTests(string[] strs, string[][] expectedResult)
        {
            // Arrange
            var solver = new P0049_GroupAnagrams();

            // Act
            var result = solver.GroupAnagrams(strs);

            // Assert
            Assert.Equal(Normalize(expectedResult), Normalize(result));
        }

        public static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new string[][]
                {
                    ["eat", "tea", "ate"],
                    ["tan", "nat"],
                    ["bat"]
                }
            };

            yield return new object[]
            {
                new string[] { "" },
                new string[][] { [""] }
            };

            yield return new object[]
            {
                new string[] { "a" },
                new string[][] { ["a"] }
            };

            yield return new object[]
            {
                new string[] { "ab", "aab" },
                new string[][] { ["ab"], ["aab"] }
            };

            yield return new object[]
            {
                new string[] { "abbbbbbbbbbb", "aaaaaaaaaaab" },
                new string[][] { ["abbbbbbbbbbb"], ["aaaaaaaaaaab"] }
            };

            yield return new object[]
            {
                new string[] { "ddddddddddg", "dgggggggggg" },
                new string[][] { ["ddddddddddg"], ["dgggggggggg"] }
            };

            yield return new object[]
            {
                new string[] { "eat", "eat", "tea" },
                new string[][] { ["eat", "eat", "tea"] }
            };
        }

        private static string[] Normalize(IEnumerable<IEnumerable<string>> groups)
        {
            return [.. groups
                .Select(group => string.Join(
                    ",",
                    group.OrderBy(word => word, StringComparer.Ordinal)))
                .OrderBy(group => group, StringComparer.Ordinal)];
        }
    }
}
