/*
Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-15 16:48
 *********************************************************************************
 Submission Result:
Runtime: 108 ms, faster than 24.37% of C# online submissions for Remove Linked List Elements.
Memory Usage: 28.5 MB, less than 81.14% of C# online submissions for Remove Linked List Elements.
 *********************************************************************************
 Note: 
keep your eyes on the case [1,1,1,1] and 1
you will need to create a dummy then  return dummy.next since the result maybe null
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
    public ListNode RemoveElements(ListNode head, int val) {
        //normal condition
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode cur = dummy;
        while(cur != null && cur.next != null)
        {
            if(cur.next.val == val)
            {
                cur.next = cur.next.next;
            }
            else
            {
                cur = cur.next;
            }
        }
        
        return dummy.next;
    }
}