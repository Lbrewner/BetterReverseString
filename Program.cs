using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetterReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word.");
            string userString = Console.ReadLine();
 
            ReverseString(userString);

            Console.ReadLine();
        }
        static void ReverseString(string userIn)
        {
            int x = 1;
            var reverseString = new StringBuilder();

            foreach (char n in userIn)
            {
                reverseString.Append(userIn[userIn.Length - x]);
                x++; 
            }
            Console.WriteLine(reverseString);

            IsPalindrome(reverseString.ToString(), userIn);
        }
        static void IsPalindrome(string f, string y)
        {
            if (f == y)
            {
                Console.WriteLine("Your word is a palindrome.");
            }
            else
            {
                Console.WriteLine("Your word is not a palindrome.");
            }
        }    
    }
}
