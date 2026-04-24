public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>();
        // var set = new HashMap<int, int>();
        foreach(int i in nums)
        {
            if(set.Contains(i))
                return true;
            set.Add(i);
        }
        return false;
    }
}