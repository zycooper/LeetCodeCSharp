/*
Given a linked list, swap every two adjacent nodes and return its head. 
You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-10 15:32
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
    public ListNode SwapPairs(ListNode head) {
        if(head.next == null || head.next.next == null) return null;
        
        //prev left right next
        ListNode newhead = head.next;

        ListNode prevNode = null;
        ListNode leftNode = head;
        ListNode rightNode = head.next;
        
        while(leftNode != null && rightNode != null)
        {
            //switch           
            ListNode nextNode = rightNode.next;
            prevNode.next = rightNode;
            rightNode.next = leftNode;
            leftNode.next = nextNode;
            
            //move to next
            leftNode = leftNode.next;
            rightNode = leftNode.next.next;
        }
        
        return newhead;
    }
}