#region References

using System.Collections.Generic;
using Rosetta.DataStores;

#endregion

namespace Rosetta
{
	public class DataService
	{
		#region Constructors

		public DataService()
		{
			Stores = new List<DataStore>
			{
				new CommaSeperatedFileDataStore(),
				new JsonFileDataStore(),
				new XmlFileDataStore()
			};
		}

		#endregion

		#region Properties

		public ICollection<DataStore> Stores { get; set; }

		#endregion
	}
}