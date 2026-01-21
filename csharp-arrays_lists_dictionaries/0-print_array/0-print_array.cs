using System;

class Array
{
    public static int?[] CreatePrint(int size)
    {
        // Check if size is negative
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        // Check if size is 0
        if (size == 0)
        {
            Console.WriteLine();  // Print blank line as per requirements
            return new int?[0];
        }
        
        // Create array of nullable ints
        int?[] newArray = new int?[size];
        
        // Fill array with values from 0 to size-1
        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
        }
        
        // Print array elements
        for (int i = 0; i < size; i++)
        {
            // Print element without trailing space for last element
            if (i < size - 1)
            {
                Console.Write($"{newArray[i]} ");
            }
            else
            {
                Console.Write($"{newArray[i]}");
            }
        }
        Console.WriteLine();  // Move to next line after printing all elements
        
        return newArray;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int?[] newArray;

        newArray = Array.CreatePrint(10);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(16);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(0);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(-10);
    }
}