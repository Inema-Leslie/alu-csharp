using System;
using System.Collections.Generic;

public static class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (myLList == null)
        {
            return -1;
        }
        
        int index = 0;
        LinkedListNode<int> current = myLList.First;
        
        while (current != null)
        {
            if (current.Value == value)
            {
                return index;
            }
            
            index++;
            current = current.Next;
        }
        
        return -1;
    }
}