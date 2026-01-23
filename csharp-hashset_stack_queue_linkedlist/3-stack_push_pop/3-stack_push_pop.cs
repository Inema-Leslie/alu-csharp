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
            string[] items = aStack.ToArray();
            aStack.Clear();
            
            int index = Array.IndexOf(items, search);
            
            for (int i = items.Length - 1; i > index; i--)
            {
                aStack.Push(items[i]);
            }
        }
        
        aStack.Push(newItem);
        return aStack;
    }
}