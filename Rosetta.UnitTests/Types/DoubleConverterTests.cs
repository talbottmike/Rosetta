#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class DoubleConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			Assert.AreEqual(255, Converter.Convert<double>(byte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<double>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual(255, Converter.Convert<double>(char.MaxValue));
			Assert.AreEqual(0, Converter.Convert<double>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var now = DateTime.Now;
			Assert.AreEqual(now.Ticks, Converter.Convert<double>(now));
			Assert.AreEqual(3155378975999999999, Converter.Convert<double>(DateTime.MaxValue));
			Assert.AreEqual(0, Converter.Convert<double>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(double.Parse(decimal.MaxValue.ToString()), Converter.Convert<double>(decimal.MaxValue));
			TestHelper.AreEqual(double.Parse(decimal.MinValue.ToString()), Converter.Convert<double>(decimal.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			var value = double.Parse("1.79769313486231E+308");
			TestHelper.AreEqual(value, Converter.Convert<double>(value));
			TestHelper.AreEqual(value * -1, Converter.Convert<double>(value * -1));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual(32767, Converter.Convert<double>(short.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<double>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual(2147483647, Converter.Convert<double>(int.MaxValue));
			Assert.AreEqual(-2147483648, Converter.Convert<double>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual(9223372036854775807, Converter.Convert<double>(long.MaxValue));
			Assert.AreEqual(-9223372036854775808, Converter.Convert<double>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual(127, Converter.Convert<double>(sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<double>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(double.Parse("3.402823E+38"), Converter.Convert<double>(float.MaxValue));
			TestHelper.AreEqual(double.Parse("-3.402823E+38"), Converter.Convert<double>(float.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			var value = double.Parse("1.79769313486231E+308");
			Assert.AreEqual(value, Converter.Convert<double>(value.ToString()));
			Assert.AreEqual(value * -1, Converter.Convert<double>((value * -1).ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var now = DateTime.Now.TimeOfDay;
			Assert.AreEqual(now.Ticks, Converter.Convert<double>(now));
			Assert.AreEqual(9223372036854775807, Converter.Convert<double>(TimeSpan.MaxValue));
			Assert.AreEqual(-9223372036854775808, Converter.Convert<double>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual(65535, Converter.Convert<double>(ushort.MaxValue));
			Assert.AreEqual(0, Converter.Convert<double>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual(4294967295, Converter.Convert<double>(uint.MaxValue));
			Assert.AreEqual(0, Converter.Convert<double>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual(18446744073709551615, Converter.Convert<double>(ulong.MaxValue));
			Assert.AreEqual(0, Converter.Convert<double>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			Assert.AreEqual(4.5686, Converter.Parse<double>("4.5686"));
		}

		#endregion
	}
}