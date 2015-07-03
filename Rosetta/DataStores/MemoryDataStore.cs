#region References

using System.Collections.Generic;
using Rosetta.Configuration;

#endregion

namespace Rosetta.DataStores
{
	public class MemoryDataStore : DataStore
	{
		#region Fields

		private readonly ICollection<DataRow> _rows;

		#endregion

		#region Constructors

		public MemoryDataStore(DataStoreConfiguration configuration)
			: base(configuration)
		{
			_rows = new List<DataRow>();
		}

		#endregion

		#region Methods

		public override IEnumerable<DataRow> Read()
		{
			return _rows;
		}

		public override void Write(DataRow row)
		{
			_rows.Add(row);
		}

		#endregion
	}
}