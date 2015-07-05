#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class DateTimeTypeTests : IConverterTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			var expected = new DateTime(byte.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((byte) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			// This conversion is not supported.
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var expected = DateTime.Now;
			var actual = Converter.Convert<DateTime>(expected);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			var expected = DateTime.Now;
			var actual = Converter.Convert<DateTime>((decimal) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			var value = 65535d;
			var expected = new DateTime((long) value);
			var actual = Converter.Convert<DateTime>(value);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			var expected = new DateTime(short.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((short) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			var expected = new DateTime(int.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((int) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			var expected = new DateTime(long.MaxValue / 4);
			var actual = Converter.Convert<DateTime>(expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			var expected = new DateTime(byte.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((byte) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			var value = 65535f;
			var expected = new DateTime((long) value);
			var actual = Converter.Convert<DateTime>(value);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromString()
		{
			var expected = new DateTime(2015, 07, 05);
			Assert.AreEqual(expected, Converter.Convert<DateTime>("2015/07/05"));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var expected = new TimeSpan(1, 12, 55, 42, 251);
			Assert.AreEqual(expected, Converter.Convert<TimeSpan>("1.12:55:42.251"));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			var expected = new DateTime(ushort.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((ushort) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			var expected = new DateTime(uint.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((uint) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			var expected = new DateTime(int.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((ulong) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Parse()
		{
			var expected = new DateTime(2015, 06, 27, 11, 54, 10);
			Assert.AreEqual(expected, Converter.Parse<DateTime>(expected.ToString()));
			Assert.AreEqual(expected, Converter.Parse<DateTime>(expected.Ticks.ToString()));
		}

		#endregion
	}
}