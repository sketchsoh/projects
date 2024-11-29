using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static List<int> FilterEvenNumbers(List<int> list)
    {
        List<int> Even = new List<int>();
        foreach (int x in list)
        {
            if (x % 2 == 0)
            {
                Even.Add(x);
            }
        }
        return Even;
    }


    static List<int> SortDescendingIntoNewList(List<int> list)
    {
        List<int> New = new List<int>();
        foreach (int i in list)
        {
            New.Add(i);
        }
        New.Sort();
        New.Reverse();
        return New;
    }

    static void TransferEvenNumbers(List<int> src, List<int> dest)
    {
        List<int> temp = new List<int>();
        foreach (int x in src)
        {
            if (x % 2 == 0)
            {
                dest.Add(x);
                temp.Add(x);
            }
        }
        foreach (int x in temp)
        {
            src.Remove(x);
        }
    }

    static List<int> FindIndices(List<int> list, int valueToFind)
    {
        int counter = 0;
        List<int> indices = new List<int>();
        foreach (int i in list)
        {
            if (valueToFind == i)
            {
                indices.Add(counter);
                counter++;
            }
            else
            {
                counter++;
            }
        }
        return indices;
    }


}
