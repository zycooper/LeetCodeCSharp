/*
Given the head of a singly linked list, reverse the list, and return the reversed list.
*/

 /********************************************************************************
 Solution Category: 
 Recursion | Iterative
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-10 14:48
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 70.61% of C# online submissions for Reverse Linked List.
Memory Usage: 25 MB, less than 79.27% of C# online submissions for Reverse Linked List.
 *********************************************************************************
 Note: 

 *********************************************************************************/
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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;;
        //initial
        ListNode cur = head;
        
        while(cur != null)
        {
            ListNode temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        }
        
        return prev;
    }
}