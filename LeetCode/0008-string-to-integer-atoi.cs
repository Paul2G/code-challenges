/* https://leetcode.com/problems/string-to-integer-atoi/description/ */

public class Solution {
    public int MyAtoi(string s) {
        int result = 0;
        int numberStart = -1;
        int numberEnd = s.Length - 1;
        int sign = 1;
        
        for(int i = 0; i < s.Length; i++){
            if(numberStart < 0){
                if(s[i] == '-') {
                    numberStart = i + 1;
                    sign = -1;
                } else if (s[i] == '+')
                    numberStart = i + 1;
                else if (s[i] == ' ')
                    continue;
                else if(s[i] < '0' || s[i] > '9')
                    return 0;
                else 
                    numberStart = i;
            } else if(s[i] < '0' || s[i] > '9'){
                numberEnd = i - 1;
                break;
            }
        }
        if(numberStart < 0) return 0;

        for(int i = numberStart; i <= numberEnd; i++) {
            int pop = (s[i] - '0');
            long adding = (long)pop * (long)Math.Pow(10, numberEnd - i);

            if(pop == 0) continue;

            if(((ulong)result + (ulong)adding) > Int32.MaxValue ){
                if(sign == 1) return Int32.MaxValue;
                else return Int32.MinValue;
            }
            
            result += (int) adding;
        }

        return result * sign;
    }
}