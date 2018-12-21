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
    }
}
