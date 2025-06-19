/* https://leetcode.com/problems/integer-to-roman/description/ */

public class Solution {
    private enum PositionalValue {
        One, Five, Ten, Fifty, FiveHundred, Thousand, FiveThousand
    }
    private char[] Symbols = ['I', 'V', 'X', 'L', 'C', 'D', 'M', 'A'];


    public string IntToRoman(int num) {
        string roman = "";

        for(int i = 0; num !=0; i++){
            roman = GetRomanFromDigit(num%10, (PositionalValue) (i*2)) + roman; 
            num /= 10;
        }

        return roman;
    }

    private string GetRomanFromDigit(int digit, PositionalValue positionalValue){
        int positionValue = (int) positionalValue;

        if(digit == 9) 
            return "" + Symbols[positionValue] + Symbols[positionValue + 2];
        else if (digit == 4)
            return "" + Symbols[positionValue] + Symbols[positionValue + 1];
        else if (digit - 5 >= 0)
            return Symbols[positionValue + 1] + new string(Symbols[positionValue], digit % 5);
        else
            return new string(Symbols[positionValue], digit % 5);
    }
}