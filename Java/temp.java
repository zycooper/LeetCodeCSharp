class Solution {
    public String minWindow(String str, String pattern) {
        //pre condition
        if(str.length() < pattern.length() || str.length() == 0)
        {
            return "";
        }
        //normal condition
        int left_cursor = 0;
        Map<Character, Integer> charFrequencyMap = new HashMap();
        String res = "";
        int match = 0;

        //fill frequency map
        for(int i = 0; i < pattern.length(); i++)
        {
            char charCurrent = pattern.charAt(i);
            charFrequencyMap.put(charCurrent, charFrequencyMap.getOrDefault(charCurrent, 0) + 1);
        }

        //form window sliding
        for(int right_cursor = 0; right_cursor < str.length(); right_cursor++)
        {
            //check right cursor one exist in map
            char charAtRightCursor = str.charAt(right_cursor);
            if(charFrequencyMap.containsKey(charAtRightCursor))
            {
                charFrequencyMap.put(charAtRightCursor, charFrequencyMap.get(charAtRightCursor) - 1);

                if(charFrequencyMap.get(charAtRightCursor) == 0)
                {
                    match++;
                }
            }

            //check if current window is valid
            if(match == charFrequencyMap.size())
            {
                if(res.length() > right_cursor - left_cursor + 1 || res == "")
                {
                     res = str.substring(left_cursor, right_cursor + 1);
                }

                //move left cursor
                while(match == charFrequencyMap.size())
                {
                    char charAtLeftCursor = str.charAt(left_cursor++);

                    if(charFrequencyMap.containsKey(charAtLeftCursor))
                    {
                        if(charFrequencyMap.get(charAtRightCursor) == 0)
                        {
                            match--;
                        }

                        charFrequencyMap.put(charAtLeftCursor, charFrequencyMap.get(charAtLeftCursor) + 1);
                    }
                }
            }
        }

        return res;//"ADOBECODEBANC".substring(11,12);//
    }
}


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode reverseBetween(ListNode head, int p, int q) {
        //pre condition
        if(p == q || head == null || head.next == null)
        {
            return head;
        }

        //normal condition
        ListNode pre = null;
        ListNode cur = head;
        ListNode next = null;

        ListNode lastNodeOfFirstPart = null;
        ListNode firstNodeOfSecondPart = null;
        //anchor to the p position
        for(int i = 0; cur != null && i < p - 1){}

        //re connect three parts
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode reverseKGroup(ListNode head, int k) {
        //pre condition
        if(head == null || head.next == null || k <= 1)
        {
            return head;
        }
        //normal condition
        //declare nodes
        ListNode pre =null;
        ListNode cur = head;
        ListNode next = null;

        ListNode LastBeforeCur = null;
        ListNode LastInCur = null;
        boolean set_new_head = false;

        ListNode newhead = null;
        //while loop
        while(true)
        {
            LastBeforeCur = pre;
            LastInCur = cur;

            for(int i = 0; cur != null && i < k; i++)
            {
                next = cur.next;
                cur.next = pre;

                //re-assign
                pre = cur;
                cur = next;
            }

            /*
            //set new head
            if(!set_new_head)
            {
                set_new_head = true;
                newhead = pre;
            }

            if(pre != null)
            {
                LastBeforeCur.next = pre;
            }
            */
            if(LastBeforeCur != null)
            {
                LastBeforeCur.next = pre;
            }
            else
            {
                head = previous;
            }

            LastInCur.next = cur;

            //jump out of while
            if(cur == null)
            {
                break;
            }

            pre = LastInCur;
        }
        return head;
    }
}

