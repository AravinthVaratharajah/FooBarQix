﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace FooBarQixKata
{
    public class FooBarQix
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string message = string.Empty;

                //message = Rules.IsDivisible(message, i);
                //message = Contains(message, i);
                //CheckMessageEmpty(message, i);
            }
        }

        //private static string GetFooBarQix(int number) => _fooBarQix[number];

        //public static string IsDivisible(string message, int i)
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

        //public static string Contains(string message, int i)
        //{
        //    foreach (var numberChar in i.ToString(CultureInfo.InvariantCulture).ToCharArray())
        //    {
        //        foreach (var fooBarQix in _fooBarQix.Keys)
        //        {
        //            if (numberChar.Equals(fooBarQix.ToString()[0]))
        //                message += GetFooBarQix(fooBarQix);
        //        }
        //        if (numberChar.Equals('0'))
        //            message += "*";
        //    }
        //    return message;
        //}

        //public static void CheckMessageEmpty(string message, int i)
        //{
        //    if (string.IsNullOrEmpty(message))
        //        Console.WriteLine(i);
        //    else
        //        Console.WriteLine(message);
        //}
    }
}
