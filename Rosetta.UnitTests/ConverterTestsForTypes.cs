#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransformR.TypeConverters;

#endregion

namespace TransformR.UnitTests
{
	[TestClass]
	public class ConverterTestsForTypes
	{
		#region Methods

		[TestMethod]
		public void ConverterToBooleanFromDecimal()
		{
			var actual = Converter.Convert<bool>(4.5686m);
			Assert.AreEqual(true, actual);
		}

		[TestMethod]
		public void ConverterToByteFromCharAlpha()
		{
			var actual = Converter.Convert<byte>('A');
			Assert.AreEqual((byte) 65, actual);
		}

		[TestMethod]
		public void ConverterToByteFromCharAlphaSpecial()
		{
			var actual = Converter.Convert<byte>('^');
			Assert.AreEqual((byte) 94, actual);
		}

		[TestMethod]
		public void ConverterToByteFromCharNumber()
		{
			var actual = Converter.Convert<byte>('6');
			Assert.AreEqual((byte) 6, actual);
		}

		[TestMethod]
		public void ConverterToDateTimeFromByte()
		{
			var expected = new DateTime(byte.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((byte) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConverterToDateTimeFromDecimal()
		{
			var expected = DateTime.Now;
			var actual = Converter.Convert<DateTime>((decimal) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConverterToDateTimeFromInt()
		{
			var expected = new DateTime(int.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((int) expected.Ticks);
			TestHelper.AreEqual(expected, actual);

			actual = Converter.Convert<DateTime>((uint) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConverterToDateTimeFromSByte()
		{
			var expected = new DateTime(byte.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((byte) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConverterToDateTimeFromUInt()
		{
			var expected = new DateTime(uint.MaxValue / 2);
			var actual = Converter.Convert<DateTime>((uint) expected.Ticks);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConverterToFloatFromDecimal()
		{
			var expected = 123456.123456789f;
			var actual = Converter.Convert<float>(123456.123456789m);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConverterToIntFromDecimal()
		{
			Assert.AreEqual(int.MinValue, Converter.Convert<int>((decimal) int.MinValue));
			Assert.AreEqual(int.MaxValue, Converter.Convert<int>((decimal) int.MaxValue));
		}

		[TestMethod]
		public void ConverterToLongFromDecimal()
		{
			Assert.AreEqual(long.MinValue, Converter.Convert<long>((decimal) long.MinValue));
			Assert.AreEqual(long.MaxValue, Converter.Convert<long>((decimal) long.MaxValue));
		}

		[TestMethod]
		public void ConverterToStringFromDecimal()
		{
			var actual = Converter.Convert<string>(4.5686m, string.Empty);
			Assert.AreEqual("4.5686", actual);
		}

		[TestMethod]
		public void ConverterToStringFromDecimalWithFormat()
		{
			var actual = Converter.Convert<string>(4.5686m, "0.00");
			Assert.AreEqual("4.57", actual);
		}

		[TestMethod]
		public void ConverterToUIntFromDecimal()
		{
			Assert.AreEqual(uint.MinValue, Converter.Convert<uint>((decimal) uint.MinValue));
			Assert.AreEqual(uint.MaxValue, Converter.Convert<uint>((decimal) uint.MaxValue));
			Assert.AreEqual(long.MinValue, Converter.Convert<long>((decimal) long.MinValue));
			Assert.AreEqual(long.MaxValue, Converter.Convert<long>((decimal) long.MaxValue));
		}

		[TestMethod]
		public void ConverterToULongFromDecimal()
		{
			Assert.AreEqual(ulong.MinValue, Converter.Convert<ulong>((decimal) ulong.MinValue));
			Assert.AreEqual(ulong.MaxValue, Converter.Convert<ulong>((decimal) ulong.MaxValue));
		}

		[TestMethod]
		public void ParseDateTimeFromString()
		{
			var expected = new DateTime(2015, 06, 27, 11, 54, 10);
			var actual = Converter.Parse<DateTime>(expected.ToString());
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ParseDateTimeFromTicksString()
		{
			var expected = DateTime.Now;
			var actual = Converter.Parse<DateTime>(expected.Ticks.ToString());
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ParseDecimal()
		{
			var actual = Converter.Parse<decimal>("4.5686");
			Assert.AreEqual(4.5686m, actual);
		}

		[TestMethod]
		public void TypeNames()
		{
			var actual = new DecimalTypeConverter().TypeNames;
			TestHelper.AreEqual(new[] { "System.Decimal", "System.Single", "System.Double" }, actual);
		}

		#endregion
	}
}