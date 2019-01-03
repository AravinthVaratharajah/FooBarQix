using System;
namespace FooBarQixKata
{
    public class DivisibleRules : IRules
    {
        public string Apply(int i)
        {
            var message = string.Empty;

            foreach (var fooBarQix in RulesHelper.GetFooBarQixKeys())
            {
                if (i % fooBarQix == 0)
                {
                    message += RulesHelper.GetFooBarQix(fooBarQix);
                }
            }
            return message;
        }
    }
}
