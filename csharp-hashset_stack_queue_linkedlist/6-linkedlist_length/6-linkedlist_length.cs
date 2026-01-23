using System.Collections.Generic;

public static class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        if (myLList == null) return count;
        
        var current = myLList.First;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }
}