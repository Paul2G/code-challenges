/* https://leetcode.com/problems/maximum-difference-between-increasing-elements/description/ */

public class Solution {
    public int MaximumDifference(int[] nums) {
        int maxDifference = -1;

        for(int i = 0; i < nums.Length; i++){
            for(int j = i; j < nums.Length; j++){
                if(nums[j] > nums[i])
                    maxDifference = Math.Max(maxDifference, nums[j] - nums[i]);
            }
        }

        return maxDifference;
    }
}