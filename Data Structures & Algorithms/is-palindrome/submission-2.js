class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s) {
        s = s.toLowerCase().replace(/[^a-z0-9]/g, '');

        var left = 0;
        var right = s.length-1;
        var result = true;

        while(left < right)
        {
            console.log(s[left],'=?=',s[right]);
            if(s[left]!=s[right])
            {
                result = false;
                break;
            }

            left++;
            right--;

        }
        return result;
    }
}
