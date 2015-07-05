#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class UInt64ConverterTests : IConverterTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<ulong>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<ulong>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			TestHelper.AreEqual(3155378975999999999, Converter.Convert<ulong>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(18446744073709551615, Converter.Convert<ulong>((decimal) ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>((decimal) ulong.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(18446744073709551615, Converter.Convert<ulong>((double) ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>((double) ulong.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<ulong>(short.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<ulong>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<ulong>(long.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<ulong>(sbyte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(18446740000000000000, Converter.Convert<ulong>((float) ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>((float) ulong.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(18446744073709551615, Converter.Convert<ulong>(ulong.MaxValue.ToString()));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(ulong.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual(9223372036854775807, Converter.Convert<ulong>(TimeSpan.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ulong>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<ulong>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(18446744073709551615, Converter.Convert<ulong>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ulong>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(65535, Converter.Parse<ulong>("65535"));
		}

		#endregion
	}
}