using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print number of items
        Console.WriteLine("Number of items: {0}", aStack.Count);
        
        // Print top item or "Stack is empty"
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        
        // Print if stack contains search item
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);
        
        // If stack contains search, remove all items up to and including search
        if (containsSearch)
        {
            // Create a temporary list to hold items
            List<string> temp = new List<string>();
            
            // Pop items until we find the search item
            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    break;
                }
                temp.Add(item);
            }
            
            // The stack now has items after the search item (if any)
            // We don't need to put back the items we popped before search
        }
        
        // Add new item to stack
        aStack.Push(newItem);
        
        return aStack;
    }
}