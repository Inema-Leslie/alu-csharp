using System;
using System.Collections.Generic;
using System.Linq;

public static class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        if (myDict == null)
        {
            return;
        }
        
        // Get keys sorted alphabetically
        var sortedKeys = myDict.Keys.ToList();
        sortedKeys.Sort();
        
        // Print each key-value pair in sorted order
        foreach (string key in sortedKeys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}