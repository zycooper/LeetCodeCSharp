/*
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order, and each of their nodes contains a single digit. 
Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/

/********************************************************************************
Solution Category: 

*********************************************************************************
Time Range:
From: 
To: 2021-06-16 16:20
*********************************************************************************
Submission Result:
Runtime: 104 ms, faster than 79.24% of C# online submissions for Add Two Numbers.
Memory Usage: 28.6 MB, less than 9.19% of C# online submissions for Add Two Numbers.
*********************************************************************************
Note: 
be careful for the temp, after set to the carry, all the calculate is +=
always start with dummy and then return dummy.next;
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode dummy = new ListNode(0);
        ListNode cur = dummy;
        int carry = 0;
        while(l1 != null || l2 != null)
        {
            //be careful for the temp, after set to the carry, all the calculate is +=
            int temp = carry;
            if(l1 != null && l2 != null)
            {
                //both not null                
                temp += l1.val + l2.val;
                l1 = l1.next;
                l2 = l2.next;
            }
            else if(l1 == null && l2 != null)
            {
                //l1 ends
                temp += l2.val;
                l2 = l2.next;
            }
            else if(l1 != null && l2 == null)
            {
                //l2 ends
                temp += l1.val;
                l1 = l1.next;
            }
            
            carry = temp/10;            
            cur.next = new ListNode(temp%10);
            cur = cur.next;            
        }
        
        if(carry > 0)
        {
            cur.next = new ListNode(carry);
        }
        return dummy.next;
    }
}