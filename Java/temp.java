class Solution {
    public String minWindow(String str, String pattern) {
        //pre condition
        if(str.length() < pattern.length() || str.length() == 0)
        {
            return "";
        }
        //normal condition
        int left_cursor = 0;
        Map<Character, Integer> charFrequencyMap = new HashMap();
        String res = "";
        int match = 0;
        
        //fill frequency map
        for(int i = 0; i < pattern.length(); i++)
        {
            char charCurrent = pattern.charAt(i);
            charFrequencyMap.put(charCurrent, charFrequencyMap.getOrDefault(charCurrent, 0) + 1);
        }
        
        //form window sliding
        for(int right_cursor = 0; right_cursor < str.length(); right_cursor++)
        {
            //check right cursor one exist in map
            char charAtRightCursor = str.charAt(right_cursor);
            if(charFrequencyMap.containsKey(charAtRightCursor))
            {
                charFrequencyMap.put(charAtRightCursor, charFrequencyMap.get(charAtRightCursor) - 1);

                if(charFrequencyMap.get(charAtRightCursor) == 0)
                {
                    match++;
                }
            }
            
            //check if current window is valid
            if(match == charFrequencyMap.size())
            {                
                if(res.length() > right_cursor - left_cursor + 1 || res == "")
                {
                     res = str.substring(left_cursor, right_cursor + 1);
                }
                
                //move left cursor
                while(match == charFrequencyMap.size())
                {
                    char charAtLeftCursor = str.charAt(left_cursor++);
                    
                    if(charFrequencyMap.containsKey(charAtLeftCursor))
                    {
                        if(charFrequencyMap.get(charAtRightCursor) == 0)
                        {
                            match--;
                        }
                        
                        charFrequencyMap.put(charAtLeftCursor, charFrequencyMap.get(charAtLeftCursor) + 1);
                    }
                }
            }
        }
        
        return res;//"ADOBECODEBANC".substring(11,12);//
    }
}