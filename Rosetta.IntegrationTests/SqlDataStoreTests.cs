#region References

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Configuration;
using Rosetta.DataStores;
using Rosetta.IntegrationTests.Properties;

#endregion

namespace Rosetta.IntegrationTests
{
	[TestClass]
	public class SqlDataStoreTests
	{
		#region Fields

		private readonly string _connectionString = "Server=localhost;Database=Rosetta;Integrated Security=True;";

		#endregion

		#region Methods

		[TestMethod]
		public void ReadFromTable()
		{
			var configuration = new DataStoreConfiguration();
			configuration.ConnectionString = _connectionString;
			configuration.Columns = new List<DataStoreColumn>
			{
				new DataStoreColumn { Name = "First Name", Source = "People" },
				new DataStoreColumn { Name = "Last Name", Source = "People" },
				new DataStoreColumn { Name = "Age", Source = "People" }
			};

			RunSql("INSERT INTO [dbo].[People] ([First Name],[Last Name],[Age]) VALUES ('John', 'Doe', 23)");
			RunSql("INSERT INTO [dbo].[People] ([First Name],[Last Name],[Age]) VALUES ('Jane', 'Doe', 21)");

			var store = new SqlDataStore(configuration);
			var actual = store.Read().ToList();

			var memoryStore = new MemoryDataStore(configuration);
			memoryStore.Write("John", "Doe", "23");
			memoryStore.Write("Jane", "Doe", "21");
			var expected = memoryStore.Read().ToList();

			TestHelper.AreEqual(expected, actual);
		}

		[TestInitialize]
		public void TestInitialize()
		{
			using (var connection = new SqlConnection(_connectionString.Replace("Database=Rosetta", "Database=master")))
			{
				var command = new SqlCommand(Resources.CreateDatabase, connection);
				command.Connection.Open();
				command.ExecuteNonQuery();
			}

			using (var connection = new SqlConnection(_connectionString))
			{
				var command = new SqlCommand(Resources.CreateTablePeople, connection);
				command.Connection.Open();
				command.ExecuteNonQuery();
			}
		}

		[TestMethod]
		public void WriteToTable()
		{
			var configuration = new DataStoreConfiguration();
			configuration.ConnectionString = _connectionString;
			configuration.Columns = new List<DataStoreColumn>
			{
				new DataStoreColumn { Name = "First Name", Source = "People" },
				new DataStoreColumn { Name = "Last Name", Source = "People" },
				new DataStoreColumn { Name = "Age", Source = "People" }
			};

			var store = new SqlDataStore(configuration);
			store.Write("John", "Doe", "23");
			store.Write("Jane", "Doe", "21");

			var memoryStore = new MemoryDataStore(configuration);
			memoryStore.Write("John", "Doe", "23");
			memoryStore.Write("Jane", "Doe", "21");

			var actual = store.Read().ToList();
			var expected = memoryStore.Read().ToList();

			TestHelper.AreEqual(expected, actual);
		}

		private void RunSql(string sql)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				var command = new SqlCommand(sql, connection);
				command.Connection.Open();
				command.ExecuteNonQuery();
			}
		}

		#endregion
	}
}