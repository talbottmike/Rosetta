using TransformR.Data;

namespace TransformR.DataStores
{
	public class XmlFileDataStore : DataStore
	{
		public XmlFileDataStore() 
			: base("Extensible Markup Language (xml)")
		{
		}

		public override DataTable Read()
		{
			throw new System.NotImplementedException();
		}

		public override void Write(DataTable table)
		{
			throw new System.NotImplementedException();
		}
	}
}