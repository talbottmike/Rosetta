namespace Rosetta.Configuration
{
	public class DataStoreColumn
	{
		#region Constructors

		public DataStoreColumn()
		{
			Alignment = ColumnAlignment.Left;
			Length = 0;
			Name = string.Empty;
			PaddingCharacter = ' ';
			Source = string.Empty;
		}

		#endregion

		#region Properties

		public ColumnAlignment Alignment { get; set; }
		public int Length { get; set; }
		public string Name { get; set; }
		public char PaddingCharacter { get; set; }
		public string Source { get; set; }

		#endregion
	}
}