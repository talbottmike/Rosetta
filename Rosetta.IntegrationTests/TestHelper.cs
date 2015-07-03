#region References

using System;
using KellermanSoftware.CompareNetObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Rosetta.IntegrationTests
{
	public static class TestHelper
	{
		#region Methods

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