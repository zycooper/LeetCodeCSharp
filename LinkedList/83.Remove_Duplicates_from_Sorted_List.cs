/*

*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-15 16:40
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 82.28% of C# online submissions for Remove Duplicates from Sorted List.
Memory Usage: 26.7 MB, less than 29.29% of C# online submissions for Remove Duplicates from Sorted List.
 *********************************************************************************
 Note: 
make sure create a cur node. And if equal, delete next(but not keep going to the next), otherwise keep going
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
        //pre condition
        if(head == null){ return head;}
        
        //normal condition
        ListNode cur = head;
        while(cur.next != null)
        {
            if(cur.val == cur.next.val)
            {
                cur.next = cur.next.next;
            }
            else
            {
                cur = cur.next;
            }
        }
        
        return head;
    }
}