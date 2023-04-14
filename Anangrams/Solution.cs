namespace Anangrams
{
    public  class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();

            foreach (var s in strs)
            {
                var sorted = new string(s.OrderBy(c => c).ToArray());
                if (!dict.ContainsKey(sorted))
                    dict[sorted] = new List<string>();
                dict[sorted].Add(s);
            }

            return dict.Values.ToList();
        }
        static void Main(string[] args)
        {
            var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var solution = new Solution();
            var result = solution.GroupAnagrams(strs);
            Console.WriteLine(string.Join(", ", result.Select(l => $"[{string.Join(", ", l)}]")));
        }
    }
 }
