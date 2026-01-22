using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        
        bool contains = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, contains);
        
        if (contains)
        {
            // We need to use Pop() exactly once
            // Let's pop the top item and work with the rest
            
            if (aStack.Count > 0)
            {
                // Use Pop() ONCE here
                string poppedItem = aStack.Pop();
                
                if (poppedItem == search)
                {
                    // If the top item IS the search item, we're done
                    // The stack now has items below the search
                }
                else
                {
                    // If not, we need to handle it differently
                    // Put it back temporarily
                    Stack<string> temp = new Stack<string>();
                    temp.Push(poppedItem);
                    
                    // Now search through the rest without using Pop()
                    string[] restItems = aStack.ToArray();
                    aStack.Clear();
                    
                    // Find search and rebuild
                    bool found = false;
                    foreach (string item in restItems)
                    {
                        if (item == search)
                        {
                            found = true;
                            continue;
                        }
                        
                        if (found)
                        {
                            aStack.Push(item);
                        }
                        else
                        {
                            temp.Push(item);
                        }
                    }
                    
                    // Items in temp are above search (including our popped item)
                    // We discard them (don't push back)
                }
            }
        }
        
        aStack.Push(newItem);
        return aStack;
    }
}