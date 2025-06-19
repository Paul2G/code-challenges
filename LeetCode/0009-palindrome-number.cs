/* https://leetcode.com/problems/palindrome-number/description/ */

public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        if(x < 10) return true;

        int log10 = (int) Math.Floor(Math.Log(x, 10));
        int halfOfDigits = (int) Math.Floor((double)(log10 / 2)) + 1;

        for(int i = 0; i < halfOfDigits; i++){
            int first = (int) Math.Floor(x / Math.Pow(10, log10 - i)) % 10;
            int last = (int) Math.Floor(x / Math.Pow(10, i)) % 10;

            if(first != last) return false;
        }

        return true;
    }
}