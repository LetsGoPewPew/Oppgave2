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
        [Test]
        public void Divisable_by_three_returns_Hi()
        {
            int input = 99;
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual("Hi", result);
        }

        [Test]
        public void Divisable_by_five_returns_Of()
        {
            int input = 65;
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual("Of", result);
        }

        [Test]
        public void Divisable_by_three_and_five_returns_HiOf()
        {
            int input = 60;
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual("HiOf", result);
        }
    }
}
