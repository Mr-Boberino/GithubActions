﻿using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

		[Test]
		public void Subtract_Valid_Trimpey()
		{
			Assert.AreEqual(1, Program.Subtract("2", "1"));
			Assert.AreEqual(-8, Program.Subtract("2", "10"));
			Assert.AreEqual(13, Program.Subtract("20", "7"));
		}

		[Test]
		public void Subtract_Invalid_Trimpey()
		{
			Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
			Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
			Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
		}

		[Test]
		public void Subtract_Null_Trimpey()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
			Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
			Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
		}

		[Test]
		public void Multiply_Valid_Trimpey()
		{
			Assert.AreEqual(2, Program.Multiply("1", "2"));
			Assert.AreEqual(6, Program.Multiply("3", "2"));
			Assert.AreEqual(35, Program.Multiply("5", "7"));
		}

		[Test]
		public void Multiply_Invalid_Trimpey()
		{
			Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
			Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
			Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
		}

		[Test]
		public void Multiply_Null_Trimpey()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
			Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
			Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
		}

		[Test]
		public void Divide_Valid_Trimpey()
		{
			Assert.AreEqual(5, Program.Divide("5", "1"));
			Assert.AreEqual(10, Program.Divide("20", "2"));
			Assert.AreEqual(5, Program.Divide("15", "3"));
		}

		[Test]
		public void Divide_Invalid_Trimpey()
		{
			Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
			Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
			Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
		}

		[Test]
		public void Divide_Null_Trimpey()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
			Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
			Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
		}

		[Test]
		public void Power_Valid_Trimpey()
		{
			Assert.AreEqual(5, Program.Power("5", "1"));
			Assert.AreEqual(400, Program.Power("20", "2"));
			Assert.AreEqual(64, Program.Power("2", "6"));
		}

		[Test]
		public void Power_Invalid_Trimpey()
		{
			Assert.Throws<FormatException>(() => Program.Power("1", "a"));
			Assert.Throws<FormatException>(() => Program.Power("a", "1"));
			Assert.Throws<FormatException>(() => Program.Power("a", "a"));
		}

		[Test]
		public void Power_Null_Trimpey()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
			Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
			Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
		}
	}
}
