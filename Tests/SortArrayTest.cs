using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SortArrayTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        }

        [Test]
        public void BasicTests2()
        {
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
        }

        [Test]
        public void BasicTests3()
        {
            Assert.AreEqual(new int[] { }, Kata.Kata.SortArray(new int[] { }));
        }
    }
}
