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
		public void ConvertFromByte()
		{
			Assert.AreEqual(255, Converter.Convert<short>(byte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<short>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual(255, Converter.Convert<short>(char.MaxValue));
			Assert.AreEqual(0, Converter.Convert<short>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			Assert.AreEqual(32767, Converter.Convert<short>(DateTime.MaxValue));
			Assert.AreEqual(0, Converter.Convert<short>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			Assert.AreEqual(32767, Converter.Convert<short>((decimal) short.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<short>((decimal) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			Assert.AreEqual(32767, Converter.Convert<short>((double) short.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<short>((double) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual(32767, Converter.Convert<short>(short.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<short>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual(32767, Converter.Convert<short>(int.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<short>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual(32767, Converter.Convert<short>((long) short.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<short>((long) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual(127, Converter.Convert<short>(sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<short>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			Assert.AreEqual(32767, Converter.Convert<short>((float) short.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<short>((float) short.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			Assert.AreEqual(32767, Converter.Convert<short>(int.MaxValue.ToString()));
			Assert.AreEqual(-32768, Converter.Convert<short>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			Assert.AreEqual(32767, Converter.Convert<short>(TimeSpan.MaxValue));
			Assert.AreEqual(-32768, Converter.Convert<short>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual(32767, Converter.Convert<short>(ushort.MaxValue));
			Assert.AreEqual(0, Converter.Convert<short>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual(32767, Converter.Convert<short>(uint.MaxValue));
			Assert.AreEqual(0, Converter.Convert<short>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual(32767, Converter.Convert<short>(ulong.MaxValue));
			Assert.AreEqual(0, Converter.Convert<short>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			Assert.AreEqual(32767, Converter.Parse<short>("32767"));
		}

		#endregion
	}
}