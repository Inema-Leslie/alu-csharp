using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);
        
        if (containsSearch)
        {
            // Convert stack to array to avoid multiple Pop() calls
            string[] array = aStack.ToArray();
            
            // Clear the stack
            aStack.Clear();
            
            // Rebuild the stack, skipping items until we find search
            bool found = false;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (!found && array[i] == search)
                {
                    found = true;
                    continue; // Skip the search item
                }
                
                if (found)
                {
                    // Items after the search item
                    aStack.Push(array[i]);
                }
            }
        }
        
        aStack.Push(newItem);
        return aStack;
    }
}