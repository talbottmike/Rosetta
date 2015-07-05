#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class DecimalConverterTests : IConverterTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			Assert.AreEqual(255, Converter.Convert<decimal>(byte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(0, Converter.Convert<decimal>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual(255, Converter.Convert<decimal>(char.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(0, Converter.Convert<decimal>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var now = DateTime.Now;
			Assert.AreEqual(now.Ticks, Converter.Convert<decimal>(now));
			Assert.AreEqual(3155378975999999999, Converter.Convert<decimal>(DateTime.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			Assert.AreEqual(79228162514264337593543950335m, Converter.Convert<decimal>(decimal.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(-79228162514264337593543950335m, Converter.Convert<decimal>(decimal.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			Assert.AreEqual(79228162514264300000000000000m, Converter.Convert<decimal>((double) decimal.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0.0));
			Assert.AreEqual(-79228162514264300000000000000m, Converter.Convert<decimal>((double) decimal.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual(32767, Converter.Convert<decimal>(short.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(-32768, Converter.Convert<decimal>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual(2147483647, Converter.Convert<decimal>(int.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(-2147483648, Converter.Convert<decimal>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual(9223372036854775807, Converter.Convert<decimal>(long.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(-9223372036854775808, Converter.Convert<decimal>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual(127, Converter.Convert<decimal>(sbyte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(-128, Converter.Convert<decimal>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			Assert.AreEqual(79228160000000000000000000000m, Converter.Convert<decimal>((float) decimal.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(-79228160000000000000000000000m, Converter.Convert<decimal>((float) decimal.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			Assert.AreEqual(79228162514264337593543950335m, Converter.Convert<decimal>(decimal.MaxValue.ToString()));
			Assert.AreEqual(0, Converter.Convert<decimal>("0"));
			Assert.AreEqual(-79228162514264337593543950335m, Converter.Convert<decimal>(decimal.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var now = DateTime.Now.TimeOfDay;
			Assert.AreEqual(now.Ticks, Converter.Convert<decimal>(now));
			Assert.AreEqual(9223372036854775807, Converter.Convert<decimal>(TimeSpan.MaxValue));
			Assert.AreEqual(-9223372036854775808, Converter.Convert<decimal>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual(65535, Converter.Convert<decimal>(ushort.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(0, Converter.Convert<decimal>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual(4294967295, Converter.Convert<decimal>(uint.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(0, Converter.Convert<decimal>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual(18446744073709551615, Converter.Convert<decimal>(ulong.MaxValue));
			Assert.AreEqual(0, Converter.Convert<decimal>(0));
			Assert.AreEqual(0, Converter.Convert<decimal>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			Assert.AreEqual(4.5686m, Converter.Parse<decimal>("4.5686"));
		}

		#endregion
	}
}