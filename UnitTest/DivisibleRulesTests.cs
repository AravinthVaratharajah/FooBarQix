using FooBarQixKata;
using NUnit.Framework;

namespace UnitTest
{
    public class EmptyClass
    {
        public IRules DivisibleRulesTests { get; set; }

        [Test]
        public void Should_Return_Number_When_Not_In_FooBarQix_Rules()
        {

        }

        [Test]
        public void Should_Return_Foo_When_Number_Is_Divisible_By_Three()
        {

        }

        [Test]
        public void Should_Return_Bar_When_Number_Is_Divisible_By_Five()
        {

        }

        [Test]
        public void Should_Return_Qix_When_Number_Is_Divisible_By_Seven()
        {

        }
    }
}
