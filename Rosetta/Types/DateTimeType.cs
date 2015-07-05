#region References

using System;
using System.Collections.Generic;
using System.Linq;
using Rosetta.Configuration;

#endregion

namespace Rosetta.Types
{
	public class DateTimeType : Type,
		ITypeConverter<DateTime>, ITypeCombiner<DateTime>,
		ITypeConverter<TimeSpan>, ITypeCombiner<TimeSpan>
	{
		#region Methods

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		public DateTime Combine(IEnumerable<DateTime> items, CombineMethod method, string delimiter)
		{
			var ticks = items.Sum(x => x.Ticks);
			return new DateTime(ticks);
		}

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		public TimeSpan Combine(IEnumerable<TimeSpan> items, CombineMethod method, string delimiter)
		{
			var ticks = items.Sum(x => x.Ticks);
			return new TimeSpan(ticks);
		}

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
					DateTime formatValue;
					long formatNumberValue;
					var result = false;

					if (DateTime.TryParse(format, out formatValue))
					{
						result = input == formatValue;
					}
					else if (long.TryParse(format, out formatNumberValue))
					{
						formatValue = new DateTime(formatNumberValue);
						result = input == formatValue;
					}

					return Converter.Parse<T>(result.ToString());

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
					return Converter.Parse<T>(input.Ticks.ToString());

				default:
					return Converter.Parse<T>(input.ToString());
			}
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(TimeSpan input, string format = null)
		{
			var type = typeof (T).FullName;

			switch (type)
			{
				case "System.Boolean":
					TimeSpan formatValue;
					return Converter.Parse<T>((Converter.TryParse(format, out formatValue) && input == formatValue).ToString());

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
					return Converter.Parse<T>(input.Ticks.ToString());

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

		/// <summary>
		/// Process the type with the provided settings.
		/// </summary>
		/// <param name="input"> The input to process. </param>
		/// <param name="settings"> The settings to configure the process. </param>
		/// <returns> The result of the type processing. </returns>
		public TimeSpan Process(TimeSpan input, ProcessSettings settings)
		{
			return input;
		}

		public DateTime Process(DateTime input, ProcessSettings settings)
		{
			return input;
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out TimeSpan value)
		{
			long ticks;
			if (long.TryParse(input, out ticks))
			{
				value = new TimeSpan(ticks);
				return true;
			}

			return TimeSpan.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out DateTime value)
		{
			long ticks;
			if (long.TryParse(input, out ticks))
			{
				value = new DateTime(ticks);
				return true;
			}

			return DateTime.TryParse(input, out value);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		TimeSpan ITypeConverter<TimeSpan>.Parse(string input)
		{
			long ticks;
			return long.TryParse(input, out ticks)
				? new TimeSpan(ticks)
				: TimeSpan.Parse(input);
		}

		#endregion
	}
}