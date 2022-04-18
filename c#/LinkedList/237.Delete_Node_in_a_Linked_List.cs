/*
Write a function to delete a node in a singly-linked list. 
You will not be given access to the head of the list, instead you will be given access to the node to be deleted directly.
It is guaranteed that the node to be deleted is not a tail node in the list.
*/

 /********************************************************************************
 Solution Category: 0
 *********************************************************************************
 Time Range:
 From: 2021-06-15 16:34
 To: 2021-06-15 16:35
 *********************************************************************************
 Submission Result:
Runtime: 100 ms, faster than 34.93% of C# online submissions for Delete Node in a Linked List.
Memory Usage: 26.1 MB, less than 12.11% of C# online submissions for Delete Node in a Linked List.
 *********************************************************************************
 Note: 
well, not actually delete it, just copy the next val to it and connect it to the next of next, so basically delete the next
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
    public void DeleteNode(ListNode node) {
        //pre condition
        if(node == null){ return;}
        
        //normal condition
        node.val = node.next.val;
        node.next = node.next.next;
    }
}