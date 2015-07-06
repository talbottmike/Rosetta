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
		public void ConvertFromByte()
		{
			Assert.AreEqual(255, Converter.Convert<long>(byte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<long>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual(255, Converter.Convert<long>(char.MaxValue));
			Assert.AreEqual(0, Converter.Convert<long>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			Assert.AreEqual(3155378975999999999, Converter.Convert<long>(DateTime.MaxValue));
			Assert.AreEqual(0, Converter.Convert<long>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			Assert.AreEqual(9223372036854775807, Converter.Convert<long>((decimal) long.MaxValue));
			Assert.AreEqual(-9223372036854775808, Converter.Convert<long>((decimal) long.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			Assert.AreEqual(9223372036854775807, Converter.Convert<long>((double) long.MaxValue));
			Assert.AreEqual(-9223372036854775808, Converter.Convert<long>((double) long.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual(32767, Converter.Convert<long>(short.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<long>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual(2147483647, Converter.Convert<long>(int.MaxValue));
			Assert.AreEqual(-2147483648, Converter.Convert<long>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual(9223372036854775807, Converter.Convert<long>(long.MaxValue));
			Assert.AreEqual(-9223372036854775808, Converter.Convert<long>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual(127, Converter.Convert<long>(sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<long>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			Assert.AreEqual(9223372000000000000, Converter.Convert<long>((float) long.MaxValue));
			Assert.AreEqual(-9223372000000000000, Converter.Convert<long>((float) long.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			Assert.AreEqual(2147483647, Converter.Convert<long>(int.MaxValue.ToString()));
			Assert.AreEqual(-2147483648, Converter.Convert<long>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			Assert.AreEqual(9223372036854775807, Converter.Convert<long>(TimeSpan.MaxValue));
			Assert.AreEqual(-9223372036854775808, Converter.Convert<long>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual(65535, Converter.Convert<long>(ushort.MaxValue));
			Assert.AreEqual(0, Converter.Convert<long>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual(4294967295, Converter.Convert<long>(uint.MaxValue));
			Assert.AreEqual(0, Converter.Convert<long>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual(9223372036854775807, Converter.Convert<long>(ulong.MaxValue));
			Assert.AreEqual(0, Converter.Convert<long>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			Assert.AreEqual(9223372036854775807, Converter.Parse<long>("9223372036854775807"));
		}

		#endregion
	}
}