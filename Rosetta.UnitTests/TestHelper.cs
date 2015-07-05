#region References

using System;
using KellermanSoftware.CompareNetObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.UnitTests
{
	public static class TestHelper
	{
		#region Methods

		public static void AreEqual(double expected, double actual)
		{
			var difference = Math.Abs(expected - actual);
			if (difference > double.Epsilon)
			{
				Assert.Fail("Expected [" + expected + "] but was [" + actual + "].");
			}
		}

		public static void AreEqual(float expected, float actual)
		{
			var difference = Math.Abs(expected - actual);
			if (difference > float.Epsilon)
			{
				Assert.Fail("Expected [" + expected + "] but was [" + actual + "].");
			}
		}

		public static void AreEqual<T>(T expected, T actual)
		{
			var compareObjects = new CompareLogic();
			compareObjects.Config.MaxDifferences = int.MaxValue;

			var result = compareObjects.Compare(expected, actual);
			Assert.IsTrue(result.AreEqual, result.DifferencesString);
		}

		public static void ExpectedException<T>(Action work, string errorMessage) where T : Exception
		{
			try
			{
				work();
			}
			catch (T ex)
			{
				if (!ex.Message.Contains(errorMessage))
				{
					Assert.Fail("Expected <" + ex.Message + "> to contain <" + errorMessage + ">.");
				}
				return;
			}

			Assert.Fail("The expected exception was not thrown.");
		}

		#endregion
	}
}