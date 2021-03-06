﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDD;
using TDD.Exceptions;

namespace TDD.Tests
{
    [TestFixture]
    public class CounterTest
    {
        private static int[] divisableByThreeTestSource = { 33, 66, 99 };
        private static int[] divisableByFiveTestSource = { 25, 65, 95 };
        private static int[] divisableByThreeAndFiveTestSource = { 30, 60, 90 };
        private static int[] belowOneThrowsExeptionTestSource = { 0, -5, -10 };

        [Test]
        [TestCaseSource("divisableByThreeTestSource")]
        public void Divisable_by_three_returns_Hi(int input)
        {
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual("Hi", result);
        }

        [Test]
        [TestCaseSource("divisableByFiveTestSource")]
        public void Divisable_by_five_returns_Of(int input)
        {
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual("Of", result);
        }
        
        [Test]
        [TestCaseSource("divisableByThreeAndFiveTestSource")]
        public void Divisable_by_three_and_five_returns_HiOf(int input)
        {
            string result = Program.ConvertNumberToCorrectString(input);
            Assert.AreEqual("HiOf", result);
        }

        [Test]
        [TestCaseSource("belowOneThrowsExeptionTestSource")]
        public void Below_one_throws_TooNegativeException(int input)
        {
            Assert.Throws<TooNegativeException>(
                () => Program.ConvertNumberToCorrectString(input)
                );
        }

    }
}
