public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var map = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if(map.ContainsKey(c))
                map[c] += 1;
            else map[c] = 1;
        }
        foreach(char c in t)
        {
            if(map.ContainsKey(c))
                map[c] -= 1;
            else map[c] = -1;
        }

        foreach(var kv in map)
        {
            if(kv.Value != 0) return false;
        }

        return true;
    }
}
