using System;

partial class Program
{
    static int Max(int[] arr)
    {
        int i = arr[0];
        foreach (int x in arr)
        {
            if (x > i)
            {
                i = x;
            }
        }
        return i;
    }

    static int Min(int[] arr)
    {
        int i = arr[0];
        foreach (int x in arr)
        {
            if (x < i)
            {
                i = x;
            }
        }
        return i;
    }

    static int SecondMax(int[] arr)
    {
        int max = Max(arr);
        int secondMax = 0;
        foreach (int x in arr)
        {
            if (arr.Length == 1)
            {
                return max;
            }
            else
            {
                if (secondMax == max || (x > secondMax && x != max))
                {
                    secondMax = x;
                }
            }
        }
        return secondMax;
    }



    static float Mean(float[] arr)
    {
        float x = 0;
        foreach (float f in arr)
        {
            x += f;
        }
        return x / arr.Length;
    }

    static float ARPPU(float[][] userPayments)
    {
        float payments = 0;
        for (int f = 0; f < userPayments.Length; f++)
        {
            for (int ff = 0; ff < userPayments[f].Length; ff++)
            {
                payments += userPayments[f][ff];
            }
        }
        return payments / userPayments.Length;
    }
}
