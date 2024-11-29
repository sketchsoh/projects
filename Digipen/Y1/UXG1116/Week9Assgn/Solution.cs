using System;
using System.Collections.Generic;
using System.Text;


partial class Program
{
    static bool ArrayCompare(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }
        else
        {


            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }

    static int[] ExtractEvenNumber(int[] arr)
    {
        int totalEven = 0;
        foreach (int i in arr)
        {
            if (i % 2 == 0)
            {
                totalEven++;
            }
        }
        int[] even = new int[totalEven];
        int counter = 0;
        foreach (int i in arr)
        {
            if (i % 2 == 0)
            {
                even[counter] = i;
                counter++;
            }
        }
        return even;
    }
    static bool IsPrime(int num)
    {
        if (num == 2)
        {
            return true;
        }
        else if (num < 2)
        {
            return false;
        }
        else
        {
            int x = num;
            while (num > 2)
            {
                num--;
                if (x % num != 0)
                {
                    continue;
                }
                return false;
            }
            return true;
        }

    }


    static int CountPrime(int[] array)
    {
        int counter = 0;
        foreach (int i in array)
        {
            if (IsPrime(i))
            {
                counter++;
            }
        }
        return counter;
    }

    static int[] Mirror(int[] arr)
    {
        int len = arr.Length * 2 - 1;
        int[] mirr = new int[arr.Length * 2];
        int counter = 0;
        foreach (int i in arr)
        {
            mirr[len] = i;
            mirr[counter] = i;
            counter++;
            len--;
        }
        return mirr;
    }

    //new array size*2 arr.Length
    //store array into new array -> for each faster
    //reverse the array (arr.Length - i - 1)
}
