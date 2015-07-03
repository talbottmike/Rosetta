#region References

using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

#endregion

namespace Rosetta
{
	public static class Serializer
	{
		#region Methods

		/// <summary>
		/// JSON Deserialization
		/// </summary>
		public static T Deserialize<T>(string jsonString)
		{
			var ser = new DataContractJsonSerializer(typeof (T));
			var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
			var obj = (T) ser.ReadObject(ms);
			return obj;
		}

		/// <summary>
		/// JSON Serialization
		/// </summary>
		public static string Serialize<T>(T t)
		{
			var ser = new DataContractJsonSerializer(typeof (T));
			var ms = new MemoryStream();
			ser.WriteObject(ms, t);
			var jsonString = Encoding.UTF8.GetString(ms.ToArray());
			ms.Close();
			return jsonString;
		}

		#endregion
	}
}