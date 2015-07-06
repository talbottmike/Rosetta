#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class Int64ConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(1, Converter.Convert<long>(true));
			TestHelper.AreEqual(0, Converter.Convert<long>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<long>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<long>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<long>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<long>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			TestHelper.AreEqual(3155378975999999999, Converter.Convert<long>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<long>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<long>((decimal) long.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<long>((decimal) long.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<long>((double) long.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<long>((double) long.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<long>(short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<long>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<long>(int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<long>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<long>(long.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<long>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<long>(sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<long>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(9223372000000000000, Converter.Convert<long>((float) long.MaxValue));
			TestHelper.AreEqual(-9223372000000000000, Converter.Convert<long>((float) long.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<long>(int.MaxValue.ToString()));
			TestHelper.AreEqual(-2147483648, Converter.Convert<long>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<long>(TimeSpan.MaxValue));
			TestHelper.AreEqual(-9223372036854775808, Converter.Convert<long>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(65535, Converter.Convert<long>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<long>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<long>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<long>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<long>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<long>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Parse<long>("9223372036854775808"));
			TestHelper.AreEqual(9223372036854775807, Converter.Parse<long>("9223372036854775807"));
			TestHelper.AreEqual(0, Converter.Parse<long>("0"));
			TestHelper.AreEqual(-9223372036854775808, Converter.Parse<long>("-9223372036854775808"));
			TestHelper.AreEqual(-9223372036854775808, Converter.Parse<long>("-9223372036854775809"));
		}

		#endregion
	}
}