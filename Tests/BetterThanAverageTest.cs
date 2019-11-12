using System;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class BetterThanAverageTest
    {
        [Test]
        [TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
        [TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
        [TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]
        public static bool FixedTest(int[] arr, int num)
        {
            return Kata.Kata.BetterThanAverage(arr, num);
        }
    }
}
