using System;


partial class Program
{
	static void Print(int[] arr) {
	    Console.Write("[ ");
		foreach(int e in arr) {
			Console.Write("{0} ", e);
		}
		Console.Write("]");
	}
	
    static void TestArrayCompare()
    {
        Console.WriteLine("***************** Testing ArrayCompare()");
        int[][] arrays = new int[][]
        {
            new int[] { 3, 2, 1, 9, 0 },
            new int[] { 3, 2, 1, 9, 0 },
            new int[] { 5, 4, 3, 2, 1 },
            new int[] { 3, 2, 1, 9, 0, 1 },
        };

        Console.WriteLine("Checking the method...");
        for (int i = 0; i < arrays.Length; ++i)
        {
            for (int j = 0; j < arrays.Length; ++j)
            {
                Print(arrays[i]);
                Console.Write(" vs " );
                Print(arrays[j]);
                Console.Write(": ");
                Console.WriteLine(ArrayCompare(arrays[i], arrays[j]));
            }

        }

        Console.WriteLine("Checking if arrays were not modified...");
        Console.WriteLine(ArrayCompare(arrays[0], new int[] { 3, 2, 1, 9, 0 }));
        Console.WriteLine(ArrayCompare(arrays[1], new int[] { 3, 2, 1, 9, 0 }));
        Console.WriteLine(ArrayCompare(arrays[2], new int[] { 5, 4, 3, 2, 1 }));
        Console.WriteLine(ArrayCompare(arrays[3], new int[] { 3, 2, 1, 9, 0, 1 }));
    }

    static void TestExtractEvenNumber()
    {
        Console.WriteLine("***************** Testing ArrayExtractEvenNumber()");
        int[][] arrays = new int[][]
        {
            new int[] { 4, 1, 2, 5, 6, 1, 3 },
            new int[] { 2, 1, 5, 8, 4, 2 },
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
        };

        Console.WriteLine("Checking the method...");
        for (int i = 0; i < arrays.Length; ++i)
        {
            Print(arrays[i]);
			Console.Write(" -> ");
			Print(ExtractEvenNumber(arrays[i]));
            Console.WriteLine();
        }


        Console.WriteLine("Checking if arrays were not modified...");
        Console.WriteLine(ArrayCompare(arrays[0], new int[] { 4, 1, 2, 5, 6, 1, 3 }));
        Console.WriteLine(ArrayCompare(arrays[1], new int[] { 2, 1, 5, 8, 4, 2 }));
        Console.WriteLine(ArrayCompare(arrays[2], new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
    }

    static void TestArrayCountPrime()
    {
        Console.WriteLine("*****************Testing  CountPrime()");
        int[][] arrays = new int[][]
        {
            new int[] { 0, 9, 1, 2, 5, 12 },
            new int[] { 2, 3, 5, 7, 11 },
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 },
        };
        
        Console.WriteLine("Checking the method...");
        for (int i = 0; i < arrays.Length; ++i)
        {
			Console.Write("Number of primes in array containing ");
			Print(arrays[i]);
			Console.Write(": {0}", CountPrime(arrays[i]));
            Console.WriteLine();
        }


        Console.WriteLine("Checking if arrays were not modified...");
        Console.WriteLine(ArrayCompare(arrays[0], new int[] { 0, 9, 1, 2, 5, 12 }));
        Console.WriteLine(ArrayCompare(arrays[1], new int[] { 2, 3, 5, 7, 11 }));
        Console.WriteLine(ArrayCompare(arrays[2], new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }));
    }

	static void TestMirror()
    {
        Console.WriteLine("*****************Testing Mirror()");
		int[] arr = new int[] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < 5; ++i)
        {
			Print(arr);
			Console.Write(" -> ");
            arr = Mirror(arr);
            Print(arr);
            Console.WriteLine();
        }

    }
	
    static void Main(string[] args)
    {
		
		TestArrayCompare();

		TestExtractEvenNumber();

		TestArrayCountPrime();

		TestMirror();

    }
}

