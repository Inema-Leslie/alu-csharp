using System;
using System.Collections.Generic;

#nullable enable

public static class List
{
    public static List<int>? CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        if (size == 0)
        {
            Console.WriteLine();
            return new List<int>();
        }
        
        List<int> result = new List<int>();
        
        for (int i = 0; i < size; i++)
        {
            result.Add(i);
        }
        
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
            if (i < result.Count - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        
        return result;
    }
}