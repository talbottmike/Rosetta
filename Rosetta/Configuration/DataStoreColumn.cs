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

		/// <summary>
		/// The alignment for data stores that support alignment.
		/// </summary>
		public ColumnAlignment Alignment { get; set; }

		/// <summary>
		/// The length of the column for data stores that have length requirements.
		/// </summary>
		public int Length { get; set; }

		/// <summary>
		/// The name of the column.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The padding character to use for store that use padding.
		/// </summary>
		public char PaddingCharacter { get; set; }

		/// <summary>
		/// The source of the data store column.
		/// </summary>
		public string Source { get; set; }

		#endregion
	}
}