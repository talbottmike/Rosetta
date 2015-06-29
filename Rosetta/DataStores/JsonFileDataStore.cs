using TransformR.Data;

namespace TransformR.DataStores
{
	public class JsonFileDataStore : DataStore
	{
		#region Constructors

		public JsonFileDataStore()
			: base("JavaScript Object Notation (json)")
		{
		}

		#endregion

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