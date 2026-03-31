using System;

namespace StringDelegateExample
{
    delegate string StringFilter(string input);

    class Program
    {
        static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        static string ToStars(string input)
        {
            return new string('*', input.Length);
        }

       
        static void ProcessString(string input, StringFilter filter)
        {
            string result = filter(input);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            string testString = "shtoto";

            StringFilter filterDelegate = ToUpperCase;
            
            ProcessString(testString, filterDelegate);

            filterDelegate = ToStars;

            ProcessString(testString, filterDelegate);
        }
    }
}
