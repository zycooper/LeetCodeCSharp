/*
Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-10 15:22
 *********************************************************************************
 Submission Result:
Runtime: 692 ms, faster than 5.04% of C# online submissions for Linked List Cycle.
Memory Usage: 28 MB, less than 23.94% of C# online submissions for Linked List Cycle.
 *********************************************************************************
 Note: 

 *********************************************************************************/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {        
        List<ListNode> dict = new List<ListNode>();
        
        while(head != null)
        {
            if(dict.Contains(head))
            {
                return true;
            }
            else
            {
                dict.Add(head);
                
                head = head.next;
            }
        }
        
        return false;
    }
}