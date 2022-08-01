using System;
using System.Linq;

namespace MMGuideAssesment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Anagram Checker --------------");
            Console.WriteLine();

            Console.WriteLine("Enter the first string:");
            string string1 = Console.ReadLine().ToUpper();
            Console.WriteLine("First string is: " + string1);

            Console.WriteLine("Enter the second string:");
            string string2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Second string is: " + string2);


            string orderedString1 = String.Concat(string1.OrderBy(c => c));
            string orderedString2 = String.Concat(string2.OrderBy(c => c));

            if (orderedString1 == orderedString2)
            {
                Console.WriteLine("YES: The two strings are an anagram");
            }
            else
            {
                Console.WriteLine("NO: The two strings are not an anagram");
            }

            Console.WriteLine();
            Console.WriteLine("Space complexity: O(logN)");
            Console.WriteLine("Time complexity: O(N * logN) average, O(N^2) worst");
        }
    }
}
