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
    
    /*
    
    tab
    
    First Submission: 11-11-2020
    Last Submission: 11-16-2020
    Submission Result:Time Limit Exceeded
    Solution Time Duration: 34 min
    Summary: still need to spend more time on this since the submission failed, anyway, start from the abandon on the vocabulary
    1. get more familier with C# list 
    2. get more familier with array
    3. get more familier with dictionary and the build-in funcitons(and their names!)

    final solution TwoSum.Two_Sum_2
    */

    /*
    Difficulty: Easy

    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.<br/>
    You may assume that each input would have exactly one solution, and you may not use the same element twice.<br/>
    You can return the answer in any order.

    ### Example 1:
    > Input: nums = [2,7,11,15], target = 9<br/>
    > Output: [0,1]<br/>
    > Output: Because nums[0] + nums[1] == 9, we return [0, 1].<br/>

    ### Example 2:
    > Input: nums = [3,2,4], target = 6<br/>
    > Output: [1,2]<br/>

    ### Example 3:
    > Input: nums = [3,3], target = 6<br/>
    > Output: [0,1]<br/>

    ### Constraints:
    >* 2 <= nums.length <= 105
    >* -109 <= nums[i] <= 109
    >* -109 <= target <= 109
    >* Only one valid answer exists.


    */

    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic = new Dictionary<int,int>(nums.Length);

        for(int i = 0; i< nums.Length; i++)
        {
            if(dic.ContainsKey(target - nums[i]))
            {   
                return new int[2]{dic[target - nums[i]], i};
            }
            else
            {
                dic[nums[i]] = i;
            }
        }

        return new int[2]{-1,-1};
    }

    public int[] TwoSum_1(int[] nums, int target) 
    {                
        List<int> Result = new List<int>();   
        List<int> nums_list = new List<int>(nums);

        for (int i = 0; i < nums_list.Count; i++)
        {
            int current_num = nums_list[i];
            int new_target = target - current_num;

            //next level list
            List<int> _next = nums_list.GetRange(i+1,nums_list.Count-i-1);
            
            int FoundIndex = _next.IndexOf(new_target); 

            if(FoundIndex != -1)
            {
                return new int[]{i,i+FoundIndex+1};
            }         
        }

        return new int[2];
    }   
    public int[] Two_Sum_2(int[] nums, int target)
    {
        /*
        length --> Length
        containsKey --> ContainsKey
        tart --> target
        */

        //the final one, get more familier with the C# framework names

        //define the result dictionary which stores the item in array and the corresponding index
        Dictionary<int,int> dic = new Dictionary<int,int>(nums.length);

        //lopp through the array
        for(int i = 0; i< nums.length; i++)
        {
            //check if the dic already has the key of answer's item in the array
            if(dic.containsKey(target - nums[i]))
            {   
                //return the index of the answer's item and the current index
                return new int[2]{dic[tart - nums[i]], i};
            }
            else
            {
                //since already set the Length of dictionary and the current item doesn't have answer's item in dic, add this item and it's index
                dic[nums[i]] = i;
            }
        }
        //no matching item pair, return {-1,-1}
        return new int[2]{-1,-1};

    }
}

//two solution
public class Solution_Ans {
    public int[] TwoSum(int[] nums, int target) 
    {                   
        return TwoSum_BruteForce(nums,target);
    }   
    //1. Brute force
    private int[] TwoSum_BruteForce(int[] nums, int target)
    {
        for(int i = 0;i<nums.Length;++i)
        {
            for(int j =i+1;j < nums.Length;++j)
            {
                int result = nums[i] + nums[j];

                if(result == target)
                return new int[2]{i,j};                
            }
        }

        return null;
    }


    //2. Hashtable
    private int[] TwoSum_BruteForce(int[] nums, int target)
    {
        Dictionary<int, int> valToIndex = new Dictionary<int, int>(nums.Length);
            for (int i = 0; i < nums.Length; i++) {
                if (valToIndex.ContainsKey(target - nums[i])) {
                    return new int[] { valToIndex[target - nums[i]], i };
                }
                valToIndex[nums[i]] = i;
            }
            return new int[] { -1, -1 };
    }
}
