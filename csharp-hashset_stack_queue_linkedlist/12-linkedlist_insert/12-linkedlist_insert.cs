using System;
using System.Collections.Generic;

public static class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList == null)
        {
            return null;
        }
        
        // If list is empty or n is smaller than first element
        if (myLList.First == null || n <= myLList.First.Value)
        {
            return myLList.AddFirst(n);
        }
        
        // If n is larger than last element
        if (n >= myLList.Last.Value)
        {
            return myLList.AddLast(n);
        }
        
        // Find the correct position to insert
        LinkedListNode<int> current = myLList.First;
        
        while (current.Next != null)
        {
            if (current.Value <= n && n <= current.Next.Value)
            {
                return myLList.AddAfter(current, n);
            }
            current = current.Next;
        }
        
        // Should never reach here, but as fallback add to end
        return myLList.AddLast(n);
    }
}