#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class UInt32ConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<uint>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<uint>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>((decimal) uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>((decimal) uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>((double) uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>((double) uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<uint>(short.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>((long) uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>((long) uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<uint>(sbyte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(4294967000, Converter.Convert<uint>((float) uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>((float) uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>(uint.MaxValue.ToString()));
			TestHelper.AreEqual(0, Converter.Convert<uint>(uint.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>(TimeSpan.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(65535, Converter.Convert<uint>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(4294967295, Converter.Convert<uint>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<uint>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(65535, Converter.Parse<uint>("65535"));
		}

		#endregion
	}
}