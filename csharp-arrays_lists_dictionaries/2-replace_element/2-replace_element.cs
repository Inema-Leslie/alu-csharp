using System;

public static class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;  // Return unchanged array
        }
        
        array[index] = n;
        return array;
    }
}