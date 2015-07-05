#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class StringTypeTests : IConverterTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			Assert.AreEqual("255", Converter.Convert<string>(byte.MaxValue));
			Assert.AreEqual("0", Converter.Convert<string>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual("￿", Converter.Convert<string>(char.MaxValue));
			Assert.AreEqual("\0", Converter.Convert<string>(char.MinValue));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var value = new DateTime(2015, 07, 05, 16, 11, 45);
			Assert.AreEqual("7/5/2015 4:11:45 PM", Converter.Convert<string>(value));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			Assert.AreEqual("4.5686", Converter.Convert<string>(4.5686m));
			Assert.AreEqual("4.57", Converter.Convert<string>(4.5686m, "0.00"));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			Assert.AreEqual("4.5686", Converter.Convert<string>(4.5686d));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual("32767", Converter.Convert<string>(short.MaxValue));
			Assert.AreEqual("-32768", Converter.Convert<string>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual("2147483647", Converter.Convert<string>(int.MaxValue));
			Assert.AreEqual("-2147483648", Converter.Convert<string>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual("9223372036854775807", Converter.Convert<string>(long.MaxValue));
			Assert.AreEqual("-9223372036854775808", Converter.Convert<string>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual("127", Converter.Convert<string>(sbyte.MaxValue));
			Assert.AreEqual("-128", Converter.Convert<string>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			Assert.AreEqual("4.5686", Converter.Convert<string>(4.5686f));
			Assert.AreEqual("3.402823E+38", Converter.Convert<string>(float.MaxValue));
			Assert.AreEqual("-3.402823E+38", Converter.Convert<string>(float.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			Assert.AreEqual("The quick brown fox jumped over the lazy dog.", Converter.Convert<string>("The quick brown fox jumped over the lazy dog."));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			Assert.AreEqual("10675199.02:48:05.4775807", Converter.Convert<string>(TimeSpan.MaxValue));
			Assert.AreEqual("-10675199.02:48:05.4775808", Converter.Convert<string>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual("65535", Converter.Convert<string>(ushort.MaxValue));
			Assert.AreEqual("0", Converter.Convert<string>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual("4294967295", Converter.Convert<string>(uint.MaxValue));
			Assert.AreEqual("0", Converter.Convert<string>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual("18446744073709551615", Converter.Convert<string>(ulong.MaxValue));
			Assert.AreEqual("0", Converter.Convert<string>(ulong.MinValue));
		}

		#endregion
	}
}