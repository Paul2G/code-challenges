/* https://leetcode.com/problems/longest-substring-without-repeating-characters/description/ */

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        string result = "";
        string currentLongest = "";

        for(int i = 0; i < s.Length; i++){
            int indexOfChar = currentLongest.IndexOf(s[i]);

            if(indexOfChar >= 0){
                currentLongest = currentLongest
                .Substring(indexOfChar + 1, currentLongest.Length - indexOfChar - 1);
            } 
			
			currentLongest += s[i];

            if(currentLongest.Length > result.Length){
                result = string.Copy(currentLongest);
            }
        }

        return result.Length;
    }
}