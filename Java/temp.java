import java.util.*;

class LongestSubstringKDistinct
{
    public int lengthOfLongestSubstring(String s) {
        //pre condition
        if(s == null )
        {
            return 0;
        }

        if(s.length() == 1)
        {
            return 1;
        }

        //normal condition
        int left_cursor = 0;
        int maxLength = 0;
        //key is the char and the value is the index of this char appears last time
        Map<Character,Integer> dict = new HashMap();

        for(int right_cursor = 0; right_cursor < s.length(); right_cursor++)
        {
            //add char at right cursor to the dict
            char charAtRightCursor = s.charAt(right_cursor);
            if(dict.containsKey(charAtRightCursor))
            {
                left_cursor = Math.max(left_cursor,dict.get(charAtRightCursor) + 1);
            }

            //update or insert the key and value
            dict.put(charAtRightCursor, right_cursor);
            maxLength = Math.max(maxLength, right_cursor - left_cursor + 1);
        }

        return maxLength;
    }
}