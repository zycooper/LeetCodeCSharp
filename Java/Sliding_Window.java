class Solution {
    public double findMaxAverage(int[] nums, int k) {
        //pre condition - check if nums lengh is less than k
        //normal condition
        //if return min, set max to it
        //final result
        int LargestSum = Integer.MIN_VALUE; // Interger.MAX_VALUE;

        //set left cursor
        int Window_Cursor_Left = 0;

        //temporary or middle value, used to compare with the final result
        int Current_Sum = 0;

        //in Java, use lenght, all lower case
        //set right cursor as i in for loop, every time right cursor move, but left cursor may not since if the window length is not valid
        for(int Window_Cursor_Right = 0;  Window_Cursor_Right < nums.length; Window_Cursor_Right++)
        {
            //reset the temporary value, but don't have to touch the final result yet
            Current_Sum += nums[Window_Cursor_Right];

            //check if the window lengh is valid -> note it should be right_cursor >= k - 1
            if(Window_Cursor_Right >= k - 1)
            {
                //reset the final result first
                //note: Math.max, not Math.Max
                LargestSum = Math.max(Current_Sum,LargestSum);

                //then reset the temporary value
                Current_Sum -= nums[Window_Cursor_Left];

                //left curos moves as well.
                Window_Cursor_Left++;
            }
        }

        return (double)LargestSum/k;
    }
}