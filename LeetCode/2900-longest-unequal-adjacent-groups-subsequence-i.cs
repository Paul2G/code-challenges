/* https://leetcode.com/problems/longest-unequal-adjacent-groups-subsequence-i/description/ */

public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        List<string> result = new List<string>();

        for(int i = 0; i < words.Length; i++){
            if(i == 0)
                result.Add(words[i]);
            else if(groups[i] != groups[i - 1]) {
                result.Add(words[i]);
            }
        }

        return result;
    }
}