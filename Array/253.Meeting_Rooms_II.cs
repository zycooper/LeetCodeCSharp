/*
Given an array of meeting time intervals intervals where intervals[i] = [starti, endi], return the minimum number of conference rooms required.

Example 1:
Input: intervals = [[0,30],[5,10],[15,20]]
Output: 2

Example 2:
Input: intervals = [[7,10],[2,4]]
Output: 1

Constraints:

1 <= intervals.length <= 104
0 <= starti < endi <= 106
*/

public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        //doesn't work below, just write it out but didn't even run it
        int result = 0;

        if(intervals.Length == 0 || intervals == null)
        {
            return result;
        }

        intervals = intervals.OrderBy(x => x[0]).ToArray();

        for(int i = 0; i < intervals.Length - 1; i++)
        {
            if(intervals[i][1] > intervals[i + 1][0])
            {
                result++;
            }
        }

        return result;
    }

     public int MinMeetingRooms_1(int[][] intervals) 
     {

     }
}