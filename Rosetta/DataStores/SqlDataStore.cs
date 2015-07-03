#region References

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Rosetta.Configuration;

#endregion

namespace Rosetta.DataStores
{
	public class SqlDataStore : DataStore
	{
		#region Fields

		public static string Name = "SQL Server";

		#endregion

		#region Constructors

		public SqlDataStore(DataStoreConfiguration configuration)
			: base(configuration)
		{
		}

		#endregion

		#region Methods

		public override IEnumerable<DataRow> Read()
		{
			using (var connection = new SqlConnection(Configuration.ConnectionString))
			{
				var command = new SqlCommand("SELECT * FROM " + Configuration.Columns[0].Source, connection);
				command.Connection.Open();
				var reader = command.ExecuteReader();

				while (reader.Read())
				{
					yield return NewRow(Configuration.Columns.Select(x => reader[x.Name].ToString()).ToArray());
				}
			}
		}

		public override void Write(DataRow row)
		{
			using (var connection = new SqlConnection(Configuration.ConnectionString))
			{
				var table = Configuration.Columns[0].Source;
				var insert = "INSERT INTO [dbo].[" + table + "] (" + string.Join(",", Configuration.Columns.Select(x => "[" + x.Name + "]"))
					+ ") VALUES (" + string.Join(",", Configuration.Columns.Select(x => "'" + row[x.Name] + "'")) + ")";

				var command = new SqlCommand(insert, connection);
				command.Connection.Open();
				command.ExecuteNonQuery();
			}
		}

		#endregion
	}
}