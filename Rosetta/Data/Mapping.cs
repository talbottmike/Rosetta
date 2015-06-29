using TransformR.TypeCombiners;
using TransformR.TypeConverters;

namespace TransformR.Data
{
	public class Mapping
	{
		#region Properties

		public TypeCombiner Combiner { get; set; }
		public string DestinationHeader { get; set; }
		public ProcessSettings PostProcess { get; set; }
		public ProcessSettings[] PreProcesses { get; set; }
		public string[] SourceHeaders { get; set; }
		public string Type { get; set; }

		#endregion
	}
}