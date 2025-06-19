/* https://leetcode.com/problems/roman-to-integer/description/ */

public class Solution {
    public int RomanToInt(string s) {
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            char prevChar = i != 0 ? s[i-1] : 'O';
            switch(s[i]) {
                case 'I':
                    result += 1;
                break;
                case 'V':
                    result += prevChar == 'I' ? 3 : 5;
                break;
                case 'X':
                    result += prevChar == 'I' ? 8 : 10;
                break;
                case 'L':
                    result += prevChar == 'X' ? 30 : 50;
                break;
                case 'C':
                    result += prevChar == 'X' ? 80 : 100;
                break;
                case 'D':
                    result += prevChar == 'C' ? 300 : 500;
                break;
                case 'M':
                    result += prevChar == 'C' ? 800 : 1000;
                break;
            }
        }

        return result;
    }
}