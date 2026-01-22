using System;
using System.Collections.Generic;

public static class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        if (myDict == null)
        {
            return 0;
        }
        
        int count = 0;
        
        // Iterate through the dictionary using foreach
        foreach (KeyValuePair<string, string> entry in myDict)
        {
            count++;
        }
        
        return count;
    }
}