/* https://leetcode.com/problems/two-sum/description/ */

function twoSum(nums: number[], target: number): number[] {
    for (const num of nums){
      const i = nums.indexOf(num)
       const complementaryIndex = nums.findIndex((n, j) => (num + n === target && i !== j))

       if(complementaryIndex >= 0 ){
          return [i, complementaryIndex]
       }
    }

    return [];
};
