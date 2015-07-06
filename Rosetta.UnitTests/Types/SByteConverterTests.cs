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
		public void ConvertFromByte()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(byte.MaxValue));
			Assert.AreEqual(0, Converter.Convert<sbyte>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(char.MaxValue));
			Assert.AreEqual(0, Converter.Convert<sbyte>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(DateTime.MaxValue));
			Assert.AreEqual(0, Converter.Convert<sbyte>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>((decimal) sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<sbyte>((decimal) sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>((double) sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<sbyte>((double) sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(short.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<sbyte>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(int.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<sbyte>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>((long) sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<sbyte>((long) sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<sbyte>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>((float) sbyte.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<sbyte>((float) sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(int.MaxValue.ToString()));
			Assert.AreEqual(-128, Converter.Convert<sbyte>(int.MinValue.ToString()));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(TimeSpan.MaxValue));
			Assert.AreEqual(-128, Converter.Convert<sbyte>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(ushort.MaxValue));
			Assert.AreEqual(0, Converter.Convert<sbyte>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(uint.MaxValue));
			Assert.AreEqual(0, Converter.Convert<sbyte>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual(127, Converter.Convert<sbyte>(ulong.MaxValue));
			Assert.AreEqual(0, Converter.Convert<sbyte>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			Assert.AreEqual(127, Converter.Parse<sbyte>("128"));
			Assert.AreEqual(127, Converter.Parse<sbyte>("127"));
			Assert.AreEqual(0, Converter.Parse<sbyte>("0"));
			Assert.AreEqual(-128, Converter.Parse<sbyte>("-128"));
			Assert.AreEqual(-128, Converter.Parse<sbyte>("-129"));
		}

		#endregion
	}
}