#region References

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Types;

#endregion

namespace Rosetta.UnitTests.Types
{
	[TestClass]
	public class TypeTests
	{
		#region Methods

		[TestMethod]
		public void BooleanTypeNames()
		{
			var expected = new[] { "System.Boolean" };
			var actual = new BooleanType().TypeNames;
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void DateTimeTypeNames()
		{
			var expected = new[] { "System.DateTime", "System.TimeSpan" };
			var actual = new DateTimeType().TypeNames;
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void DecimalTypeNames()
		{
			var expected = new[] { "System.Decimal", "System.Single", "System.Double" };
			var actual = new DecimalType().TypeNames;
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NumberTypeNames()
		{
			var expected = new[]
			{
				"System.Int32", "System.UInt32", "System.Int64", "System.UInt64",
				"System.Byte", "System.SByte", "System.Int16", "System.UInt16"
			};

			var actual = new NumberType().TypeNames;
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StringTypeNames()
		{
			var expected = new[]
			{
				"System.String", "System.Char"
			};

			var actual = new StringType().TypeNames;
			TestHelper.AreEqual(expected, actual);
		}

		#endregion
	}
}