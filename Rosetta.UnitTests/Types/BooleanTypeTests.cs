#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class BooleanConverterTests : IConverterTests, IParseTests
	{
		#region Methods

		[TestMethod]
		public void ConvertFromBoolean()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(true));
			TestHelper.AreEqual(false, Converter.Convert<bool>(false));
		}

		[TestMethod]
		public void ConvertFromByte()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(byte.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(byte.MinValue));
		}

		[TestMethod]
		public void ConvertFromChar()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>('T'));
			TestHelper.AreEqual(true, Converter.Convert<bool>('t'));
			TestHelper.AreEqual(true, Converter.Convert<bool>('1'));
			TestHelper.AreEqual(true, Converter.Convert<bool>('A', "A"));
			TestHelper.AreEqual(false, Converter.Convert<bool>('A'));
			TestHelper.AreEqual(false, Converter.Convert<bool>('F'));
			TestHelper.AreEqual(false, Converter.Convert<bool>('f'));
			TestHelper.AreEqual(false, Converter.Convert<bool>('0'));
		}

		[TestMethod]
		public void ConvertFromDateTime()
		{
			var now = DateTime.Now;
			TestHelper.AreEqual(true, Converter.Convert<bool>(now, now.Ticks.ToString()));
			TestHelper.AreEqual(true, Converter.Convert<bool>(DateTime.Parse(now.ToString()), now.ToString()));
			TestHelper.AreEqual(true, Converter.Convert<bool>(DateTime.MaxValue, DateTime.MaxValue.Ticks.ToString()));
			TestHelper.AreEqual(true, Converter.Convert<bool>(DateTime.Parse(DateTime.MaxValue.ToString()), DateTime.MaxValue.ToString()));
			TestHelper.AreEqual(true, Converter.Convert<bool>(DateTime.MinValue, DateTime.MinValue.Ticks.ToString()));
			TestHelper.AreEqual(true, Converter.Convert<bool>(DateTime.Parse(DateTime.MinValue.ToString()), DateTime.MinValue.ToString()));
			TestHelper.AreEqual(false, Converter.Convert<bool>(DateTime.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(DateTime.MinValue));
		}

		[TestMethod]
		public void ConvertFromDecimal()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(int.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromDouble()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(double.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(double.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt16()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(short.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(short.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt32()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(int.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(int.MinValue));
		}

		[TestMethod]
		public void ConvertFromInt64()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(long.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(long.MinValue));
		}

		[TestMethod]
		public void ConvertFromSByte()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(sbyte.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(sbyte.MinValue));
		}

		[TestMethod]
		public void ConvertFromSingle()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(float.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(float.MinValue));
		}

		[TestMethod]
		public void ConvertFromString()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>("True"));
			TestHelper.AreEqual(true, Converter.Convert<bool>("T"));
			TestHelper.AreEqual(true, Converter.Convert<bool>("true"));
			TestHelper.AreEqual(true, Converter.Convert<bool>("t"));
			TestHelper.AreEqual(true, Converter.Convert<bool>("1"));
			TestHelper.AreEqual(true, Converter.Convert<bool>("AnotherTrueValue", "AnotherTrueValue"));
			TestHelper.AreEqual(false, Converter.Convert<bool>("AnotherTrueValue"));
			TestHelper.AreEqual(false, Converter.Convert<bool>("False"));
			TestHelper.AreEqual(false, Converter.Convert<bool>("F"));
			TestHelper.AreEqual(false, Converter.Convert<bool>("false"));
			TestHelper.AreEqual(false, Converter.Convert<bool>("f"));
			TestHelper.AreEqual(false, Converter.Convert<bool>("0"));
		}

		[TestMethod]
		public void ConvertFromTimeSpan()
		{
			var now = DateTime.Now.TimeOfDay;
			TestHelper.AreEqual(true, Converter.Convert<bool>(now, now.ToString()));
			TestHelper.AreEqual(true, Converter.Convert<bool>(TimeSpan.MaxValue, TimeSpan.MaxValue.ToString()));
			TestHelper.AreEqual(true, Converter.Convert<bool>(TimeSpan.MinValue, TimeSpan.MinValue.ToString()));
			TestHelper.AreEqual(false, Converter.Convert<bool>(TimeSpan.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(TimeSpan.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt16()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(ushort.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(ushort.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt32()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(uint.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(uint.MinValue));
		}

		[TestMethod]
		public void ConvertFromUInt64()
		{
			TestHelper.AreEqual(true, Converter.Convert<bool>(ulong.MaxValue));
			TestHelper.AreEqual(false, Converter.Convert<bool>(ulong.MinValue));
		}

		[TestMethod]
		public void Parse()
		{
			TestHelper.AreEqual(true, Converter.Parse<bool>("TRUE"));
			TestHelper.AreEqual(true, Converter.Parse<bool>("True"));
			TestHelper.AreEqual(true, Converter.Parse<bool>("true"));
			TestHelper.AreEqual(false, Converter.Parse<bool>("FALSE"));
			TestHelper.AreEqual(false, Converter.Parse<bool>("False"));
			TestHelper.AreEqual(false, Converter.Parse<bool>("false"));
		}

		#endregion
	}
}