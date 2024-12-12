using System;

namespace FinalsPrac
{
    class Program
    {
        static void Main()
        {
            List<int> yes = new List<int>();

            string s = "Hello";
            string g = "";

            for (int i = 0; i < s.Length; i++)
            {
                g += (char)((int)s[i] + 1);
            }

            int[] grades = new int[] { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i <= 5; i++)
            {
                sum += grades[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine(g);

            int x = 10;
            switch (x)
            {
                case 1:
                    break;
                default:
                    break;
            }
        }
    }
}
