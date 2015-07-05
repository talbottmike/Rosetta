#region References

using System;
using System.Collections.Generic;
using System.Linq;
using Rosetta.Configuration;

#endregion

namespace Rosetta.Types
{
	public class DecimalType : Type,
		ITypeConverter<decimal>, ITypeCombiner<decimal>,
		ITypeConverter<float>, ITypeCombiner<float>,
		ITypeConverter<double>, ITypeCombiner<double>
	{
		#region Methods

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		public decimal Combine(IEnumerable<decimal> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return items.Sum();

				case CombineMethod.Join:
					return decimal.Parse(string.Join("", items.Select(x => x.ToString())));

				default:
					throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		public float Combine(IEnumerable<float> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return items.Sum();

				case CombineMethod.Join:
					return float.Parse(string.Join("", items.Select(x => x.ToString())));

				default:
					throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		public double Combine(IEnumerable<double> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return items.Sum();

				case CombineMethod.Join:
					return double.Parse(string.Join("", items.Select(x => x.ToString())));

				default:
					throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(decimal input, string format = null)
		{
			var type = typeof (T).FullName;

			switch (type)
			{
				case "System.Boolean":
					return Converter.Parse<T>((input > 0).ToString());

				case "System.DateTime":
					return Converter.Parse<T>(input.ToString(format ?? "0"));

				case "System.Byte":
				case "System.SByte":
				case "System.Int16":
				case "System.UInt16":
				case "System.Int32":
				case "System.UInt32":
				case "System.Int64":
				case "System.UInt64":
					return Converter.Parse<T>(input.ToString(format ?? "0"));

				case "System.Decimal":
				case "System.Double":
				case "System.Single":
					return Converter.Parse<T>(input.ToString(format ?? "G"));

				default:
					return Converter.Parse<T>(input.ToString(format));
			}
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(float input, string format = null)
		{
			var type = typeof (T).FullName;

			switch (type)
			{
				case "System.Boolean":
					return Converter.Parse<T>((input > 0).ToString());

				case "System.DateTime":
					return Converter.Parse<T>(input.ToString(format ?? "0"));

				case "System.Byte":
				case "System.SByte":
				case "System.Int16":
				case "System.UInt16":
				case "System.Int32":
				case "System.UInt32":
				case "System.Int64":
				case "System.UInt64":
					return Converter.Parse<T>(input.ToString(format ?? "0"));

				case "System.Decimal":
				case "System.Double":
				case "System.Single":
					return Converter.Parse<T>(input.ToString(format ?? "F16"));

				default:
					return Converter.Parse<T>(input.ToString(format));
			}
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(double input, string format = null)
		{
			var type = typeof (T).FullName;

			switch (type)
			{
				case "System.Boolean":
					return Converter.Parse<T>((input > 0).ToString());

				case "System.DateTime":
					return Converter.Parse<T>(input.ToString(format ?? "0"));

				case "System.Byte":
				case "System.SByte":
				case "System.Int16":
				case "System.UInt16":
				case "System.Int32":
				case "System.UInt32":
				case "System.Int64":
				case "System.UInt64":
					return Converter.Parse<T>(input.ToString(format ?? "0"));

				case "System.Decimal":
				case "System.Double":
				case "System.Single":
					return Converter.Parse<T>(input.ToString(format ?? "F16"));

				default:
					return Converter.Parse<T>(input.ToString(format));
			}
		}

		public decimal Process(decimal input, ProcessSettings settings)
		{
			switch (settings.Method)
			{
				case ProcessMethod.Add:
					return input + Converter.Convert<decimal>(settings.Value);

				case ProcessMethod.Divide:
					return input / Converter.Convert<decimal>(settings.Value);

				case ProcessMethod.Multiply:
					return input * Converter.Convert<decimal>(settings.Value);

				case ProcessMethod.Subtract:
					return input - Converter.Convert<decimal>(settings.Value);

				default:
					throw new NotImplementedException();
			}
		}

		public float Process(float input, ProcessSettings settings)
		{
			return (float) Process((decimal) input, settings);
		}

		public double Process(double input, ProcessSettings settings)
		{
			return (double) Process((decimal) input, settings);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out decimal value)
		{
			return decimal.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out float value)
		{
			return float.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out double value)
		{
			return double.TryParse(input, out value);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		decimal ITypeConverter<decimal>.Parse(string input)
		{
			return decimal.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		double ITypeConverter<double>.Parse(string input)
		{
			return double.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		float ITypeConverter<float>.Parse(string input)
		{
			return float.Parse(input);
		}

		#endregion
	}
}