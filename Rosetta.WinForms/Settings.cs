#region References

using System.Collections.Generic;
using Rosetta.Configuration;

#endregion

namespace Rosetta.WinForms
{
	public class Settings
	{
		#region Constructors

		public Settings()
		{
			DestinationStoreConfiguration = new DataStoreConfiguration();
			Mappings = new List<Mapping>();
			SourceStoreConfiguration = new DataStoreConfiguration();
		}

		#endregion

		#region Properties

		public DataStoreConfiguration DestinationStoreConfiguration { get; set; }
		public List<Mapping> Mappings { get; set; }
		public DataStoreConfiguration SourceStoreConfiguration { get; set; }

		#endregion
	}
}