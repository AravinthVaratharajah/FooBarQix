using Microsoft.VisualStudio.TestTools.UnitTesting;
using FooBarQixKata;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ShouldReturnFooWhenIsDivisibleByThree()
        {
            var message = FooBarQix.IsDivisibleByThree("", 3);
            Assert.AreEqual(message, "Foo");
        }

        [TestMethod]
        public void ShouldReturnBarWhenIsDivisibleByFive()
        {
            var message = FooBarQix.IsDivisibleByFive("", 5);
            Assert.AreEqual(message, "Bar");
        }
    }
}
