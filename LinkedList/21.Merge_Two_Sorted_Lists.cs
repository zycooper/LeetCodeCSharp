/*
Merge two sorted linked lists and return it as a sorted list. 
The list should be made by splicing together the nodes of the first two lists.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-16 16:37
 To: 2021-06-16 16:44
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 76.59% of C# online submissions for Merge Two Sorted Lists.
Memory Usage: 26.3 MB, less than 81.34% of C# online submissions for Merge Two Sorted Lists.
 *********************************************************************************
 Note: 
wrote one time by self and pass, but may need more improvement.
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode cur = dummy;
        while(l1 != null || l2 != null)
        {
            if(l1 != null && l2 != null)
            {
                //both not null
                if(l1.val > l2.val)
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
            }
            else if(l1 != null && l2 == null)
            {
                //l1 not null
                cur.next = l1;
                l1 = l1.next;
            }
            else if(l1 == null && l2 != null)
            {
                //l2 not null
                cur.next = l2;
                l2 = l2.next;
            }
            
            cur = cur.next;
        }
        
        return dummy.next;
    }
}