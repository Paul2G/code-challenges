/* https://leetcode.com/problems/search-insert-position/description/ */

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++){
            if(target <= nums[i]) return i;
        }

        return nums.Length;
    }
}