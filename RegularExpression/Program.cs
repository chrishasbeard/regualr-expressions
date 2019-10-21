using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestingOnTheReg("123456789"));
            Console.WriteLine(TestingOnTheReg("123456"));
        }

        public static string TestingOnTheReg(string input)
        {
            if (Regex.IsMatch(input, @"\d{3}-\d{2}-\d{4}|\d{9}"))
            {
                return "Yay! you did it!";
            }
            return "oh, that did not work.";
        }
    }
}
