/* https://leetcode.com/problems/add-two-numbers/description/ */

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new ListNode(); 
        ListNode resultCursor = result;
        int carry = 0;

        List<int> list1 = l1.ListNodeToList();
        List<int> list2 = l2.ListNodeToList();


        int maxListLength = Math.Max(list1.Count, list2.Count);
        for(int i = 0; i < maxListLength; i++){
            double sum = 
                (list1.Count > i ? list1[i] : 0) +
                (list2.Count > i ? list2[i] : 0) +
                carry;

            resultCursor.val = (int) sum % 10;
            carry = (int) Math.Floor(sum / 10);

            if(i != maxListLength - 1 || carry != 0){
                resultCursor.next = new ListNode(carry);
                resultCursor = resultCursor.next;
            }
        }

        return result;
    }
}

public static class Mapper {
    public static List<int> ListNodeToList(this ListNode listNode){
        List<int> result = [];
        ListNode cursor = listNode;
        
        while(cursor != null){
            result.Add(cursor.val);
            cursor = cursor.next;
        }

        return result;
    }
}