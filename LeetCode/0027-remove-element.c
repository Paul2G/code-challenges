/* https://leetcode.com/problems/remove-element/description/ */

void swap(int* n1, int* n2);

int removeElement(int* nums, int numsSize, int val) {
    int left = 0, right = numsSize - 1;
    
    while(left <= right){
        if(nums[right] == val){
            right--;
            continue;
        }

        if(nums[left] == val){
            swap(&(nums[left]), &(nums[right]));
            right--;
        }

        left++;
    }

    return right + 1;
}

void swap(int* n1, int* n2){
    int temp = 0;
    temp = *n1;
    *n1 = *n2;
    *n2 = temp;
}