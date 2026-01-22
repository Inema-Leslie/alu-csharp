using System;
using System.Collections.Generic;

public static class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();
        
        if (myList == null)
        {
            return result;
        }
        
        foreach (int num in myList)
        {
            result.Add(num % 2 == 0);
        }
        
        return result;
    }
}