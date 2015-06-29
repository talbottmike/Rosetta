#region References

using System;
using Rosetta.Data;

#endregion

namespace Rosetta.DataStores
{
	public class XmlFileDataStore : DataStore
	{
		#region Constructors

		public XmlFileDataStore()
			: base("Extensible Markup Language (xml)")
		{
		}

		#endregion

		#region Methods

		public override DataTable Read()
		{
			throw new NotImplementedException();
		}

		public override void Write(DataTable table)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}