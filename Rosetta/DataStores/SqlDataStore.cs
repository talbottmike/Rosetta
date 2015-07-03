#region References

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
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

		}

		#endregion
	}
}