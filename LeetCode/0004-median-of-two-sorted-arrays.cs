/* https://leetcode.com/problems/median-of-two-sorted-arrays/description/ */

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        float output = 0;

        int mergedLength = nums1.Length + nums2.Length;
        int iterableLength = (int) Math.Floor((float)mergedLength / 2) + 1;
        bool isMergedLengthEven = mergedLength % 2 == 0;

        int p1 = 0;
        int p2 = 0;

        for(int i = 0; i < iterableLength; i++){
            int num = 0;
			
			if(p1 >= nums1.Length){
				num = nums2[p2];
                p2++;
			} else if (p2 >= nums2.Length){
				num = nums1[p1];
                p1++;
			} else if (nums1[p1] >= nums2[p2]){
				num = nums2[p2];
                p2++;
			} else {
				num = nums1[p1];
                p1++;
			}

         	if(i == iterableLength - 1 || (isMergedLengthEven && i == iterableLength - 2))
                output += num;
        }
        
        return !isMergedLengthEven ? output : output / 2;
    }
}