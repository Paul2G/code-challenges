/* https://leetcode.com/problems/integer-to-english-words/description/ */

public class Solution {
    private string[] englishNumbers = [null, "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];
    private string[] englishTens = [null, null, "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];
    private string[] englishMultipliers = [null, "Thousand", "Million", "Billion"];


    public string NumberToWords(int num) {
        if(num == 0) return "Zero";

        string[] words = [];
        
        for(int i = 0; num != 0; i++){
            if(num % 1000 != 0)
                words = [..ThousandOrLessToWords(num % 1000), englishMultipliers[i], ..words];
            
            num /= 1000;
        }

        return String.Join(" ", Array.FindAll(words, w => w != null));
    }

    public string[] ThousandOrLessToWords(int num){
        string[] words = [];

        if(num % 100 < 20) {
            words = [englishNumbers[num % 100]];
        } else {
            words = [englishTens[(num / 10) % 10], englishNumbers[num % 10]];
        }

        if(num >= 100) {
            words = [englishNumbers[num / 100], "Hundred", ..words];
        }

        return words;
    }
}