/* https://leetcode.com/problems/reverse-integer/description/ */

public class Solution {
    public int Reverse(int x) {
        int reverse = 0;
        int tempReverse = 0;

        while(x != 0){
            int digit = x % 10;

            tempReverse = reverse * 10 + digit;
            if(reverse != (tempReverse - digit) / 10) return 0;

            reverse = tempReverse;
            x /= 10;
        }

        return reverse;
    }
}