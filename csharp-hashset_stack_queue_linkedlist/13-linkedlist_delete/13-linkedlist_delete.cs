using System;
using System.Collections.Generic;

public static class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || index < 0 || index >= myLList.Count)
        {
            return;
        }
        
        LinkedListNode<int> current = myLList.First;
        
        // Traverse to the node at the given index
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }
        
        // Remove the node
        myLList.Remove(current);
    }
}