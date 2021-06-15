/*
Given the head of a singly linked list and two integers left and right where left <= right, 
reverse the nodes of the list from position left to position right, and return the reversed list.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-15 14:29
 To: 2021-06-15 15:34
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 66.79% of C# online submissions for Reverse Linked List II.
Memory Usage: 25 MB, less than 8.96% of C# online submissions for Reverse Linked List II.
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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        //create node before head
        ListNode dummy = new ListNode();
        dummy.next = head;
        
        //create prev node
        ListNode prev = dummy;        
        
        //locate the prev
        for(int i = 1; i < left; i++)
        {
            prev = prev.next;
        }
        
        //create cur node
        ListNode cur = prev.next;
        
        //switch
        for(int i = left; i < right; i++)
        {
            /*
            in the switch
            cur is always the same, just switch position
            nextNode changes every time
            !---prev.next---! is Key
            So
            Cur ->
            Next ->
            Prev ->
            */
            ListNode nextNode = cur.next;
            cur.next = nextNode.next;
            nextNode.next = prev.next;
            prev.next = nextNode;
        }
        
        //return the next of the node before original head
        return dummy.next;
    }
}