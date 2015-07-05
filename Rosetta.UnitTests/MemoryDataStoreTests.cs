#region References

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Configuration;
using Rosetta.DataStores;

#endregion

namespace Rosetta.UnitTests
{
	[TestClass]
	public class MemoryDataStoreTests
	{
		#region Methods

		[TestMethod]
		public void NewRowWithNotEnoughColumns()
		{
			var source = new MemoryDataStore(DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age"));
			TestHelper.ExpectedException<ArgumentException>(() => source.NewRow("John", "Doe"), "The input values do not match the column count.");
		}

		[TestMethod]
		public void NewRowWithTooManyColumns()
		{
			var source = new MemoryDataStore(DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age"));
			TestHelper.ExpectedException<ArgumentException>(() => source.NewRow("John", "Doe", "23", "1979/01/02"), "The input values do not match the column count.");
		}

		[TestMethod]
		public void Write()
		{
			var source = new MemoryDataStore(DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age"));
			var row = source.NewRow("John", "Doe", "23");
			source.Write(row);

			var expected = new[] { row };
			var actual = source.Read().ToArray();

			TestHelper.AreEqual(expected, actual);
		}

		#endregion
	}
}