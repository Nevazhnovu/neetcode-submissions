public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) Console.Write($" {nums[i]} ");
        Console.Write($"\n");

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0)
                break;
            var j = i + 1;
            var k = nums.Length - 1;

            while (j < k) {
                var sum = nums[i] + nums[j] + nums[k];
                if (sum < 0)
                    j++;
                if (sum > 0)
                    k--;
                if (sum == 0) {
                    var entry = new List<int> { nums[i], nums[j], nums[k] };
                    if(result.Count==0)
                        result.Add(entry);
                    else if(
                        // result.Last()[0] != entry[0] ||
                        // result.Last()[1] != entry[1] ||
                        // result.Last()[2] != entry[2] 
                        result.Any(l => l[0] == entry[0] && l[1] == entry[1] && l[2] == entry[2] )
                        ){}
                    else
                        result.Add(entry);
                    // if (i==0)
                        // result.Add(entry);
                    // else if (nums[i] != nums[i - 1])
                        // result.Add(entry);
                    j++;
                    k--;
                }
            }
        }
        return result;
    }
}
