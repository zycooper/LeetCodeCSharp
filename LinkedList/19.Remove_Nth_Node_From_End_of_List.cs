/*
Given the head of a linked list, remove the nth node from the end of the list and return its head.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-16 16:50
 To: 
 *********************************************************************************
 Submission Result:

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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //get length
        int length = 0;
        ListNode cur = head;
        while(cur != null)
        {
            length++;
            cur = cur.next;
        }
        
        ListNode dummy = new ListNode();
        dummy.next = head;
        //actual position
        int target = length - n + 1;
        cur = head;
        for(int i = 0; i < target;i++)
        {
            cur = cur.next;
            if(i == target -1)
            {
                cur.next = cur.next.next;
            }
        }
        
        return dummy.next;
    }
}