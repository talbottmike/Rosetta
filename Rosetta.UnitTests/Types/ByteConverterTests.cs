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
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(1, Converter.Convert<byte>(true));
			TestHelper.AreEqual(0, Converter.Convert<byte>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>((decimal) short.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>((decimal) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>((double) short.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>((double) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(short.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(int.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>((long) short.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>((long) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<byte>(sbyte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>((float) short.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>((float) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(int.MaxValue.ToString()));
			TestHelper.AreEqual(0, Converter.Convert<byte>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(TimeSpan.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(255, Converter.Convert<byte>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<byte>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(255, Converter.Parse<byte>("256"));
			TestHelper.AreEqual(255, Converter.Parse<byte>("255"));
			TestHelper.AreEqual(0, Converter.Parse<byte>("0"));
			TestHelper.AreEqual(0, Converter.Parse<byte>("-1"));
		}

		#endregion
	}
}