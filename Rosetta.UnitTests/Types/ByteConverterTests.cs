#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class ByteConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(byte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(char.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(DateTime.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			Assert.AreEqual(255, Converter.Convert<byte>((decimal) short.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>((decimal) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			Assert.AreEqual(255, Converter.Convert<byte>((double) short.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>((double) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(short.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(int.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual(255, Converter.Convert<byte>((long) short.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>((long) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual(127, Converter.Convert<byte>(sbyte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			Assert.AreEqual(255, Converter.Convert<byte>((float) short.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>((float) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(int.MaxValue.ToString()));
			Assert.AreEqual(0, Converter.Convert<byte>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(TimeSpan.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(ushort.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(uint.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual(255, Converter.Convert<byte>(ulong.MaxValue));
			Assert.AreEqual(0, Converter.Convert<byte>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			Assert.AreEqual(255, Converter.Parse<byte>("255"));
		}

		#endregion
	}
}