using NUnit.Framework;
using System;

namespace Tests
{

    [TestFixture]
    public class GetMiddleTest
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual("es", Kata.Kata.GetMiddle("test"));
        }

        [Test]
        public void GenericTests2()
        {
            Assert.AreEqual("t", Kata.Kata.GetMiddle("testing"));
        }

        [Test]
        public void GenericTests3()
        {
            Assert.AreEqual("dd", Kata.Kata.GetMiddle("middle"));
        }

        [Test]
        public void GenericTests4()
        {
            Assert.AreEqual("A", Kata.Kata.GetMiddle("A"));
        }
    }
}
