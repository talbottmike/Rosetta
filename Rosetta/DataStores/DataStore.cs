#region References

using System;
using System.Collections.Generic;
using Rosetta.Configuration;

#endregion

namespace Rosetta.DataStores
{
	public abstract class DataStore
	{
		#region Constructors

		protected DataStore()
			: this(new DataStoreConfiguration())
		{
		}

		protected DataStore(DataStoreConfiguration configuration)
		{
			Configuration = configuration;
		}

		#endregion

		#region Properties

		public DataStoreConfiguration Configuration { get; set; }

		#endregion

		#region Methods

		public DataRow NewRow()
		{
			var response = new DataRow();
			foreach (var column in Configuration.Columns)
			{
				response.Add(column.Name, string.Empty);
			}
			return response;
		}

		public DataRow NewRow(params string[] values)
		{
			var keys = Configuration.Columns;

			if (keys.Count != values.Length)
			{
				throw new ArgumentException("The input values do not match the column count.", nameof(values));
			}

			var row = NewRow();

			for (var i = 0; i < keys.Count; i++)
			{
				row[keys[i].Name] = values[i];
			}

			return row;
		}

		public virtual void Initialize()
		{
		}

		public abstract IEnumerable<DataRow> Read();
		public abstract void Write(DataRow row);

		public void Write(params string[] values)
		{
			Write(NewRow(values));
		}

		#endregion

		#region Classes

		public class DataRow : Dictionary<string, string>
		{
			#region Constructors

			internal DataRow()
			{
			}

			#endregion
		}

		#endregion
	}
}