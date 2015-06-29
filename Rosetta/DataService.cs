#region References

using System.Collections.Generic;
using TransformR.DataStores;

#endregion

namespace TransformR
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