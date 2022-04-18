/*
Given an array of intervals where intervals[i] = [starti, endi], 
merge all overlapping intervals, 
and return an array of the non-overlapping intervals that cover all the intervals in the input.

Example 1:
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].

Example 2:
Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.

Constraints:
1 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti <= endi <= 104
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
    public int[][] Merge(int[][] intervals) {
        /*
        Runtime: 264 ms, faster than 38.70% of C# online submissions for Merge Intervals.
        Memory Usage: 33.8 MB, less than 92.90% of C# online submissions for Merge Intervals.

        Note: Array sort: Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
        since use sort so it's not fast
        */
        //sort original array
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        List<int[]> Result = new List<int[]>();

        int[] temp_interval = intervals[0];

        for(int i = 1; i < intervals.Length; i++)
        {
            //because we are always comparing the temp_interval to next i(since i starts from 1), so the last one won't be added(the temp_interval is the actual i, and for the last one, temp_interval just be assigned to intervals[i])
            if(temp_interval[1] < intervals[i][0])
            {
                //no overlap with next
                Result.Add(temp_interval);
                temp_interval = intervals[i];
            }
            else
            {
                //overlap occurs, keep updating the intervals till no over lap happens again
                //build up the temp interval
                temp_interval = new int[2]
                {
                    Math.Min(temp_interval[0],intervals[i][0]), 
                    Math.Max(temp_interval[1],intervals[i][1])
                };
            }
        }

        Result.Add(temp_interval);

        return Result.ToArray();
    }
}