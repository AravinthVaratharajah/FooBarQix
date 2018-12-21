using System;

namespace FooBarQixKata
{
    public class FooBarQix
    {
        static void Main(string[] args)
        {
            var message = "";

            for (int i = 1; i < 101; i++)
            {
                message = IsDivisibleByThree(message, i);
                message = IsDivisibleByFive(message, i);
                CheckMessageEmpty(message, i);
                message = "";
            }
        }

        public static string IsDivisibleByThree(string message, int i)
        {
            if (i % 3 == 0)
                message += "Foo";
            return message;
        }

        public static string IsDivisibleByFive(string message, int i)
        {
            if (i % 5 == 0)
                message += "Bar";
            return message;
        }

        public static void CheckMessageEmpty(string message, int i)
        {
            if (string.IsNullOrEmpty(message))
                Console.WriteLine(i);
            else
                Console.WriteLine(message);
        }
    }
}
