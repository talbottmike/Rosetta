#region References

using System;
using System.Collections.Generic;
using System.Linq;
using Rosetta.Process;

#endregion

namespace Rosetta.Types
{
	public class BooleanType : Type, ITypeConverter<bool>, ITypeCombiner<bool>
	{
		#region Methods

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		public bool Combine(IEnumerable<bool> items, CombineMethod method, bool delimiter)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(bool input, string format = null)
		{
			var type = typeof (T).FullName;

			switch (type)
			{
				case "System.Boolean":
					return Converter.Parse<T>(input.ToString());

				case "System.Byte":
				case "System.SByte":
				case "System.Int16":
				case "System.UInt16":
				case "System.Int32":
				case "System.UInt32":
				case "System.Int64":
				case "System.UInt64":
				case "System.Decimal":
				case "System.Double":
				case "System.Single":
					return Converter.Parse<T>(input ? "1" : "0");

				case "System.Char":
					return Converter.Parse<T>(input.ToString().First().ToString());

				case "System.String":
					return Converter.Parse<T>(input.ToString());

				case "System.DateTime":
					throw new NotSupportedException("This conversion is not supported.");

				default:
					return Converter.Parse<T>(input.ToString());
			}
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		public bool Parse(string input)
		{
			return bool.Parse(input);
		}

		/// <summary>
		/// Process the type with the provided settings.
		/// </summary>
		/// <param name="input"> The input to process. </param>
		/// <param name="settings"> The settings to configure the process. </param>
		/// <returns> The result of the type processing. </returns>
		public bool Process(bool input, ProcessSettings settings)
		{
			var value = Converter.Convert<bool>(settings.Value);

			switch (settings.Method)
			{
				case ProcessMethod.And:
					return input & value;

				case ProcessMethod.Or:
					return input | value;

				case ProcessMethod.Xor:
					return input ^ value;

				default:
					throw new NotSupportedException("This method is not supported.");
			}
		}

		#endregion
	}
}