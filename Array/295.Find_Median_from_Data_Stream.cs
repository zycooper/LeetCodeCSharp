/*
The median is the middle value in an ordered integer list. 
If the size of the list is even, there is no middle value and the median is the mean of the two middle values.
For example, for arr = [2,3,4], the median is 3.
For example, for arr = [2,3], the median is (2 + 3) / 2 = 2.5.
Implement the MedianFinder class:

MedianFinder() initializes the MedianFinder object.
void addNum(int num) adds the integer num from the data stream to the data structure.
double findMedian() returns the median of all elements so far. Answers within 10-5 of the actual answer will be accepted.
 
Example 1:
Input
["MedianFinder", "addNum", "addNum", "findMedian", "addNum", "findMedian"]
[[], [1], [2], [], [3], []]
Output
[null, null, null, 1.5, null, 2.0]

Explanation
MedianFinder medianFinder = new MedianFinder();
medianFinder.addNum(1);    // arr = [1]
medianFinder.addNum(2);    // arr = [1, 2]
medianFinder.findMedian(); // return 1.5 (i.e., (1 + 2) / 2)
medianFinder.addNum(3);    // arr[1, 2, 3]
medianFinder.findMedian(); // return 2.0
 
Constraints:
-105 <= num <= 105
There will be at least one element in the data structure before calling findMedian.
At most 5 * 104 calls will be made to addNum and findMedian.

Follow up:
If all integer numbers from the stream are in the range [0, 100], how would you optimize your solution?
If 99% of all integer numbers from the stream are in the range [0, 100], how would you optimize your solution?
*/

 /********************************************************************************
 Attampt Times: 0
 *********************************************************************************
 Time Range:
 From: 2021-04-23 14:00
 To: 2021-04-23 14:50
 *********************************************************************************
 Submission Result:
    Runtime: 344 ms, faster than 43.44% of C# online submissions for Find Median from Data Stream.
    Memory Usage: 53.6 MB, less than 54.52% of C# online submissions for Find Median from Data Stream.
 *********************************************************************************
 Note: 
    | Sorting | Heap |

    be carefull,
    in an array
    if even, [length/2 - 1] and [length/2] return the before and after item between middle
    if odd, [length/2] returns the middle

    if use BinarySearch, use ~pos when insert
 *********************************************************************************/
public class MedianFinder {
    private List<double> result = new List<double>();
    /** initialize your data structure here. */
    public MedianFinder() {
        
    }
    
    public void AddNum(int num) {
        //int pos = result.BinaryResearch(num);BinarySearch
        int pos = result.BinarySearch(num);

            if (result.Count() == 0)
            {
                result.Add(num);
            }
            else if (pos >= 0)
            {
                result.Insert(pos, num);
            }
            else 
            {
                result.Insert(~pos, num);
            }
    }
    
    public double FindMedian() {
        if(result.Count() == 0){ return int.MinValue;}

        if(result.Count() % 2 == 0)
        {
            //even
            return (result[result.Count()/2 - 1] + result[result.Count()/2])/2;
        }
        else
        {
            //odd
            return result[result.Count()/2];
        }
    }


}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */