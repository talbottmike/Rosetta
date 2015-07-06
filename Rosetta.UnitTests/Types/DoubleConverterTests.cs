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
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(1, Converter.Convert<double>(true));
			TestHelper.AreEqual(0, Converter.Convert<double>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<double>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<double>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<double>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<double>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var now = DateTime.Now;
			TestHelper.AreEqual(now.Ticks, Converter.Convert<double>(now));
			TestHelper.AreEqual(3155378975999999999, Converter.Convert<double>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<double>(DateTime.MinValue));
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
			TestHelper.AreEqual(32767, Converter.Convert<double>(short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<double>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<double>(int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<double>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<double>(long.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<double>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<double>(sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<double>(sbyte.MinValue));
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
			TestHelper.AreEqual(value, Converter.Convert<double>(value.ToString()));
			TestHelper.AreEqual(value * -1, Converter.Convert<double>((value * -1).ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var now = DateTime.Now.TimeOfDay;
			TestHelper.AreEqual(now.Ticks, Converter.Convert<double>(now));
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<double>(TimeSpan.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<double>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(65535, Converter.Convert<double>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<double>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<double>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<double>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(18446744073709551615, Converter.Convert<double>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<double>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(4.5686, Converter.Parse<double>("4.5686"));
		}

		#endregion
	}
}