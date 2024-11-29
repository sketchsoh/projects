using System;
using System.Collections.Generic;


partial class Program
{
    static bool IsPalindrome(string input)
    {
        string lower = input.ToLower();
        int counter = lower.Length - 1;
        foreach (char x in lower)
        {
            if (x != lower[counter])
            {
                return false;
            }
            counter--;
        }
        return true;
    }


    static string FlipCases(string input)
    {
        string output = "";
        foreach (char x in input)
        {
            output += Char.IsUpper(x) ? Char.ToLower(x) : Char.ToUpper(x);
        }
        return output;
    }



    static string Scrambler(string input)
    {
        string output = "";
        foreach (char x in input)
        {
            if ((int)x == 90)
            {
                output += "A";
            }
            else if ((int)x == 122)
            {
                output += "a";
            }
            else if ((int)x == 57)
            {
                output += "0";
            }
            else if (((int)x >= 65 && (int)x < 90) || ((int)x >= 97 && (int)x < 122) || ((int)x >= 48 && (int)x < 57))
            {
                output += (char)((int)x + 1);
            }
            else
            {
                output += x;
            }
        }
        return (string)output;
    }

    static string Descrambler(string input)
    {
        string output = "";
        foreach (char x in input)
        {
            if ((int)x == 65)
            {
                output += "Z";
            }
            else if ((int)x == 97)
            {
                output += "z";
            }
            else if ((int)x == 48)
            {
                output += "9";
            }
            else if (((int)x > 65 && (int)x <= 90) || ((int)x > 97 && (int)x <= 122) || ((int)x > 48 && (int)x <= 57))
            {
                output += (char)((int)x - 1);
            }
            else
            {
                output += x;
            }
        }
        return (string)output;
    }

    static string CombineStringByAlternatingCharacters(string left, string right)
    {
        int leftLength = left.Length;
        int rightLength = right.Length;
        string output = "";
        int leftCounter = 0;
        int rightCounter = 0;

        int strlen = leftLength + rightLength;
        for (int i = 0; i < strlen; i++)
        {
            if (leftLength == 0 && rightLength == 0)
            {
                break;
            }
            else if (leftLength == 0)
            {
                output += right[rightCounter];
                rightCounter++;
                rightLength--;
            }
            else if (rightLength == 0)
            {
                output += left[leftCounter];
                leftCounter++;
                leftLength--;
            }
            else
            {
                output += left[i];
                output += right[i];
                rightCounter++;
                rightLength--;
                leftCounter++;
                leftLength--;
            }
        }
        return output;
    }

}
