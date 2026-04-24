class Solution {
    /**
     * @param {string} s
     * @return {number}
     */
    lengthOfLongestSubstring(s) {
        if(s.length == 0) return 0;
        let left = 0;
        let maxL = 0;
        var charSet = new Set();
        
        for(let r = 0; r < s.length; r++)
        {
            while (charSet.has(s[r])) {
                charSet.delete(s[left]);
                left++;
            }
            charSet.add(s[r]);
            maxL = Math.max(maxL, r - left + 1);
        }

        return maxL;
    }
}
