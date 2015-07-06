#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class StringTypeTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual("True", Converter.Convert<string>(true));
			TestHelper.AreEqual("False", Converter.Convert<string>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual("255", Converter.Convert<string>(byte.MaxValue));
			TestHelper.AreEqual("0", Converter.Convert<string>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual("￿", Converter.Convert<string>(char.MaxValue));
			TestHelper.AreEqual("\0", Converter.Convert<string>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var value = new DateTime(2015, 07, 05, 16, 11, 45);
			TestHelper.AreEqual("7/5/2015 4:11:45 PM", Converter.Convert<string>(value));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual("4.5686", Converter.Convert<string>(4.5686m));
			TestHelper.AreEqual("4.57", Converter.Convert<string>(4.5686m, "0.00"));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual("4.5686", Converter.Convert<string>(4.5686d));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual("32767", Converter.Convert<string>(short.MaxValue));
			TestHelper.AreEqual("-32768", Converter.Convert<string>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual("2147483647", Converter.Convert<string>(int.MaxValue));
			TestHelper.AreEqual("-2147483648", Converter.Convert<string>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual("9223372036854775807", Converter.Convert<string>(long.MaxValue));
			TestHelper.AreEqual("-9223372036854775808", Converter.Convert<string>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual("127", Converter.Convert<string>(sbyte.MaxValue));
			TestHelper.AreEqual("-128", Converter.Convert<string>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual("4.5686", Converter.Convert<string>(4.5686f));
			TestHelper.AreEqual("3.402823E+38", Converter.Convert<string>(float.MaxValue));
			TestHelper.AreEqual("-3.402823E+38", Converter.Convert<string>(float.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual("The quick brown fox jumped over the lazy dog.", Converter.Convert<string>("The quick brown fox jumped over the lazy dog."));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			TestHelper.AreEqual("10675199.02:48:05.4775807", Converter.Convert<string>(TimeSpan.MaxValue));
			TestHelper.AreEqual("-10675199.02:48:05.4775808", Converter.Convert<string>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual("65535", Converter.Convert<string>(ushort.MaxValue));
			TestHelper.AreEqual("0", Converter.Convert<string>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual("4294967295", Converter.Convert<string>(uint.MaxValue));
			TestHelper.AreEqual("0", Converter.Convert<string>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual("18446744073709551615", Converter.Convert<string>(ulong.MaxValue));
			TestHelper.AreEqual("0", Converter.Convert<string>(ulong.MinValue));
		}

		public void Parse()
		{
			TestHelper.AreEqual("Testing", Converter.Parse<string>("Testing"));
		}

		#endregion
	}
}