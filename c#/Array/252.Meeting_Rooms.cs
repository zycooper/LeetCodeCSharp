/*
Given an array of meeting time intervals where intervals[i] = [starti, endi], determine if a person could attend all meetings.

Example 1:
Input: intervals = [[0,30],[5,10],[15,20]]
Output: false

Example 2:
Input: intervals = [[7,10],[2,4]]
Output: true
 

Constraints:

0 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti < endi <= 106
*/
/********************************************************************************
Solution Category: 

*********************************************************************************
Time Range:
From: 
To: 
*********************************************************************************
Submission Result:

*********************************************************************************
Note: 

*********************************************************************************/
public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        //OrderBy(x => x[i])
        //ToArray()
        /*
        Runtime: 112 ms, faster than 32.23% of C# online submissions for Meeting Rooms.
Memory Usage: 28.1 MB, less than 7.85% of C# online submissions for Meeting Rooms.
        */
        if(intervals.Length ==0 || intervals == null)
        {
            return true;
        }
        //most important below
        intervals = intervals.OrderBy(x => x[0]).toArray();

        for(int i = 0; i< intervals.Length - 1;i++)
        {
            if(intervals[i][1] > intervals[i+1][0])
            {
                return false;
            }
        }

        return true;
    }
}