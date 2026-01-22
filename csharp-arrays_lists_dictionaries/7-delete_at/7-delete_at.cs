using System;
using System.Collections.Generic;

public static class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        
        // Create a new list without the element at the given index
        List<int> newList = new List<int>();
        
        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                newList.Add(myList[i]);
            }
        }
        
        // Clear the original list and add all elements from newList
        myList.Clear();
        myList.AddRange(newList);
        
        return myList;
    }
}