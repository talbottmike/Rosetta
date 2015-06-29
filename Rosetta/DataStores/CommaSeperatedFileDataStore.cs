#region References

using System.IO;
using System.Linq;
using System.Text;
using Rosetta.Data;

#endregion

namespace Rosetta.DataStores
{
	public class CommaSeperatedFileDataStore : FileDataStore
	{
		#region Constructors

		public CommaSeperatedFileDataStore()
			: base("Comma Seperated File (csv)", "CSV|*.csv")
		{
		}

		#endregion

		#region Methods

		public override DataTable Read()
		{
			var response = new DataTable(FilePath);

			using (var reader = File.OpenText(FilePath))
			{
				var parser = new CsvParser();
				var data = parser.Parse(reader);

				for (var i = 0; i < data[0].Length; i++)
				{
					response.Columns.Add(data[0][i]);
				}

				for (var i = 0; i < data.Length; i++)
				{
					response.NewRow(data[i]);
				}
			}

			return response;
		}

		public override void Write(DataTable table)
		{
			var builder = new StringBuilder();
			var header = string.Join(",", table.Columns);
			var firstLine = string.Join(",", table.Rows.First());

			builder.AppendLine(header);

			var start = header == firstLine ? 1 : 0;
			for (var i = start; i < table.Rows.Count; i++)
			{
				builder.AppendLine(string.Join(",", table.Rows[i].Values));
			}

			File.WriteAllText(FilePath, builder.ToString());
		}

		#endregion
	}
}