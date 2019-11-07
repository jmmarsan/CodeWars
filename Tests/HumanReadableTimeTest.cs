using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class HumanReadableTimeTest
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual("00:00:00", Kata.Kata.GetReadableTime(0));
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual("00:00:05", Kata.Kata.GetReadableTime(5));
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual("00:01:00", Kata.Kata.GetReadableTime(60));
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual("23:59:59", Kata.Kata.GetReadableTime(86399));
        }

        [Test]
        public void TestMethod5()
        {
            Assert.AreEqual("99:59:59", Kata.Kata.GetReadableTime(359999));
        }
    }
}
