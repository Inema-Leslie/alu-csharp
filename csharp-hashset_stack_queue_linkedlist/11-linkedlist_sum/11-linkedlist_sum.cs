using System;
using System.Collections.Generic;

public static class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        if (myLList == null)
        {
            return 0;
        }
        
        int sum = 0;
        
        foreach (int value in myLList)
        {
            sum += value;
        }
        
        return sum;
    }
}