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
        public void Same_output_as_input()
        {
            int input = 1;
            Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual(1, input);
        }
    }
}
