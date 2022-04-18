/*
Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
You may assume that the intervals were initially sorted according to their start times.

tab 

Example 1:
Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]

Example 2:
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].

Example 3:
Input: intervals = [], newInterval = [5,7]
Output: [[5,7]]

Example 4:
Input: intervals = [[1,5]], newInterval = [2,3]
Output: [[1,5]]

Example 5:
Input: intervals = [[1,5]], newInterval = [2,7]
Output: [[1,7]]

Constraints:
0 <= intervals.length <= 104
intervals[i].length == 2
0 <= intervals[i][0] <= intervals[i][1] <= 105
intervals is sorted by intervals[i][0] in ascending order.
newInterval.length == 2
0 <= newInterval[0] <= newInterval[1] <= 105
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

/*
Greedy problems usually look like "Find minimum number of something to do something" or "Find maximum number of something to fit in some conditions", and typically propose an unsorted input.
*/

class Solution {
  public int[][] insert(int[][] intervals, int[] newInterval) {
    /*below is official solution*/
    
    // init data
    int newStart = newInterval[0];
    int newEnd = newInterval[1];
    int idx = 0;
    int n = intervals.length;
    LinkedList<int[]> output = new LinkedList<int[]>();

    // add all intervals starting before newInterval
    while (idx < n && newStart > intervals[idx][0])
      output.add(intervals[idx++]);

    // add newInterval
    int[] interval = new int[2];
    // if there is no overlap, just add the interval
    if (output.isEmpty() || output.getLast()[1] < newStart)
      output.add(newInterval);
    // if there is an overlap, merge with the last interval
    else {
      //output.removeLast(); returns the last element of the linked list and the origin linked list will remove this element
      interval = output.removeLast();
      interval[1] = Math.max(interval[1], newEnd);
      output.add(interval);
    }

    // add next intervals, merge with newInterval if needed
    while (idx < n) {
      interval = intervals[idx++];
      int start = interval[0], end = interval[1];
      // if there is no overlap, just add an interval
      if (output.getLast()[1] < start) output.add(interval);
      // if there is an overlap, merge with the last interval
      else {
        interval = output.removeLast();
        interval[1] = Math.max(interval[1], end);
        output.add(interval);
      }
    }
    return output.toArray(new int[output.size()][2]);
  }
}

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if(intervals.Length ==0 )
        {
            return new int[][]{newInterval};
        }

        int start_pos = 0;
        int end_pos= 0;

        for(int row = 0; row < intervals.Length; row++)
        {
            if(intervals[row][0] <= newInterval[0])
            {
                start_pos = row;
            }

            if(intervals[row][1] >= newInterval[1] && end_pos == 0)
            {
                //make sure assign the first match value to end_pos
                end_pos = row;
            }
        }

        int[,] Output = new int[intervals.Length - (end_pos - start_pos),2];

        for(int i = 0; i < intervals.Length; i++)
        {
            if(intervals[i][1] < start_pos)
            {
                //before start point
            }
            else if(intervals[i][0] >= start_pos)
            {
                //
            }
        }
    }
    public int[][] Insert_discussion_solution(int[][] intervals, int[] newInterval) 
    {
        List<int[]> res = new List<int[]>();
        int i = 0;
        
        for (;i < intervals.Length && intervals[i][1] < newInterval[0]; i++)
            res.Add(intervals[i]);
        
        for (;i < intervals.Length && newInterval[0] <= intervals[i][1] && newInterval[1] >= intervals[i][0]; i++)
            newInterval = new int[] { Math.Min(intervals[i][0], newInterval[0]), Math.Max(intervals[i][1], newInterval[1]) };
        
        res.Add(newInterval);
        
        for (;i < intervals.Length; i++)
                res.Add(intervals[i]);
        
        return res.ToArray();
    }

    public int[][] Insert_own_version(int[][] intervals, int[] newInterval)
    {
      /*
      Runtime: 244 ms, faster than 96.10% of C# online submissions for Insert Interval.
      Memory Usage: 33.8 MB, less than 93.04% of C# online submissions for Insert Interval.
      */
      List<int[]> Result = new List<int[]>();
      int index = 0;
      
      //only loop through intervals once, but in three section maxium

      //before first overlap occured
      for(;index < intervals.Length && intervals[index][1] < newInterval[0]; index++)
      {
        Result.Add(intervals[index]);
      }

      //overlap happens, keep updating the newInterval to include all the overlaps intervals[index]
      //the interfier condistion I made a mistake, it was intervals[index][0] <= newInterval[0] && intervals[index][1] >= newInterval[1] and in this situation it won't interfier
      for(; index < intervals.Length && intervals[index][1] >= newInterval[0] && intervals[index][0] <= newInterval[1]; index++)
      {
        newInterval = new int[2]{Math.Min(intervals[index][0],newInterval[0]), Math.Max(intervals[index][1],newInterval[1])};
      }

      Result.Add(newInterval);

      for(; index < intervals.Length; index++)
      {
        //rest of intervals
        Result.Add(intervals[index]);
      }

      return Result.ToArray();
    }
}