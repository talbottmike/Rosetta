#region References

#endregion

#region References

using System;
using Rosetta.Process;

#endregion

namespace Rosetta.Types
{
	public class DecimalType : Type, ITypeConverter<decimal>, ITypeConverter<float>, ITypeConverter<double>
	{
		#region Methods

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(decimal input, string format = null)
		{
			return Convert<T>(input, format);
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(float input, string format = null)
		{
			return Convert<T>((decimal) input, format);
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(double input, string format = null)
		{
			return Convert<T>((decimal) input, format);
		}

		public decimal Process(decimal input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		public float Process(float input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		public double Process(double input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		private static T Convert<T>(decimal input, string format)
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
				case "System.Char":
				case "System.String":
					return Converter.Parse<T>(input.ToString(format));

				default:
					return Converter.Parse<T>(input.ToString(format));
			}
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