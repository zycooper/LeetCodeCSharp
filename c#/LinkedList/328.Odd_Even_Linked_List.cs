/*
Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.

The first node is considered odd, and the second node is even, and so on.

Note that the relative order inside both the even and odd groups should remain as it was in the input.

You must solve the problem in O(1) extra space complexity and O(n) time complexity.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-15 15:58
 To: 2021-06-15 16:28
 *********************************************************************************
 Submission Result:
    Runtime: 100 ms, faster than 40.48% of C# online submissions for Odd Even Linked List.
    Memory Usage: 26.2 MB, less than 49.40% of C# online submissions for Odd Even Linked List.
 *********************************************************************************
 Note: 
make sure it's even != null && even.next != null
NOT odd
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
    public ListNode OddEvenList(ListNode head) {
        //pre condition
        if(head == null){ return head;}
        //normal condition
        ListNode odd = head;
        ListNode even = head.next;
        ListNode evenhead = head.next;
        
        while(even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }
        
        odd.next = evenhead;
        
        return head;
    }
}