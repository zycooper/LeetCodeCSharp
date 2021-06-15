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
Dont' initial a listnode to null like ListNode node = null, use this ListNode node = new ListNode();
and get more familier about the head inside while
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
        //working version               
        ListNode newhead = new ListNode();
        newhead.next = head;
        
        ListNode prevNode = newhead;
        
        while(head != null && head.next != null)
        {
            ListNode leftNode = head;
            ListNode rightNode = head.next;
            //switch
            prevNode.next = rightNode;
            leftNode.next = rightNode.next;
            rightNode.next = leftNode;
            
            //move to next
            prevNode = leftNode;
            head = leftNode.next;
        }
        
        return newhead.next;
    }
}


public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if(head.next == null || head.next.next == null) return null;
        
        //prev left right next
        ListNode newhead = head.next;

        ListNode prevNode = new ListNode();
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