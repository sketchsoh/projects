using System;

partial class Program
{

    static void Print(int[] arr)
    {
        Console.Write("[ ");
        foreach (int e in arr)
        {
            Console.Write("{0} ", e);
        }
        Console.Write("]");
    }

    static void Print(float[] arr)
    {
        Console.Write("[ ");
        foreach (float e in arr)
        {
            Console.Write("{0} ", e);
        }
        Console.Write("]");
    }

    static void Print(float[][] arr)
    {
        Console.WriteLine("[");
        foreach (float[] e in arr)
        {
            Console.Write(" ");
            Print(e);
            Console.WriteLine(",");
        }
        Console.Write("]");
    }

    static void TestMax(int[] arr)
    {
        Console.Write("The max of array ");
        Print(arr);
        Console.WriteLine(" is: {0}", Max(arr));
    }

    static void TestMin(int[] arr)
    {
        Console.Write("The min of array ");
        Print(arr);
        Console.WriteLine(" is: {0}", Min(arr));
    }

    static void TestSecondMax(int[] arr)
    {
        Console.Write("The second max of array ");
        Print(arr);
        Console.WriteLine(" is: {0}", SecondMax(arr));
    }


    static void TestMean(float[] arr)
    {
        Console.Write("The mean of array ");
        Print(arr);
        Console.WriteLine(" is: {0:0.00}", Mean(arr));
    }


    static void TestARPPU(float[][] arr)
    {
        Console.Write("The ARPPU of array ");
        Print(arr);
        Console.WriteLine(" is: {0:0.00}", ARPPU(arr));
    }

    static void Main(string[] args)
    {

        Console.WriteLine("=== Testing Max ===");
        TestMax(new int[] { 1, 2, 3, 4, 5 });
        TestMax(new int[] { 5, 4, 3, 2, 1 });
        TestMax(new int[] { 20, 10, 22, 23, 15 });
        TestMax(new int[] { 45, 23, 56, 23, 10, 23, 24, 23, 23, 100, 45 });
        TestMax(new int[] { 42 });

        Console.WriteLine("=== Testing Min ===");
        TestMin(new int[] { 1, 2, 3, 4, 5 });
        TestMin(new int[] { 5, 4, 3, 2, 1 });
        TestMin(new int[] { 20, 10, 22, 23, 15 });
        TestMin(new int[] { 45, 23, 56, 23, 10, 23, 24, 23, 23, 100, 45 });
        TestMin(new int[] { 42 });

        Console.WriteLine("=== Testing Second Max ===");
        TestSecondMax(new int[] { 1, 2, 3, 4, 5 });
        TestSecondMax(new int[] { 5, 4, 3, 2, 1 });
        TestSecondMax(new int[] { 20, 10, 22, 23, 15 });
        TestSecondMax(new int[] { 45, 23, 56, 23, 10, 23, 24, 23, 23, 100, 45 });
        TestSecondMax(new int[] { 42 });

        Console.WriteLine("=== Testing Mean ===");
        TestMean(new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f });
        TestMean(new float[] { 5.0f, 4.0f, 3.0f, 2.0f, 1.0f });
        TestMean(new float[] { 1.5f, 10.2f, 22.2f, -20.5f, 15.13f });
        TestMean(new float[] { -55.5f, -20.2f, -32.5f, 100.0f, 256.0f, -69.0f });
        TestMean(new float[] { 42.5f });

        Console.WriteLine("=== Testing ARPPU ===");
        TestARPPU(new float[][] {
                    new float[]{1.0f,2.0f,3.0f,4.0f,5.0f},
                });
        TestARPPU(new float[][] {
                    new float[]{1.0f,2.0f,3.0f,4.0f,5.0f},
                    new float[]{2.5f,2.5f,2.5f,2.5f},
                    new float[]{5.0f,3.5f,2.2f}
                });
        TestARPPU(new float[][] {
                    new float[]{100.0f,100.0f,200.0f,200.0f,300.0f,300.0f,400.0f,500.0f,600.0f}, // person who spends more and more
					new float[]{20000.0f}, // one time big spender
					new float[]{50.0f,50.0f,50.0f,50.0f,50.0f,50.0f,50.0f,50.0f,50.0f,50.0f,50.0f,50.0f}, // regular monthly spender
					new float[]{100.0f}, // small one time spender
					new float[]{10000.0f, 10000.0f}
                });



    }

}
