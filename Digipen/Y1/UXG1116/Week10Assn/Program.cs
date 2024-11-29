using System;
using System.Collections.Generic;

partial class Program
{
    static bool IsModified(List<int> list, int[] arr)
    {
        if (list.Count != arr.Length)
            return true;
        for (int i = 0; i < list.Count; ++i)
        {
            if (list[i] != arr[i])
            {
                return true;
            }
        }
        return false;
    }

    static void TestFilterEvenNumber()
    {
        Console.WriteLine("=== Testing FilterEvenNumber() ===");
        {
            int[] original = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> input_list = new List<int>(original);
            List<int> result = FilterEvenNumbers(input_list);
            foreach (int i in original)
            {
                Console.Write("{0} ", i);
            }
            Console.Write(" => ");
            foreach (int i in result)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Testing if original list is modified: {0}",
                IsModified(input_list, original));
            Console.WriteLine();

        }
        {
            int[] original = new int[] { 3, 5, 7, 8, 0, 2, 3, 4, 5, 1, 2, 3, 4, 2, 1, 10, 22 };
            List<int> input_list = new List<int>(original);
            List<int> result = FilterEvenNumbers(input_list);
            foreach (int i in original)
            {
                Console.Write("{0} ", i);
            }
            Console.Write(" => ");
            foreach (int i in result)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Testing if original list is modified: {0}",
                IsModified(input_list, original));
            Console.WriteLine();

        }
        {
            int[] original = new int[100];
            for (int i = 0; i < 100; ++i)
            {
                original[i] = i;
            }
            List<int> input_list = new List<int>(original);
            List<int> result = FilterEvenNumbers(input_list);
            foreach (int i in input_list)
            {
                Console.Write("{0} ", i);
            }
            Console.Write(" => ");
            foreach (int i in result)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Testing if original list is modified: {0}",
                IsModified(input_list, original));
            Console.WriteLine();

        }


    }

    static void TestSortDescendingIntoNewList()
    {
        Console.WriteLine("=== Testing SortDescendingIntoNewList() ===");
        {
            int[] original = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> input_list = new List<int>(original);
            List<int> result = SortDescendingIntoNewList(input_list);
            foreach (int i in original)
            {
                Console.Write("{0} ", i);
            }
            Console.Write(" => ");
            foreach (int i in result)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            
            Console.WriteLine("Testing if original list is modified: {0}",
                IsModified(input_list, original));
            Console.WriteLine();
        }
        {
            int[] original = new int[] { 3, 5, 7, 8, 0, 2, 3, 4, 5, 1, 2, 3, 4, 2, 1, 10, 22 }; ;
            List<int> input_list = new List<int>(original);
            List<int> result = SortDescendingIntoNewList(input_list);
            foreach (int i in original)
            {
                Console.Write("{0} ", i);
            }
            Console.Write(" => ");
            foreach (int i in result)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Testing if original list is modified: {0}",
                IsModified(input_list, original));

            Console.WriteLine();

        }
        {
            int[] original = new int[] {
                43, 11, 19, 11, 10,
                43, 91, 38, 41, 62,
                29, 95, 38, 80, 53,
                81, 28, 6,  82, 27,
                52, 79, 90, 75, 40,
                45, 3,  50, 53, 60,
                53, 25, 21, 66, 2,
                39, 11, 42, 52, 63,
                54, 79, 11, 79, 96,
                53, 92, 38, 2,  33,
                12, 46, 65, 45, 10,
                20, 35, 48, 5,  49,
                95, 37, 12, 25, 5,
                25, 44, 84, 75, 100,
                43, 43, 14, 98, 59,
                39, 23, 100,14, 46,
                49, 61, 53, 50, 1,
                93, 17, 16, 8,  65,
                24, 94, 4,  95, 7,
                37, 98, 97, 28, 53,
            };
            List<int> input_list = new List<int>(original);
            List<int> result = SortDescendingIntoNewList(input_list);
            foreach (int i in input_list)
            {
                Console.Write("{0} ", i);
            }
            Console.Write(" => ");
            foreach (int i in result)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Testing if original list is modified: {0}",
                IsModified(input_list, original));

            Console.WriteLine();


        }


    }

    static bool CompareArrayLoosely(int[] lhs, int[] rhs)
    {
        if (lhs.Length != rhs.Length)
            return false;
        Array.Sort(lhs);
        Array.Sort(rhs);

        for(int i = 0; i < lhs.Length; ++i)
        {
            if (lhs[i] != rhs[i])
            {
                return false;
            }
        }
        return true;
    }

    static void TestTransferEvenNumbers()
    {
        Console.WriteLine("=== Testing TransferEvenNumbers() ===");
        {
            Console.WriteLine("====== Test 1");
            int[] dest_arr = new int[] { };
            int[] src_arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> dest_list = new List<int>(dest_arr);
            List<int> src_list = new List<int>(src_arr);

            TransferEvenNumbers(src_list, dest_list);
           
            Console.WriteLine("Are the values in dest correct: {0}",
                CompareArrayLoosely(dest_list.ToArray(), new int[] { 2, 4, 6, 8, 10 }) );

            Console.WriteLine("Are the values in src correct: {0}", 
                CompareArrayLoosely(src_list.ToArray(), new int[] { 1, 3, 5, 7, 9 }) );


        }
        {
            Console.WriteLine("====== Test 2");
            int[] dest_arr = new int[] { 9, 6, 5, 4, 1, 3 };
            int[] src_arr = new int[] { 1, 3, 3, 7, 0, 2, 1, 4, 10, 2, 1 };
            List<int> dest_list = new List<int>(dest_arr);
            List<int> src_list = new List<int>(src_arr);

            TransferEvenNumbers(src_list, dest_list);
           
            Console.WriteLine("Are the values in dest correct: {0}",
                CompareArrayLoosely(dest_list.ToArray(), new int[] { 9, 6, 5, 4, 1, 3, 0, 2, 4, 10, 2 }) );

            Console.WriteLine("Are the values in src correct: {0}", 
                CompareArrayLoosely(src_list.ToArray(), new int[] { 1, 3, 3, 7, 1, 1 }) );


        }
        {
            Console.WriteLine("====== Test 3");
            int[] dest_arr = new int[] { 10, 2, 4, 1, 6, 9, 3, 10 };
            int[] src_arr = new int[] { 4, 6, 8, 12, 14, 22, 28, 124 };
            List<int> dest_list = new List<int>(dest_arr);
            List<int> src_list = new List<int>(src_arr);

            TransferEvenNumbers(src_list, dest_list);
           
            Console.WriteLine("Are the values in dest correct: {0}",
                CompareArrayLoosely(dest_list.ToArray(), new int[] { 10, 2, 4, 1, 6, 9, 3, 10, 4, 6, 8, 12, 14, 22, 28, 124}) );

            Console.WriteLine("Are the values in src correct: {0}", 
                CompareArrayLoosely(src_list.ToArray(), new int[] {}) );


        }

        Console.WriteLine();


    }


    static void TestFindIndices()
    {

        Console.WriteLine("=== Testing FindIndices() ===");
        {
            int[] original = new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };
            List<int> input_list = new List<int>(original);
            
            Console.Write("original => ");
            foreach (int i in original)
                Console.Write("{0} ", i);
            Console.WriteLine();
            
            for (int i = 1; i <= 3; ++i) {
                Console.Write("indices for {0} => ", i);
                List<int> result = FindIndices(input_list, i);
                foreach (int e in result)
                    Console.Write("{0} ", e);
                Console.WriteLine();
            }
            
            Console.WriteLine("Testing if original list is modified: {0}",
                IsModified(input_list, original));
            Console.WriteLine();

        }
        Console.WriteLine();
        {
            
            int[] original = new int[] { 5,6,2,1,3,4,2,1,3,4,5,6,1,2,1,3,4,5,7,9,0 };
            List<int> input_list = new List<int>(original);
            
            Console.Write("original => ");
            foreach (int i in original)
                Console.Write("{0} ", i);
            Console.WriteLine();
            
            for (int i = 0; i < 10; ++i) {
                Console.Write("indices for {0} => ", i);
                List<int> result = FindIndices(input_list, i);
                foreach (int e in result)
                    Console.Write("{0} ", e);
                Console.WriteLine();
            }
            

        }

    }


    static void Main(string[] args)
    {

    	TestFilterEvenNumber();

        TestSortDescendingIntoNewList();

    	TestTransferEvenNumbers();

		TestFindIndices();


    }
}
