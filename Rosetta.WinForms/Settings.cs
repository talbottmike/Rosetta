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
			DestinationStore = string.Empty;
			DestinationStoreConfiguration = new DataStoreConfiguration();
			Mappings = new List<Mapping>();
			SourceStore = string.Empty;
			SourceStoreConfiguration = new DataStoreConfiguration();
		}

		#endregion

		#region Properties

		public string DestinationStore { get; set; }
		public DataStoreConfiguration DestinationStoreConfiguration { get; set; }
		public ICollection<Mapping> Mappings { get; set; }
		public string SourceStore { get; set; }
		public DataStoreConfiguration SourceStoreConfiguration { get; set; }

		#endregion
	}
}