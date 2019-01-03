using System;

namespace FooBarQixKata
{
    public class FooBarQix
    {
        public static IRules Divider { get; set; }
        public static IRules Contener { get; set; }

        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Compute(i));
            }
        }

        public static string Compute(int i) 
        {
            Divider = new DivisibleRules();
            Contener = new ContentRules();
            string message = string.Empty;
            message = Divider.Apply(i);
            message = message += Contener.Apply(i);
            return string.IsNullOrEmpty(message) ? i.ToString() : message;
        }
    }
}
