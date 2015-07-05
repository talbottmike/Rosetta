#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class Int32ConverterTests : IConverterTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			Assert.AreEqual(255, Converter.Convert<int>(byte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<int>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual(255, Converter.Convert<int>(char.MaxValue));
			Assert.AreEqual(0, Converter.Convert<int>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>(DateTime.MaxValue));
			Assert.AreEqual(0, Converter.Convert<int>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>((decimal) int.MaxValue));
			Assert.AreEqual(-2147483648, Converter.Convert<int>((decimal) int.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>((double) int.MaxValue));
			Assert.AreEqual(-2147483648, Converter.Convert<int>((double) int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual(32767, Converter.Convert<int>(short.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<int>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>(int.MaxValue));
			Assert.AreEqual(-2147483648, Converter.Convert<int>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>((long) int.MaxValue));
			Assert.AreEqual(-2147483648, Converter.Convert<int>((long) int.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual(127, Converter.Convert<int>(sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<int>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>((float) int.MaxValue));
			Assert.AreEqual(-2147483648, Converter.Convert<int>((float) int.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>(int.MaxValue.ToString()));
			Assert.AreEqual(-2147483648, Converter.Convert<int>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>(TimeSpan.MaxValue));
			Assert.AreEqual(-2147483648, Converter.Convert<int>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual(65535, Converter.Convert<int>(ushort.MaxValue));
			Assert.AreEqual(0, Converter.Convert<int>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>(uint.MaxValue));
			Assert.AreEqual(0, Converter.Convert<int>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual(2147483647, Converter.Convert<int>(ulong.MaxValue));
			Assert.AreEqual(0, Converter.Convert<int>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			Assert.AreEqual(2147483647, Converter.Parse<int>("2147483647"));
		}

		#endregion
	}
}