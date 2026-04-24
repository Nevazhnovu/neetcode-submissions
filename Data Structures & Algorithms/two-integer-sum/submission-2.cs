public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        foreach(var n in nums)
        {
            var res=target-n;
            if(map.ContainsKey(n)) return [map[n], Array.LastIndexOf(nums, n)];
            else map[res]=Array.IndexOf(nums, n);
        }

        return[0]; //Shouldn't reach here as only one valid answer exists.
    }
}
