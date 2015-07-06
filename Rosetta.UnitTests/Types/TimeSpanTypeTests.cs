#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class TimeSpanTypeTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			var expected = new TimeSpan(byte.MaxValue / 2);
			var actual = Converter.Convert<TimeSpan>((byte) expected.Ticks);
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
			var expected = DateTime.Now.TimeOfDay;
			var actual = Converter.Convert<TimeSpan>(expected);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			var expected = DateTime.Now.TimeOfDay;
			var actual = Converter.Convert<TimeSpan>((decimal) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			var value = 65535d;
			var expected = new TimeSpan((long) value);
			var actual = Converter.Convert<TimeSpan>(value);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			var expected = new TimeSpan(short.MaxValue / 2);
			var actual = Converter.Convert<TimeSpan>((short) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			var expected = new TimeSpan(int.MaxValue / 2);
			var actual = Converter.Convert<TimeSpan>((int) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			var expected = new TimeSpan(long.MaxValue / 4);
			var actual = Converter.Convert<TimeSpan>(expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			var expected = new TimeSpan(byte.MaxValue / 2);
			var actual = Converter.Convert<TimeSpan>((byte) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			var value = 65535f;
			var expected = new TimeSpan((long) value);
			var actual = Converter.Convert<TimeSpan>(value);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromString()
		{
			var expected = new TimeSpan(1, 12, 55, 42, 251);
			Assert.AreEqual(expected, Converter.Convert<TimeSpan>("1.12:55:42.251"));
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
			var expected = new TimeSpan(ushort.MaxValue / 2);
			var actual = Converter.Convert<TimeSpan>((ushort) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			var expected = new TimeSpan(uint.MaxValue / 2);
			var actual = Converter.Convert<TimeSpan>((uint) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			var expected = new TimeSpan(int.MaxValue / 2);
			var actual = Converter.Convert<TimeSpan>((ulong) expected.Ticks);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Parse()
		{
			var expected = new TimeSpan(1, 11, 54, 10, 250);
			Assert.AreEqual(expected, Converter.Parse<TimeSpan>(expected.ToString()));
			Assert.AreEqual(expected, Converter.Parse<TimeSpan>(expected.Ticks.ToString()));
		}

		#endregion
	}
}