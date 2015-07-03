#region References

using System.Collections.Generic;
using System.Linq;

#endregion

namespace Rosetta.Configuration
{
	public class DataStoreConfiguration
	{
		#region Properties

		public IList<DataStoreColumn> Columns { get; set; }
		public string ConnectionString { get; set; }

		#endregion

		#region Methods

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