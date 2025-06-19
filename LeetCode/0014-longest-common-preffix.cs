/* https://leetcode.com/problems/longest-common-prefix/description/ */

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = "";

        int minStringLength = Int32.MaxValue;
        foreach(string s in strs) minStringLength = Math.Min(minStringLength, s.Length);

        for(int i = 0; i < minStringLength; i++){
            char c = strs[0][i]; 

            for(int j = 1; j < strs.Length; j++)
                if(c != strs[j][i]) 
                    return result;
            

            result += c;
        }

        return result;
    }
}