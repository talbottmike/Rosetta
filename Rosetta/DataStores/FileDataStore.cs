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

		protected FileDataStore(DataStoreConfiguration configuration)
			: base(configuration)
		{
		}

		#endregion

		#region Methods

		public override void Initialize()
		{
			using (var stream = File.Open(Configuration.ConnectionString, FileMode.Create))
			{
				stream.SetLength(0);
				stream.Flush();
			}
		}
		
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