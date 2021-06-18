/*
Given the head of a singly linked list, return true if it is a palindrome.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-16 16:46
 To: 2021-06-18 12:36
 *********************************************************************************
 Submission Result:
Runtime: 284 ms, faster than 38.69% of C# online submissions for Palindrome Linked List.
Memory Usage: 51.9 MB, less than 11.62% of C# online submissions for Palindrome Linked List.
 *********************************************************************************
 Note: 
 
 1. turn into array
 2. recursion
 3. create another linked list and reverse it, compare with the original one
 
 I copied the official solution, recursion way. no hard to duplicate but impossible for me to come out of this solution all by my self
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
    private ListNode firstPointer;
    public bool IsPalindrome(ListNode head) {
        firstPointer = head;
        
        return recursiveCheck(firstPointer);
    }
    
    private bool recursiveCheck(ListNode cur)
    {
        if(cur != null)
        {
            if(!recursiveCheck(cur.next)) return false;
            if(cur.val != firstPointer.val) return false;
            
            firstPointer = firstPointer.next;
        }
        
        return true;
    }
}
