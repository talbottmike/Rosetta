#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class SByteConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(1, Converter.Convert<sbyte>(true));
			TestHelper.AreEqual(0, Converter.Convert<sbyte>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(byte.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<sbyte>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(char.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<sbyte>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(DateTime.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<sbyte>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>((decimal) sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>((decimal) sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>((double) sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>((double) sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(short.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(int.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>((long) sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>((long) sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>((float) sbyte.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>((float) sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(int.MaxValue.ToString()));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(TimeSpan.MaxValue));
			TestHelper.AreEqual(-128, Converter.Convert<sbyte>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(ushort.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<sbyte>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(uint.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<sbyte>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(127, Converter.Convert<sbyte>(ulong.MaxValue));
			TestHelper.AreEqual(0, Converter.Convert<sbyte>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(127, Converter.Parse<sbyte>("128"));
			TestHelper.AreEqual(127, Converter.Parse<sbyte>("127"));
			TestHelper.AreEqual(0, Converter.Parse<sbyte>("0"));
			TestHelper.AreEqual(-128, Converter.Parse<sbyte>("-128"));
			TestHelper.AreEqual(-128, Converter.Parse<sbyte>("-129"));
		}

		#endregion
	}
}