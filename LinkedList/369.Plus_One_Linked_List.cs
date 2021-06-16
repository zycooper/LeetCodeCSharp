/*
Given a non-negative integer represented as a linked list of digits, plus one to the integer.
The digits are stored such that the most significant digit is at the head of the list.

Example 1:
Input: head = [1,2,3]
Output: [1,2,4]

Example 2:
Input: head = [0]
Output: [1]
Constraints:
The number of nodes in the linked list is in the range [1, 100].
0 <= Node.val <= 9
The number represented by the linked list does not contain leading zeros except for the zero itself. 
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-17 15:00
 To: 2021-06-17 15:35
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 50.00% of C# online submissions for Plus One Linked List.
Memory Usage: 24.9 MB, less than 45.00% of C# online submissions for Plus One Linked List.
 *********************************************************************************
 Note: 
 the question is that a non-negative numbers store in a linked list, like 12345 => [1,2,3,4,5]
 then add one to this number. so 12345 + 1 = 12346 => [1,2,3,4,6]
 so the key is where the nine is.

 The solution is brilliant. You don't look for the 9, you look for the last number which is not 9, then add one to that number, then reset all the left 9 to zero.

 the edge case is [9,9,9,9] or some other all 9 number, so here the dummy comes
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
    public ListNode PlusOne(ListNode head) {
        
        ListNode dummy = new ListNode(0);        
        dummy.next = head;
        
        ListNode NoneNine = dummy;
        //find the right-most non-none digit
        while(head != null)
        {
            if(head.val != 9)
            {
                NoneNine = head;
            }
            
            head = head.next;
        }
        
        NoneNine.val++;
        
        while(NoneNine.next != null)
        {
            NoneNine.next.val = 0;
            NoneNine = NoneNine.next;
        }
        
        //dummy.next;
        return dummy.val == 0 ? dummy.next : dummy;
    }
}