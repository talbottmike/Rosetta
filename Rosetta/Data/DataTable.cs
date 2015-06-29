#region References

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace TransformR.Data
{
	public class DataTable
	{
		#region Constructors

		public DataTable()
			: this(string.Empty)
		{
		}

		public DataTable(string tableName)
		{
			Columns = new List<string>();
			Rows = new List<DataRow>();
			TableName = tableName;
		}

		#endregion

		#region Properties

		public IList<string> Columns { get; }
		public IList<DataRow> Rows { get; }
		public string TableName { get; set; }

		#endregion

		#region Methods

		public DataRow NewRow()
		{
			var response = new DataRow();
			foreach (var column in Columns)
			{
				response.Add(column, string.Empty);
			}
			return response;
		}

		public void NewRow(params string[] values)
		{
			var keys = Columns.ToList();
			if (keys.Count != values.Length)
			{
				throw new ArgumentException("The input values do not match the column count.", nameof(values));
			}

			var row = NewRow();

			for (var i = 0; i < keys.Count; i++)
			{
				row[keys[i]] = values[i];
			}

			Rows.Add(row);
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