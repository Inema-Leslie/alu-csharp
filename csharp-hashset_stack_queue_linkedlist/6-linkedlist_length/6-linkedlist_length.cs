using System;
using System.Collections.Generic;

public static class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list = new LinkedList<int>();
        
        if (size < 0)
        {
            return list; // Return empty list for negative size
        }
        
        for (int i = 0; i < size; i++)
        {
            list.AddLast(i);
            Console.WriteLine(i);
        }
        
        return list;
    }
}