#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class DateTimeTypeTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(DateTime.MaxValue, Converter.Convert<DateTime>(true));
			TestHelper.AreEqual(DateTime.MinValue, Converter.Convert<DateTime>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			var expected = new DateTime(byte.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((byte) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
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
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			var expected = DateTime.Now;
			var actual = Converter.Convert<DateTime>((decimal) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			var value = 65535d;
			var expected = new DateTime((long) value);
			var actual = Converter.Convert<DateTime>(value);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			var expected = new DateTime(short.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((short) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			var expected = new DateTime(int.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((int) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			var expected = new DateTime(long.MaxValue / 4);
			var actual = Converter.Convert<DateTime>(expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			var expected = new DateTime(byte.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((byte) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			var value = 65535f;
			var expected = new DateTime((long) value);
			var actual = Converter.Convert<DateTime>(value);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromString()
		{
			var expected = new DateTime(2015, 07, 05);
			TestHelper.AreEqual(expected, Converter.Convert<DateTime>("2015/07/05"));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var expected = new TimeSpan(1, 12, 55, 42, 251);
			TestHelper.AreEqual(expected, Converter.Convert<TimeSpan>("1.12:55:42.251"));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			var expected = new DateTime(ushort.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((ushort) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			var expected = new DateTime(uint.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((uint) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			var expected = new DateTime(int.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((ulong) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Parse()
		{
			var expected = new DateTime(2015, 06, 27, 11, 54, 10);
			TestHelper.AreEqual(expected, Converter.Parse<DateTime>(expected.ToString()));
			TestHelper.AreEqual(expected, Converter.Parse<DateTime>(expected.Ticks.ToString()));
		}

		#endregion
	}
}