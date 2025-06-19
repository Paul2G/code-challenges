/* https://leetcode.com/problems/longest-palindromic-substring/description/ */

public class Solution {
    public string LongestPalindrome(string s) {
        for (int i = 0; i < s.Length; i++){
			int currentLength = s.Length - i;
			
			for(int j = 0; j + currentLength <= s.Length; j++){
				string substring = s.Substring(j, currentLength);
				
				if(IsPalindrome(substring)) return substring;
			}
		}

        return "";
    }

    private bool IsPalindrome(string s){
        if(s.Length <= 1) return true;

        for(int i = 0; i <= s.Length - i - 1; i++){
            if(s[i] != s[s.Length - i - 1]) return false;
        }
        return true;
    }
}