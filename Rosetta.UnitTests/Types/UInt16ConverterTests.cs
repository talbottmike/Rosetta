#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class UInt16ConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<ushort>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<ushort>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>((decimal) ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>((decimal) ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>((double) ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>((double) ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<ushort>(short.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>((long) ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>((long) ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<ushort>(sbyte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>((float) ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>((float) ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>(uint.MaxValue.ToString()));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(uint.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>(TimeSpan.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(65535, Converter.Convert<ushort>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<ushort>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(65535, Converter.Parse<ushort>("65535"));
		}

		#endregion
	}
}