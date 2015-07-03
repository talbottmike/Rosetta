#region References

using Rosetta.Process;

#endregion

namespace Rosetta.Configuration
{
	public class Mapping
	{
		#region Properties

		public CombineMethod CombineMethod { get; set; }
		public object CombineValue { get; set; }
		public string DestinationHeader { get; set; }
		public ProcessSettings PostProcess { get; set; }
		public ProcessSettings[] PreProcesses { get; set; }
		public string[] SourceHeaders { get; set; }
		public string Type { get; set; }

		#endregion
	}
}