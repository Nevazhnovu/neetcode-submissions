public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int,int>();
        foreach(int i in nums)
        {
            set.Add(i);

        }
        return false;
    }
}