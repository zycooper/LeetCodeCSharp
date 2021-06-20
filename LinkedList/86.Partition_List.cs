/*

*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-06-20 15:22
 *********************************************************************************
 Submission Result:
Runtime: 88 ms, faster than 89.63% of C# online submissions for Partition List.
Memory Usage: 25.4 MB, less than 69.51% of C# online submissions for Partition List.
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
    public ListNode Partition(ListNode head, int x) {
        
        //initial two seperate linked list
        ListNode less_head = new ListNode(0);
        ListNode not_less_head = new ListNode(0);
        
        ListNode cur_less = less_head;
        ListNode cur_not_less = not_less_head;
        
        while(head != null)
        {
            if(head.val < x)
            {
                //goes to less
                cur_less.next = head;
                cur_less = cur_less.next;   
            }
            else
            {
                //goes to not less
                cur_not_less.next = head;
                cur_not_less = cur_not_less.next;
            }
            
            head = head.next;
        }
        
        cur_not_less.next = null;
        cur_less.next = not_less_head.next;
        
        return less_head.next;
    }
}
