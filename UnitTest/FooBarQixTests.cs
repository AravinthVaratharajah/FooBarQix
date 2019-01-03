using FooBarQixKata;
using NUnit.Framework;
using NFluent;

namespace UnitTest
{
    public class FooBarQixTests
    {
        public IRules Divider { get; set; }
        public IRules Contener { get; set; }

        [SetUp]
        public void SetUp()
        {
            Divider = new DivisibleRules();
            Contener = new ContentRules();
        }

        [TestCase(1, "1")]
        [TestCase(53, "BarFoo")]
        [TestCase(63, "FooQixFoo")]
        public void Should_Return_Correct_Value_When_Compute_With_Rules(int number, string expected)
        {
            Check.That(FooBarQix.Compute(number)).IsEqualTo(expected);
        }
    }
}
