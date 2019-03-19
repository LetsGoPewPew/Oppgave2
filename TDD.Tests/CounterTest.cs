using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDD;

namespace TDD.Tests
{
    [TestFixture]
    public class CounterTest
    {
        [TestCase(33, "Hi")]
        [TestCase(66, "Hi")]
        [TestCase(99, "Hi")]
        public void Divisable_by_three_returns_Hi(int input, string expected)
        {
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual(expected, result);
        }

        [TestCase(25, "Of")]
        [TestCase(65, "Of")]
        [TestCase(95, "Of")]
        public void Divisable_by_five_returns_Of(int input, string expected)
        {
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual(expected, result);
        }

        [TestCase(30, "HiOf")]
        [TestCase(60, "HiOf")]
        [TestCase(90, "HiOf")]
        public void Divisable_by_three_and_five_returns_HiOf(int input, string expected)
        {
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual(expected, result);
        }
    }
}
