/*
Given the head of a linked list, rotate the list to the right by k places.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-20 14:57
 *********************************************************************************
 Submission Result:
Runtime: 96 ms, faster than 56.69% of C# online submissions for Rotate List.
Memory Usage: 25.9 MB, less than 53.50% of C# online submissions for Rotate List.
 *********************************************************************************
 Note: 
 create another listnode and assign the head to it, then use it as pointer, don't use original head
 becareful about the pointer and make sure where it is at
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
    public ListNode RotateRight(ListNode head, int k) {
        //pre consdition
        if(k ==0){ return head;}
        if(head == null || head.next == null){ return head; }
        //normal condition
        int Length = 1;
        ListNode old_tail = head;
       
        while(old_tail.next != null)
        {
            Length++;
            old_tail = old_tail.next;
            Console.WriteLine(Length);
        }
        //since the old_tail is already at the last one, just connect it to the old_head
        old_tail.next = head;
        
        int new_k = Length - k%Length - 1;
       
        ListNode new_tail = head;
        //
        
        for(int i = 0; i < new_k;i++)
        {
            new_tail = new_tail.next;
        }
        
        ListNode new_head = new_tail.next;
        new_tail.next = null;
        
        return new_head;
    }
}
