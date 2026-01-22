using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print number of items
        Console.WriteLine("Number of items: {0}", aStack.Count);
        
        // Print top item
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        
        // Check if contains search
        bool contains = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, contains);
        
        // If contains search, remove items up to and including it
        if (contains)
        {
            // Get all items as array
            string[] items = aStack.ToArray();
            aStack.Clear();
            
            // Find search index (array is from bottom to top)
            int index = Array.IndexOf(items, search);
            
            // Push items that were below search in original stack
            // (items with index < searchIndex in the array)
            for (int i = index - 1; i >= 0; i--)
            {
                aStack.Push(items[i]);
            }
        }
        
        // Add new item
        aStack.Push(newItem);
        
        return aStack;
    }
}