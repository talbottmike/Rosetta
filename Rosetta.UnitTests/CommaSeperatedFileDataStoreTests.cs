#region References

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Configuration;
using Rosetta.DataStores;

#endregion

namespace Rosetta.UnitTests
{
	[TestClass]
	public class CommaSeperatedFileDataStoreTests
	{
		#region Methods

		[TestMethod]
		public void ConvertRowWithCommaText()
		{
			var configuration = DataStoreConfiguration.FromColumns("Name", "Age");
			var store = new CommaSeperatedFileDataStore(configuration);
			var row = store.NewRow("John, Doe", "23");
			var expected = "\"John, Doe\",23";
			var actual = store.ConvertRow(row);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertRowWithNotEnoughColumns()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age");
			var store = new CommaSeperatedFileDataStore(configuration);

			var row = store.NewRow("John", "Doe", "23");
			store.Configuration.Columns.RemoveAt(2);

			TestHelper.ExpectedException<ArgumentException>(() => store.ConvertRow(row), "The row does not match the column count.");
		}

		[TestMethod]
		public void ConvertRowWithPlainText()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age");
			var store = new CommaSeperatedFileDataStore(configuration);
			var row = store.NewRow("John", "Doe", "23");
			var expected = "John,Doe,23";
			var actual = store.ConvertRow(row);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertRowWithTooManyColumns()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age");
			var store = new CommaSeperatedFileDataStore(configuration);

			var row = store.NewRow("John", "Doe", "23");
			store.Configuration.Columns.Add(new DataStoreColumn { Name = "Birthday" });

			TestHelper.ExpectedException<ArgumentException>(() => store.ConvertRow(row), "The row does not match the column count.");
		}

		[TestMethod]
		public void ParseRowWithCommaText()
		{
			var configuration = DataStoreConfiguration.FromColumns("Name", "Age");
			var store = new CommaSeperatedFileDataStore(configuration);

			var expected = store.NewRow("John, Doe", "23");
			var actual = store.ParseRow("\"John, Doe\",23");

			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ParseRowWithPlainText()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age");
			var store = new CommaSeperatedFileDataStore(configuration);

			var expected = store.NewRow("John", "Doe", "23");
			var actual = store.ParseRow("John,Doe,23");

			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ParseRowWithQuotedText()
		{
			var configuration = DataStoreConfiguration.FromColumns("Name", "Age");
			var store = new CommaSeperatedFileDataStore(configuration);

			var expected = store.NewRow("John, Doe (\"Bobby\")", "23");
			var actual = store.ParseRow("\"John, Doe (\"\"Bobby\"\")\",23");

			TestHelper.AreEqual(expected, actual);
		}

		#endregion
	}
}