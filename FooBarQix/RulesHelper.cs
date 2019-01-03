using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FooBarQixKata
{
    public static class RulesHelper
    {
        private static readonly Dictionary<int, string> _fooBarQix = new Dictionary<int, string>
        {
            { 3, "Foo"},
            { 5, "Bar"},
            { 7, "Qix"}
        };

        public static string GetFooBarQix(int number) => _fooBarQix[number];

        public static List<int> GetFooBarQixKeys() 
        {
            return _fooBarQix.Keys.ToList();
        }

        //public string Contains(string message, int i)
        //{
            //foreach (var numberChar in i.ToString())
            //{
            //    foreach (var fooBarQix in _fooBarQix.Keys)
            //    {
            //        if (numberChar.Equals(fooBarQix.ToString()[0]))
            //            message += GetFooBarQix(fooBarQix);
            //    }
            //    if (numberChar.Equals('0'))
            //        message += "*";
            //}
            //return message;
        //}

        //public string IsDivisible(string message, int i)
        //{
        //    foreach (var fooBarQix in _fooBarQix.Keys)
        //    {
        //        if (i % fooBarQix == 0)
        //        {
        //            message += GetFooBarQix(fooBarQix);
        //        }
        //    }
        //    return message;
        //}

        //public void CheckMessageEmpty(string message, int i)
        //{
        //    if (string.IsNullOrEmpty(message))
        //        Console.WriteLine(i);
        //    else
        //        Console.WriteLine(message);
        //}    
    }
}
