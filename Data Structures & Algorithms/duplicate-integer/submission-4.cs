public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set2 = nums.Distinct().ToHashSet();
        if(nums.Length != set2.Count)
            return true;
        else
            return false;
    }
}