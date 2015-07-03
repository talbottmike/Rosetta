#region References

using System.Collections.Generic;

#endregion

namespace Rosetta.WinForms
{
	public class Settings
	{
		#region Properties

		public ICollection<string> DestinationHeaders { get; set; }
		public string DestinationPath { get; set; }
		public string DestinationSource { get; set; }
		public ICollection<string> MappingDestination { get; set; }
		public ICollection<string> Mappings { get; set; }
		public ICollection<string> MappingSource { get; set; }
		public ICollection<string> PreProcessors { get; set; }
		public ICollection<string> ProcessorMappings { get; set; }
		public string SelectedSource { get; set; }
		public ICollection<string> SourceHeaders { get; set; }
		public string SourcePath { get; set; }

		#endregion
	}
}