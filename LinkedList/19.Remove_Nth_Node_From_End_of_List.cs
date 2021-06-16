/*
Given the head of a linked list, remove the nth node from the end of the list and return its head.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-16 16:50
 To: 2021-06-16 14:25
 *********************************************************************************
 Submission Result:
Runtime: 80 ms, faster than 99.30% of C# online submissions for Remove Nth Node From End of List.
Memory Usage: 25.5 MB, less than 24.25% of C# online submissions for Remove Nth Node From End of List.
 *********************************************************************************
 Note: 
very important to create dummy and set dummy.next = head;
then start with dummy since the result may be null
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
    //working version
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //get length
        int length = 0;
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode cur = head;
        while(cur != null)
        {
            length++;
            cur = cur.next;
        }
        
        length = length - n;
        //this is very important to include the result null
        cur = dummy;
        while(length > 0)
        {
            length--;
            cur = cur.next;
        }
        cur.next = cur.next.next;
        
        return dummy.next;
    }
}
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //not work on [1] 1
        //get length
        int length = 0;
        ListNode cur = head;
        while(cur != null)
        {
            length++;
            cur = cur.next;
        }
        
        ListNode dummy = new ListNode();
        dummy.next = head;
        //actual position
        int target = length - n;
        Console.WriteLine(target);
        cur = head;
        for(int i = 0; i < target;i++)
        {
            if(i == target - 1 || target < 0)
            {
                Console.WriteLine(cur.val);
                cur.next = cur.next.next;
            }
            cur = cur.next;
        }
        
        return dummy.next;
    }
}
