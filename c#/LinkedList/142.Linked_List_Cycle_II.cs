/*
Given a linked list, return the node where the cycle begins. If there is no cycle, return null.
There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
Notice that you should not modify the linked list.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-18 15:24
 To: 2021-06-18 15:29
 *********************************************************************************
 Submission Result:
Runtime: 100 ms, faster than 56.14% of C# online submissions for Linked List Cycle II.
Memory Usage: 27.6 MB, less than 15.79% of C# online submissions for Linked List Cycle II.
 *********************************************************************************
 Note: 
basically the same with other questions 141.
Use HashSet instead of Dictionary
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
    public ListNode DetectCycle(ListNode head) {
        if(head == null || head.next == null)
        {
            return null;
        }
        
        HashSet<ListNode> dict = new HashSet<ListNode>();
        
        while(head != null)
        {
            if(dict.Contains(head))
            {
                return head;
            }
            else
            {
                dict.Add(head);
                head = head.next;
            }
        }
        
        return null;
    }
}
