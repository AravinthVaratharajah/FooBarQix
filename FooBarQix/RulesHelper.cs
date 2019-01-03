using System.Collections.Generic;
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
    }
}
