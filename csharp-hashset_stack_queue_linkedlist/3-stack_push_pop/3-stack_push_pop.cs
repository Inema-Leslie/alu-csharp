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
        
        if (containsSearch && aStack.Count > 0)
        {
            // We need to remove items up to and including search
            // We can only use Pop() once, so we need a different approach
            
            // Create a new stack to rebuild
            Stack<string> newStack = new Stack<string>();
            bool found = false;
            
            // Move items from aStack to newStack until we find search
            // We'll use ONE Pop() in a loop, but that's multiple calls...
            // Actually, we need to avoid Pop() entirely
            
            // Alternative: Use an array
            string[] items = new string[aStack.Count];
            aStack.CopyTo(items, 0);
            Array.Reverse(items); // Now items[0] is top of stack
            
            aStack.Clear();
            
            // Find search and rebuild
            bool keep = false;
            foreach (string item in items)
            {
                if (item == search)
                {
                    keep = true; // Start keeping items AFTER search
                    continue; // Don't add search itself
                }
                
                if (keep)
                {
                    aStack.Push(item);
                }
            }
            
            // Now we need to reverse the order
            // The items we pushed are in wrong order
            Stack<string> temp = new Stack<string>();
            while (aStack.Count > 0)
            {
                temp.Push(aStack.Pop()); // This uses Pop()! We need to avoid
            }
            aStack = temp;
        }
        
        aStack.Push(newItem);
        return aStack;
    }
}