#region References

using Rosetta.Data;

#endregion

namespace Rosetta.DataStores
{
	public abstract class DataStore
	{
		#region Constructors

		public DataStore(string displayName)
		{
			DisplayName = displayName;
		}

		#endregion

		#region Properties

		public string DisplayName { get; private set; }

		#endregion

		#region Methods

		public abstract DataTable Read();
		public abstract void Write(DataTable table);

		#endregion
	}
}