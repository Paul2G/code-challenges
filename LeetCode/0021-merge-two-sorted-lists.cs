/* https://leetcode.com/problems/merge-two-sorted-lists/description/ */

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode result = new ListNode();
        ListNode sortedList = result;
        ListNode nextl1 = list1;
        ListNode nextl2 = list2;

        while(nextl1 != null || nextl2 != null){
            if(nextl1 == null) {
                sortedList.next = new ListNode(nextl2.val);
                nextl2 = nextl2.next;   
            } else if (nextl2 == null) {
                sortedList.next = new ListNode(nextl1.val);
                nextl1 = nextl1.next;
            } else if(nextl1.val < nextl2.val){
                sortedList.next = new ListNode(nextl1.val);
                nextl1 = nextl1.next;
            } else { 
                sortedList.next = new ListNode(nextl2.val);
                nextl2 = nextl2.next;
            }
            sortedList = sortedList.next;
        }

        return result.next;
    }
}