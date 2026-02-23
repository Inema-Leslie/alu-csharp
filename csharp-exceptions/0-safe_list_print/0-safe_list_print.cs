using System;
using System.Collections.Generic;

public class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            // Exception caught, stop printing
            // count already has the number of successfully printed elements
        }
        
        return count;
    }
}