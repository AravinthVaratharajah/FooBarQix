using FooBarQixKata;
using NFluent;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class ContentRulesTests
    {
        public IRules Contener { get; set; }

        [SetUp]
        public void SetUp()
        {
            Contener = new ContentRules();
        }

        [TestCase(1, "")]
        [TestCase(2, "")]
        [TestCase(11, "")]
        [TestCase(24, "")]
        public void Should_Return_Empty_When_Doesnt_Contain_Three_Five_Seven(int number, string expected)
        {
            Check.That(Contener.Apply(number)).IsEqualTo(expected);
        }

        [TestCase(3, "Foo")]
        [TestCase(33, "FooFoo")]
        public void Should_Return_Foo_When_Number_Contains_Three(int number, string expected)
        {
            Check.That(Contener.Apply(number)).IsEqualTo(expected);
        }

        [TestCase(5, "Bar")]
        [TestCase(55, "BarBar")]
        public void Should_Return_Bar_When_Number_Contains_Five(int number, string expected)
        {
            Check.That(Contener.Apply(number)).IsEqualTo(expected);
        }

        [TestCase(7, "Qix")]
        [TestCase(77, "QixQix")]
        public void Should_Return_Qix_When_Number_Contains_Seven(int number, string expected)
        {
            Check.That(Contener.Apply(number)).IsEqualTo(expected);
        }

        [TestCase(0, "*")]
        [TestCase(70, "Qix*")]
        public void Should_Return_Asterix_When_Number_Contains_Zero(int number, string expected)
        {
            Check.That(Contener.Apply(number)).IsEqualTo(expected);
        }
    }
}
