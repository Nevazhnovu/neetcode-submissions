class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s) {
        s = s.toLowerCase()
        .replaceAll(' ', '')
        .replaceAll('!', '')
        .replaceAll(',', '')
        .replaceAll('.', '')
        .replaceAll('\\', '')
        .replaceAll('/', '')
        .replaceAll(';', '')
        .replaceAll('|', '')
        .replaceAll('?', '');
        console.log(s, '==', s.length);

        var left = 0;
        var right = s.length-1;
        var result = false;

        while(left!=right)
        {
            console.log(s[left],'=?=',s[right]);
            if(s[left]!=s[right])
            {
                result = false;
                break;
            }

            left++;
            right--;
            result = true;
        }
        return result;
    }
}
