/* https://leetcode.com/problems/maximum-difference-between-adjacent-elements-in-a-circular-array/description/ */

public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int result = Math.Abs(nums[0] - nums[nums.Length - 1]);
  
        for(int i = 1; i < nums.Length; i++){
            result = Math.Max(result,  Math.Abs(nums[i] - nums[i - 1]));
        }

        return result;
    }
}
