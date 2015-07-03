#region References

using System.Collections.Generic;
using System.IO;
using Rosetta.Configuration;

#endregion

namespace Rosetta.DataStores
{
	public abstract class FileDataStore : DataStore
	{
		#region Constructors

		protected FileDataStore(DataStoreConfiguration configuration, string displayName, string filter)
			: base(configuration)
		{
			DisplayName = displayName;
			Filter = filter;
		}

		#endregion

		#region Properties

		/// <summary>
		/// This is the display name used when creating open / save dialogs.
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// This is the extension filter user when creating open / save dialogs.
		/// </summary>
		public string Filter { get; set; }

		#endregion

		#region Methods

		public abstract string ConvertRow(DataRow row);
		public abstract DataRow ParseRow(string data);

		public override IEnumerable<DataRow> Read()
		{
			using (var reader = File.OpenText(Configuration.ConnectionString))
			{
				yield return ParseRow(reader.ReadLine());
			}
		}

		public override void Write(DataRow row)
		{
			using (var writer = File.AppendText(Configuration.ConnectionString))
			{
				writer.WriteLine(ConvertRow(row));
			}
		}

		#endregion
	}
}