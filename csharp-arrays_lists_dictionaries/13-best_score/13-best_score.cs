using System;
using System.Collections.Generic;

public static class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            return "None";
        }
        
        string bestKey = "";
        int maxScore = -1;
        
        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > maxScore)
            {
                maxScore = entry.Value;
                bestKey = entry.Key;
            }
        }
        
        return bestKey;
    }
}