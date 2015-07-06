#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class DecimalConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(1, Converter.Convert<decimal>(true));
			TestHelper.AreEqual(0, Converter.Convert<decimal>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<decimal>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<decimal>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<decimal>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<decimal>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var now = DateTime.Now;
			TestHelper.AreEqual(now.Ticks, Converter.Convert<decimal>(now));
			TestHelper.AreEqual(3155378975999999999, Converter.Convert<decimal>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<decimal>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(79228162514264337593543950335m, Converter.Convert<decimal>(decimal.MaxValue));
			TestHelper.AreEqual(-79228162514264337593543950335m, Converter.Convert<decimal>(decimal.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(79228162514264300000000000000m, Converter.Convert<decimal>((double) decimal.MaxValue));
			TestHelper.AreEqual(-79228162514264300000000000000m, Converter.Convert<decimal>((double) decimal.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<decimal>(short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<decimal>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<decimal>(int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<decimal>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<decimal>(long.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<decimal>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<decimal>(sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<decimal>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(79228160000000000000000000000m, Converter.Convert<decimal>((float) decimal.MaxValue));
			TestHelper.AreEqual(-79228160000000000000000000000m, Converter.Convert<decimal>((float) decimal.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(79228162514264337593543950335m, Converter.Convert<decimal>(decimal.MaxValue.ToString()));
			TestHelper.AreEqual(-79228162514264337593543950335m, Converter.Convert<decimal>(decimal.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var now = DateTime.Now.TimeOfDay;
			TestHelper.AreEqual(now.Ticks, Converter.Convert<decimal>(now));
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<decimal>(TimeSpan.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<decimal>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(65535, Converter.Convert<decimal>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<decimal>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<decimal>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<decimal>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(18446744073709551615, Converter.Convert<decimal>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<decimal>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(4.5686m, Converter.Parse<decimal>("4.5686"));
		}

		#endregion
	}
}