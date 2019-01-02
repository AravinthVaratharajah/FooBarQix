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
            var message = FooBarQix.IsDivisible(string.Empty, 3);
            Assert.AreEqual(message, "Foo");
        }

        [TestMethod]
        public void ShouldReturnBarWhenIsDivisibleByFive()
        {
            var message = FooBarQix.IsDivisible(string.Empty, 5);
            Assert.AreEqual(message, "Bar");
        }

        [TestMethod]
        public void ShouldReturnQixWhenIsDivisibleBySeven()
        {
            var message = FooBarQix.IsDivisible(string.Empty, 7);
            Assert.AreEqual(message, "Qix");
        }
    }
}
