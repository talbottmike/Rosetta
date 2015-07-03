﻿#region References

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Configuration;
using Rosetta.DataStores;

#endregion

namespace Rosetta.UnitTests
{
	[TestClass]
	public class FlatFileDataStoreTests
	{
		#region Methods

		[TestMethod]
		public void ParseRowWithPlainText()
		{
			var configuration = new DataStoreConfiguration
			{
				Columns = new[]
				{
					new DataStoreColumn { Name = "Name", Length = 12 },
					new DataStoreColumn { Name = "Age", Length = 2 }
				}
			};

			var store = new FlatFileDataStore(configuration);
			var expected = store.NewRow("John Doe    ", "23");
			var actual = store.ParseRow("John Doe    23");

			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertRowWithPlainText()
		{
			var configuration = new DataStoreConfiguration
			{
				Columns = new[]
				{
					new DataStoreColumn { Name = "Name", Length = 12 },
					new DataStoreColumn { Name = "Age", Length = 2 },
					new DataStoreColumn { Name = "Balance", Length = 10, Alignment = ColumnAlignment.Right },
					new DataStoreColumn { Name = "Owed", Length = 4 },
				}
			};

			var store = new FlatFileDataStore(configuration);
			var row = store.NewRow("John Doe", "23", "123.45", "9915");
			var expected = "John Doe    23    123.459915";
			var actual = store.ConvertRow(row);

			Assert.AreEqual(expected, actual);
		}

		#endregion
	}
}