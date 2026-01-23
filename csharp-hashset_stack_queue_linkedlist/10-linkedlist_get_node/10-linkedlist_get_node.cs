using System;
using System.Collections.Generic;

public static class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList == null || n < 0 || n >= myLList.Count)
        {
            return 0;
        }
        
        LinkedListNode<int> current = myLList.First;
        
        for (int i = 0; i < n; i++)
        {
            current = current.Next;
        }
        
        return current.Value;
    }
}