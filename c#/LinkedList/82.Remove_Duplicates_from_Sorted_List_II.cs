/*
Given the head of a sorted linked list, delete all nodes that have duplicate numbers,
leaving only distinct numbers from the original list. Return the linked list sorted as well.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-17 14:35
 To: 2021-06-17 14:50
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 84.29% of C# online submissions for Remove Duplicates from Sorted List II.
Memory Usage: 26.6 MB, less than 9.42% of C# online submissions for Remove Duplicates from Sorted List II.
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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode left = dummy;
        ListNode right = head;
                
        while(right != null)
        {                       
            if(right.next != null && right.val == right.next.val)
            {
                //if duplicate appears, keep moving right cursor, stop left one, make sure the left one stays at the one before duplicate one
                
                while(right.next != null && right.val == right.next.val)
                {
                    //before move left cursor, keep moving right cursor to the last duplicate one, then set left.next = right.next;
                    right = right.next;
                }
                
                //now left stops at the one before duplicate, and the right one stops at the last duplicate
                left.next = right.next;
            }
            else
            {
                //keep moving left cursor
                left = left.next;
            }
            
            right = right.next;
        }
        
        return dummy.next;
    }
}