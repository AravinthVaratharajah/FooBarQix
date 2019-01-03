using System;
namespace FooBarQixKata
{
    public class ContentRules : IRules
    {
        public string Apply(int i)
        {
            var message = string.Empty;

            foreach (var numberChar in i.ToString())
            {
                foreach (var fooBarQix in RulesHelper.GetFooBarQixKeys())
                {
                    if (numberChar.Equals(fooBarQix.ToString()[0]))
                        message += RulesHelper.GetFooBarQix(fooBarQix);
                }
                if (numberChar.Equals('0'))
                    message += "*";
            }
            return message;
        }
    }
}
