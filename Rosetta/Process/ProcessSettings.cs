namespace Rosetta.Process
{
	public class ProcessSettings
	{
		#region Constructors

		public ProcessSettings()
		{
			Filter = string.Empty;
			Method = ProcessMethod.Trim;
			Value = string.Empty;
		}

		#endregion

		#region Properties

		public string DisplayName => $"{Filter},{Method},{Value}";
		public string Filter { get; set; }
		public ProcessMethod Method { get; set; }
		public string Value { get; set; }

		#endregion
	}
}