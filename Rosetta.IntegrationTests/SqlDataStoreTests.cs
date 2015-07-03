#region References

using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Configuration;
using Rosetta.DataStores;

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

		[TestInitialize]
		public void TestInitialize()
		{
			using (var connection = new SqlConnection(_connectionString.Replace("Database=Rosetta", "Database=master")))
			{
				var command = new SqlCommand(Properties.Resources.CreateDatabase, connection);
				command.Connection.Open();
				command.ExecuteNonQuery();
			}

			using (var connection = new SqlConnection(_connectionString))
			{
				var command = new SqlCommand(Properties.Resources.CreateTablePeople, connection);
				command.Connection.Open();
				command.ExecuteNonQuery();
			}
		}

		[TestMethod]
		public void TestMethod1()
		{
			var configuration = new DataStoreConfiguration();
			configuration.ConnectionString = _connectionString;
			configuration.Columns = new[]
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