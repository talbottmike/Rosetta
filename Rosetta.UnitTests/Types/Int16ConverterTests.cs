#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class Int16ConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(1, Converter.Convert<short>(true));
			TestHelper.AreEqual(0, Converter.Convert<short>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(255, Converter.Convert<short>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<short>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(255, Converter.Convert<short>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<short>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<short>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>((decimal) short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<short>((decimal) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>((double) short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<short>((double) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>(short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<short>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>(int.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<short>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>((long) short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<short>((long) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<short>(sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<short>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>((float) short.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<short>((float) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>(int.MaxValue.ToString()));
			TestHelper.AreEqual(-32768, Converter.Convert<short>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>(TimeSpan.MaxValue));
			TestHelper.AreEqual(-32768, Converter.Convert<short>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<short>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<short>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(32767, Converter.Convert<short>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<short>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(32767, Converter.Parse<short>("32768"));
			TestHelper.AreEqual(32767, Converter.Parse<short>("32767"));
			TestHelper.AreEqual(0, Converter.Parse<short>("0"));
			TestHelper.AreEqual(-32768, Converter.Parse<short>("-32768"));
			TestHelper.AreEqual(-32768, Converter.Parse<short>("-32769"));
		}

		#endregion
	}
}