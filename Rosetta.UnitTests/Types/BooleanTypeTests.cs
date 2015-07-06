#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class BooleanConverterTests : IConverterTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromByte()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(byte.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			Assert.AreEqual(true, Converter.Convert<bool>('T'));
			Assert.AreEqual(true, Converter.Convert<bool>('t'));
			Assert.AreEqual(true, Converter.Convert<bool>('1'));
			Assert.AreEqual(true, Converter.Convert<bool>('A', "A"));
			Assert.AreEqual(false, Converter.Convert<bool>('A'));
			Assert.AreEqual(false, Converter.Convert<bool>('F'));
			Assert.AreEqual(false, Converter.Convert<bool>('f'));
			Assert.AreEqual(false, Converter.Convert<bool>('0'));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var now = DateTime.Now;
			Assert.AreEqual(true, Converter.Convert<bool>(now, now.Ticks.ToString()));
			Assert.AreEqual(true, Converter.Convert<bool>(DateTime.Parse(now.ToString()), now.ToString()));
			Assert.AreEqual(true, Converter.Convert<bool>(DateTime.MaxValue, DateTime.MaxValue.Ticks.ToString()));
			Assert.AreEqual(true, Converter.Convert<bool>(DateTime.Parse(DateTime.MaxValue.ToString()), DateTime.MaxValue.ToString()));
			Assert.AreEqual(true, Converter.Convert<bool>(DateTime.MinValue, DateTime.MinValue.Ticks.ToString()));
			Assert.AreEqual(true, Converter.Convert<bool>(DateTime.Parse(DateTime.MinValue.ToString()), DateTime.MinValue.ToString()));
			Assert.AreEqual(false, Converter.Convert<bool>(DateTime.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(int.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(double.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(double.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(short.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(int.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(long.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(sbyte.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(float.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(float.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			Assert.AreEqual(true, Converter.Convert<bool>("True"));
			Assert.AreEqual(true, Converter.Convert<bool>("T"));
			Assert.AreEqual(true, Converter.Convert<bool>("true"));
			Assert.AreEqual(true, Converter.Convert<bool>("t"));
			Assert.AreEqual(true, Converter.Convert<bool>("1"));
			Assert.AreEqual(true, Converter.Convert<bool>("AnotherTrueValue", "AnotherTrueValue"));
			Assert.AreEqual(false, Converter.Convert<bool>("AnotherTrueValue"));
			Assert.AreEqual(false, Converter.Convert<bool>("False"));
			Assert.AreEqual(false, Converter.Convert<bool>("F"));
			Assert.AreEqual(false, Converter.Convert<bool>("false"));
			Assert.AreEqual(false, Converter.Convert<bool>("f"));
			Assert.AreEqual(false, Converter.Convert<bool>("0"));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var now = DateTime.Now.TimeOfDay;
			Assert.AreEqual(true, Converter.Convert<bool>(now, now.ToString()));
			Assert.AreEqual(true, Converter.Convert<bool>(TimeSpan.MaxValue, TimeSpan.MaxValue.ToString()));
			Assert.AreEqual(true, Converter.Convert<bool>(TimeSpan.MinValue, TimeSpan.MinValue.ToString()));
			Assert.AreEqual(false, Converter.Convert<bool>(TimeSpan.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(ushort.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(uint.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			Assert.AreEqual(true, Converter.Convert<bool>(ulong.MaxValue));
			Assert.AreEqual(false, Converter.Convert<bool>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			Assert.AreEqual(true, Converter.Parse<bool>("TRUE"));
			Assert.AreEqual(true, Converter.Parse<bool>("True"));
			Assert.AreEqual(true, Converter.Parse<bool>("true"));
			Assert.AreEqual(false, Converter.Parse<bool>("FALSE"));
			Assert.AreEqual(false, Converter.Parse<bool>("False"));
			Assert.AreEqual(false, Converter.Parse<bool>("false"));
		}

		#endregion
	}
}