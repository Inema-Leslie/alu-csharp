using System;
using System.Collections.Generic;
using System.Linq;

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
            // Convert stack to array (this preserves the stack order: top is first in array)
            string[] array = aStack.ToArray();
            aStack.Clear();
            
            // Find the index of search item in the array
            // In the array, index 0 is the TOP of the stack
            int index = Array.IndexOf(array, search);
            
            // We need to keep items BELOW the search item in the stack
            // In the array, items after index are BELOW the search item in the stack
            // But we need to push them in reverse order to maintain stack order
            for (int i = array.Length - 1; i > index; i--)
            {
                aStack.Push(array[i]);
            }
        }
        
        aStack.Push(newItem);
        return aStack;
    }
}