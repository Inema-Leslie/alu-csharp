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
            // Create a new stack to hold items we want to keep
            Stack<string> tempStack = new Stack<string>();
            bool found = false;
            
            // We can only use Pop() once per iteration, so we need to rebuild the stack
            while (aStack.Count > 0)
            {
                string item = aStack.Pop(); // This is our ONE Pop() call per iteration
                
                if (!found && item == search)
                {
                    found = true;
                    // Don't add this item (search item) to tempStack
                    continue;
                }
                
                if (!found)
                {
                    // Items above the search (haven't found it yet)
                    // Don't add them since we're removing everything up to search
                    continue;
                }
                else
                {
                    // Items below the search (after we found it)
                    tempStack.Push(item);
                }
            }
            
            // Rebuild the original stack with items after search
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }
        
        // Add new item to stack
        aStack.Push(newItem);
        
        return aStack;
    }
}