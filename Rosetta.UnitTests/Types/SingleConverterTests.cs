﻿#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class SingleConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(1, Converter.Convert<float>(true));
			TestHelper.AreEqual(0, Converter.Convert<float>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<float>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<float>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<float>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<float>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var now = DateTime.Now;
			TestHelper.AreEqual(now.Ticks, Converter.Convert<float>(now));
			TestHelper.AreEqual(3155378975999999999, Converter.Convert<float>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<float>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(float.Parse(decimal.MaxValue.ToString()), Converter.Convert<float>(decimal.MaxValue));
			TestHelper.AreEqual(float.Parse(decimal.MinValue.ToString()), Converter.Convert<float>(decimal.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			var value1 = double.Parse("3.402823E+38");
			var value2 = float.Parse("3.402823E+38");
			TestHelper.AreEqual(value2, Converter.Convert<float>(value1));
			TestHelper.AreEqual(value2 * -1, Converter.Convert<float>(value1 * -1));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<float>(short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<float>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<float>(int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<float>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<float>(long.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<float>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<float>(sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<float>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(float.Parse("3.402823E+38"), Converter.Convert<float>(float.MaxValue));
			TestHelper.AreEqual(float.Parse("-3.402823E+38"), Converter.Convert<float>(float.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			var value = float.Parse("3.402823E+38");
			TestHelper.AreEqual(value, Converter.Convert<float>(value.ToString()));
			TestHelper.AreEqual(value * -1, Converter.Convert<float>((value * -1).ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var now = DateTime.Now.TimeOfDay;
			TestHelper.AreEqual(now.Ticks, Converter.Convert<float>(now));
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<float>(TimeSpan.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<float>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(65535, Converter.Convert<float>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<float>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<float>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<float>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(18446744073709551615, Converter.Convert<float>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<float>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(4.56860017776489f, Converter.Parse<float>("4.5686"));
		}

		#endregion
	}
}