namespace Rosetta.DataStores
{
	public abstract class FileDataStore : DataStore
	{
		#region Constructors

		protected FileDataStore(string displayName, string filter)
			: base(displayName)
		{
			Filter = filter;
		}

		#endregion

		#region Properties

		public string FilePath { get; set; }
		public string Filter { get; set; }

		#endregion
	}
}