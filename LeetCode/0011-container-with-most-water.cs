/* https://leetcode.com/problems/container-with-most-water/description/ */

public class Solution {
    public int MaxArea(int[] height) {
        int maxContain = 0;
        int start = 0;
        int end = height.Length - 1;

        while(start != end){
            int contain = Math.Min(height[start], height[end]) * (end - start);
            if(contain > maxContain) maxContain = contain;

            if(height[start] > height[end]) end--;
            else start++;
        }

        return maxContain;
    }
}