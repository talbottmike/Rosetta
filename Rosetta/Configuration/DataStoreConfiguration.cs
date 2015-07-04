#region References

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Rosetta.Configuration
{
	public class DataStoreConfiguration
	{
		#region Constructors

		public DataStoreConfiguration()
		{
			Columns = new List<DataStoreColumn>();
			ConnectionString = string.Empty;
			Filter = string.Empty;
		}

		#endregion

		#region Properties

		/// <summary>
		/// The column settings for the data store.
		/// </summary>
		public IList<DataStoreColumn> Columns { get; set; }

		/// <summary>
		/// The connection string to access the data store.
		/// </summary>
		public string ConnectionString { get; set; }

		/// <summary>
		/// The filter for this data store.
		/// </summary>
		public string Filter { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Build a default data store configuration from a list of string column names.
		/// </summary>
		/// <param name="items"> The list of column names. </param>
		/// <returns> The data store configuration using default settings other than the column name. </returns>
		public static DataStoreConfiguration FromColumns(params string[] items)
		{
			return new DataStoreConfiguration
			{
				Columns = items.Select(x => new DataStoreColumn { Name = x }).ToList()
			};
		}

		#endregion
	}
}