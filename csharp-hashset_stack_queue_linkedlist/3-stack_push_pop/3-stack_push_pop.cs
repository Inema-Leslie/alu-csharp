using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());
        
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);
        
        if (containsSearch)
        {
            Stack<string> temp = new Stack<string>();
            bool found = false;
            
            while (aStack.Count > 0 && !found)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    found = true;
                }
            }
        }
        
        aStack.Push(newItem);
        return aStack;
    }
}