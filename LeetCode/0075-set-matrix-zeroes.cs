/* https://leetcode.com/problems/set-matrix-zeroes/description/ */

public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> mAxis = new HashSet<int>();
        HashSet<int> nAxis = new HashSet<int>();

        for(int m = 0; m < matrix.Length; m ++){
            for(int n = 0; n < matrix[m].Length; n ++){
                if(matrix[m][n] == 0) {
                    mAxis.Add(m);
                    nAxis.Add(n);
                }
            }
        }

        foreach(int m in mAxis){
            for(int n = 0; n < matrix[m].Length; n++){
                matrix[m][n] = 0;
            }
        }

        foreach(int n in nAxis){
            for(int m = 0; m < matrix.Length; m++){
                matrix[m][n] = 0;
            }
        }
    }
}