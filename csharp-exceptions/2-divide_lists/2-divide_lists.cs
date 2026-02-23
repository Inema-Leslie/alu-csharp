using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();
        
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                resultList.Add(list1[i] / list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                resultList.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                // For remaining iterations, keep printing "Out of range" without adding to result
                // We need to handle the rest of the loop
                while (i < listLength - 1)
                {
                    i++;
                    Console.WriteLine("Out of range");
                }
                break;
            }
        }
        
        return resultList;
    }
}