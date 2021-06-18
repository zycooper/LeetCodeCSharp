/*
You are given the head of a singly linked-list. The list can be represented as:

L0 → L1 → … → Ln - 1 → Ln
Reorder the list to be on the following form:

L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …
You may not modify the values in the list's nodes. Only nodes themselves may be changed.
*/

 /********************************************************************************
 Solution Category: 
 Recursion
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-18 15:21
 *********************************************************************************
 Submission Result:
Runtime: 104 ms, faster than 73.97% of C# online submissions for Reorder List.
Memory Usage: 32.4 MB, less than 22.26% of C# online submissions for Reorder List.

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
    public void ReorderList(ListNode head) {
        if(head == null){ return ;}
        
        ReorderList(head.next, head);
       
    }
    public ListNode ReorderList(ListNode right,ListNode init)
    {
        /*
            eg. 0 -> 1 -> 2 -> 3 -> 4
            
            left  => 0 -> 1 -> 2
            right => 4 -> 3
        */
        
        //base case
        if(right == null)
        {
            return init;
        }
        
        //if right is not the last node, keep traversing
        ListNode left = ReorderList(right.next,init);
        
        //left was right.next, if previous right.next is null, then all node sorted
        if(left == null)
        {
            return null;
        }
        
        //becase the original right.next has been already pointed back
        right.next = null;
        
        //left and righr meets here, this means the nodelist has been sorted
        if(left == right || right == left.next)
        {
            return null;
        }
        
        //switch
        right.next = left.next;
        left.next = right;
        
        return right.next;
    }
}
