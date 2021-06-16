/*
Given the heads of two singly linked-lists headA and headB, 
return the node at which the two lists intersect. 
If the two linked lists have no intersection at all, return null.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-16 16:25
 To: 2021-06-17 16:33
 *********************************************************************************
 Submission Result:
Runtime: 136 ms, faster than 54.37% of C# online submissions for Intersection of Two Linked Lists.
Memory Usage: 38.7 MB, less than 21.89% of C# online submissions for Intersection of Two Linked Lists.
 *********************************************************************************
 Note: 
use HashSet instead of dictionary
 *********************************************************************************/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        HashSet<ListNode> hash_b = new HashSet<ListNode>();
        
        while(headB != null)
        {
            hash_b.Add(headB);
            headB = headB.next;
        }
        
        while(headA != null)
        {
            if(hash_b.Contains(headA))
            {
                return headA;
            }
            
            headA = headA.next;
        }
        
        return null;
    }
}