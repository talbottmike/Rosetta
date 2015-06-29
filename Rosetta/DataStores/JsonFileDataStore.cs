#region References

using System;
using Rosetta.Data;

#endregion

namespace Rosetta.DataStores
{
	public class JsonFileDataStore : DataStore
	{
		#region Constructors

		public JsonFileDataStore()
			: base("JavaScript Object Notation (json)")
		{
		}

		#endregion

		#region Methods

		public override DataTable Read()
		{
			throw new NotImplementedException();
		}

		public override void Write(DataTable table)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}