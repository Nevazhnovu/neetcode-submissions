class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number}
     */
    search(nums, target) 
    {
        // runs in O(log n) time?
        var l = 0;
        var r = nums.length;
        while(l<=r)
        {
            var mid = (l+r)/2;
            if(target == nums[mid])
                return mid;
            console.log(mid)

            // left sorted portion
            if(nums[l]<=nums[mid])
            {
               if(target>nums[mid] || target < nums[l])
                    l = mid +1; 
                else
                    r = mid - 1;
            }else{
            // right sorted portion
            if(target < nums[mid] || target > nums[r])        
                r = mid - 1;
            l = mid + 1;
            }
        }
        return -1;
    }
}
