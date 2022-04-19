import java.util.*;

class LongestSubstringKDistinct
{
    public int totalFruit(int[] fruits)
    {
        //pre condition
        if(fruits.length <= 2)
        {
            return fruits.length();
        }

        int left_cursor = 0;
        int maxFruitsCount = 0;

        //key is fruit index
        //value is count
        Map<Integer, Integer> dict = new HashMap();

        for(int right_cursor = 0; right_cursor < fruits.length(); right_cursor++)
        {
            int right_fruit = fruits[right_cursor];
            //add the right cursor fruit
            dict.put(right_fruit, dict.getOrDefault(right_fruit,0) + 1);

            //check if the dict is valid, if not, move left cursor to right
            while(dict.size() > 2)
            {
                //fruits type more than 2, move left cursor
                int left_fruit = fruites[left_cursor];
                dict.put(left_fruit, dict.get(left_fruit) - 1);

                if(dict.get(left_fruit) == 0)
                {
                    dict.remove(left_fruit);
                }

                left_cursor++;
            }

            maxFruitsCount = Math.max(maxFruitsCount, right_cursor - left_cursor + 1);
        }

        return maxFruitsCount;
    }
}