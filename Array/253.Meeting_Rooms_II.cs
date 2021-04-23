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

        //not back
        return result;
    }

     public int MinMeetingRooms_1(int[][] intervals) 
     {
        //Priority Queues or mean heap
        //[[1,2],[2,3],[3,4],[4,5],[5,6]]
            
     }  

      public int MinMeetingRooms_2(int[][] intervals) 
     {
         /*
         Runtime: 96 ms, faster than 98.75% of C# online submissions for Meeting Rooms II.
         Memory Usage: 27.7 MB, less than 75.70% of C# online submissions for Meeting Rooms II.
         */
        //sort
        //[[1,2],[2,3],[3,4],[4,5],[5,6]]

        //define start and end point array
        int[] Start = new int[intervals.Length];
        int[] End = new int[intervals.Length];

        //assign values to start and end point array        
        for(int i =0; i < intervals.Length; i++)
        {
            Start[i] = intervals[i][0];
            End[i] = intervals[i][1];
        }

        //sort start and end point array
        Array.Sort(Start);
        Array.Sort(End);

        int MeetingRoomNum = 0;

        for(int i =0, j=0; i < Start.Length;i++)
        {
            if(Start[i] < End[j])
            {
                MeetingRoomNum++;
            }
            else
            {
                j++;
            }
        }

        return MeetingRoomNum;
     }  
}