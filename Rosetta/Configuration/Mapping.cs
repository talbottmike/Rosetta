#region References

using System.Collections.Generic;
using Rosetta.Process;

#endregion

namespace Rosetta.Configuration
{
	public class Mapping
	{
		#region Constructors

		public Mapping()
		{
			CombineMethod = CombineMethod.Join;
			CombineValue = string.Empty;
			DestinationHeader = string.Empty;
			PreProcesses = new List<ProcessSettings>();
			SourceHeaders = new List<string>();
			Type = string.Empty;
		}

		#endregion

		#region Properties

		public CombineMethod CombineMethod { get; set; }
		public object CombineValue { get; set; }
		public string DestinationHeader { get; set; }
		public ProcessSettings PostProcess { get; set; }
		public List<ProcessSettings> PreProcesses { get; set; }
		public List<string> SourceHeaders { get; set; }
		public string Type { get; set; }

		#endregion
	}
}