using System;

public static class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }
        
        int[] result = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            result[i] = i;
        }
        
        for (int i = 0; i < size; i++)
        {
            Console.Write(result[i]);
            
            if (i < size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        
        return result;
    }
}