using System;
using System.Collections.Generic;

partial class Program
{
  static void TestIsPalindrome(string input) {
    Console.WriteLine("Is \"{0}\" palindrome => {1}", input, IsPalindrome(input));
  }

  static void TestFlipCases(string input) {
    Console.WriteLine("\"{0}\" => {1}", input, FlipCases(input));
  }

  static void TestScrambler(string input) {
    Console.WriteLine("\"{0}\" => {1}", input, Scrambler(input));
  }
  
  static void TestDescrambler(string input) {
    Console.WriteLine("\"{0}\" => {1}", input, Descrambler(input));
  }
  
  static void TestCombineStringByAlternatingCharacters(string left, string right) {
    Console.WriteLine("{0} + {1} = {2}", left, right, CombineStringByAlternatingCharacters(left, right));
  }
  
  static void Main(string[] args)
  {
    Console.WriteLine("=== Test IsPalindrome ===");
    TestIsPalindrome("Hello World"); //definitely not a palindrome
    TestIsPalindrome("asdffdsa"); // definitely a palindrome
    TestIsPalindrome("asdfdsa"); // odd number palindrome
    TestIsPalindrome("ASdfDsa"); // upper/lower case checks
    TestIsPalindrome("repaper"); // real word palindrome
    TestIsPalindrome("Peep"); // real word palindrome
    TestIsPalindrome("Civic"); // real word palindrome
    TestIsPalindrome("raceCar"); // real word palindrome
    TestIsPalindrome("rotator"); // real word palindrome

    Console.WriteLine("=== Test FlipCases ===");
    TestFlipCases("Hello World");
    TestFlipCases("hELLO wORLD");
    TestFlipCases("Sir, I demand, I am a maid named Iris.");
    TestFlipCases("Was it a car or a cat I saw?");
    TestFlipCases("Madam, in Eden, I’m Adam.");

    Console.WriteLine("=== Test Scrambler ===");
    TestScrambler("Hello World");
    TestScrambler("hELLO wORLD");
    TestScrambler("Sir, I demand, I am a maid named Iris.");
    TestScrambler("Was it a car or a cat I saw?");
    TestScrambler("Madam, in Eden, I’m Adam.");

    Console.WriteLine("=== Test Descrambler ===");
    TestDescrambler("Ifmmp Xpsm");
    TestDescrambler("iFMMP xPSME");
    TestDescrambler("Tjs, J efnboe, J bn b nbje obnfe Jsjt.");
    TestDescrambler("Xbt ju b dbs ps b dbu J tbx?");
    TestDescrambler("Nbebn, jo Fefo, J’n Bebn");

    Console.WriteLine("=== Test CombineStringByAlternatingCharacters ===");
    TestCombineStringByAlternatingCharacters("Hello ", "World");
    TestCombineStringByAlternatingCharacters("Hjmmsiem aei ead ", "aieaht ynm sGrl.");
    TestCombineStringByAlternatingCharacters("Teqikbonfxjmsover the lazy dog", "h uc rw o up ");
    TestCombineStringByAlternatingCharacters("Teqikbonfxjms", "h uc rw o up over the lazy dog");
  }
}
