#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class Int32ConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(1, Converter.Convert<int>(true));
			TestHelper.AreEqual(0, Converter.Convert<int>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<int>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<int>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<int>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<int>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<int>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>((decimal) int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<int>((decimal) int.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>((double) int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<int>((double) int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<int>(short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<int>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>(int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<int>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>((long) int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<int>((long) int.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<int>(sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<int>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>((float) int.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<int>((float) int.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>(int.MaxValue.ToString()));
			TestHelper.AreEqual(-2147483648, Converter.Convert<int>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>(TimeSpan.MaxValue));
			TestHelper.AreEqual(-2147483648, Converter.Convert<int>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(65535, Converter.Convert<int>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<int>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<int>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(2147483647, Converter.Convert<int>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<int>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(2147483647, Converter.Parse<int>("2147483648"));
			TestHelper.AreEqual(2147483647, Converter.Parse<int>("2147483647"));
			TestHelper.AreEqual(0, Converter.Parse<int>("0"));
			TestHelper.AreEqual(-2147483648, Converter.Parse<int>("-2147483648"));
			TestHelper.AreEqual(-2147483648, Converter.Parse<int>("-2147483649"));
		}

		#endregion
	}
}