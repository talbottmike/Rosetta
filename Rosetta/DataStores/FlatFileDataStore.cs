#region References

using System.Text;
using Rosetta.Configuration;

#endregion

namespace Rosetta.DataStores
{
	public class FlatFileDataStore : FileDataStore
	{
		#region Fields

		public static string Filter = "Flat Files|*.*";

		#endregion

		#region Constructors

		public FlatFileDataStore(DataStoreConfiguration configuration)
			: base(configuration)
		{
		}

		#endregion

		#region Methods

		public override string ConvertRow(DataRow row)
		{
			var builder = new StringBuilder();

			foreach (var column in Configuration.Columns)
			{
				var value = row[column.Name];
				if (value.Length > column.Length)
				{
					value = value.Substring(0, column.Length);
				}

				while (value.Length < column.Length)
				{
					value = column.Alignment == ColumnAlignment.Left 
						? value + column.PaddingCharacter 
						: column.PaddingCharacter + value;
				}
				
				builder.Append(value);
			}

			return builder.ToString();
		}

		public override DataRow ParseRow(string data)
		{
			var row = NewRow();
			var offset = 0;

			foreach (var column in Configuration.Columns)
			{
				row[column.Name] = data.Substring(offset, column.Length);
				offset += column.Length;
			}

			return row;
		}

		#endregion
	}
}