public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        for(var i = 0; i<strs.Length; i++)
        {
            var s = strs[i];
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            var sorted = new string(chars);

            if(map.Keys.Contains(sorted)) map[sorted].Add(strs[i]);
            else map[sorted] = new List<string>{strs[i]};
        }

        return map.Values.ToList();
    }
}
