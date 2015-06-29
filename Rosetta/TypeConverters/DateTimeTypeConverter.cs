#region References

using System;
using System.Linq;

#endregion

namespace TransformR.TypeConverters
{
	public class DateTimeTypeConverter : TypeConverter, ITypeConverter<DateTime>
	{
		#region Methods

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(DateTime input, string format = null)
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
					return Converter.Parse<T>(input.Ticks.ToString(format));

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
		public DateTime Parse(string input)
		{
			long ticks;
			return long.TryParse(input, out ticks)
				? new DateTime(ticks)
				: DateTime.Parse(input);
		}

		public DateTime Process(DateTime input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}