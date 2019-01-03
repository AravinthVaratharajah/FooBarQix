using FooBarQixKata;
using NUnit.Framework;
using NFluent;

namespace UnitTest
{
    [TestFixture]
    public class DivisibleRulesTests
    {
        public IRules Divider { get; set; }

        [SetUp]
        public void SetUp()
        {
            Divider = new DivisibleRules();
        }

        [TestCase(1, "")]
        [TestCase(2, "")]
        [TestCase(11, "")]
        [TestCase(53, "")]
        public void Should_Return_Empty_When_Not_In_FooBarQix_Rules(int number, string expected)
        {
            Check.That(Divider.Apply(number)).IsEqualTo(expected);
        }

        [TestCase(3, "Foo")]
        [TestCase(6, "Foo")]
        public void Should_Return_Foo_When_Number_Is_Divisible_By_Three(int number, string expected)
        {
            Check.That(Divider.Apply(number)).IsEqualTo(expected);
        }

        [TestCase(5, "Bar")]
        [TestCase(10, "Bar")]
        public void Should_Return_Bar_When_Number_Is_Divisible_By_Five(int number, string expected)
        {
            Check.That(Divider.Apply(number)).IsEqualTo(expected);
        }

        [TestCase(7, "Qix")]
        [TestCase(14, "Qix")]
        public void Should_Return_Qix_When_Number_Is_Divisible_By_Seven(int number, string expected)
        {
            Check.That(Divider.Apply(number)).IsEqualTo(expected);
        }
    }
}
