public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        var result = new int[k];
        for (int i = 0; i < nums.Length; i++) {
            if (map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map[nums[i]] = 1;
        }
        for (int i = 0; i < k; i++) {
            int max = map.Values.Max(a => a);
            int maxIndex = map.Values.ToList().IndexOf(max);
            int maxKey = map.Keys.ToList()[maxIndex];
            Console.WriteLine(maxKey);
            result[i] = maxKey;
            map[maxKey] = -1;
        }

        return result;
    }
}
