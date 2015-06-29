#region References

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Rosetta.TypeConverters
{
	public class StringTypeConverter : TypeConverter, ITypeConverter<string>, ITypeConverter<char>
	{
		#region Methods

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(string input, string format = null)
		{
			return Converter.Parse<T>(input);
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(char input, string format = null)
		{
			var type = typeof (T).FullName;
			var trueCharacters = new List<char> { 'T', '1' };

			if (format != null)
			{
				trueCharacters.AddRange(format.ToCharArray());
				trueCharacters = trueCharacters.Distinct().ToList();
			}

			switch (type)
			{
				case "System.Boolean":
					return Converter.Parse<T>(trueCharacters.Contains(input).ToString());

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
					return Converter.Parse<T>(char.IsNumber(input) ? input.ToString() : ((byte) input).ToString());

				case "System.Char":
					return Converter.Parse<T>(input.ToString());

				case "System.String":
					return Converter.Parse<T>(input.ToString());

				case "System.DateTime":
					throw new NotSupportedException("This conversion is not supported.");

				default:
					return Converter.Parse<T>(input.ToString());
			}
		}

		/// <summary>
		/// Process the type with the provided settings.
		/// </summary>
		/// <param name="input"> The input to process. </param>
		/// <param name="settings"> The settings to configure the process. </param>
		/// <returns> The result of the type processing. </returns>
		public string Process(string input, ProcessSettings settings)
		{
			switch (settings.Method)
			{
				case ProcessMethod.Trim:
					return input.Trim();

				case ProcessMethod.TrimLeft:
					return input.TrimStart();

				case ProcessMethod.TrimRight:
					return input.TrimEnd();

				default:
					throw new NotImplementedException();
			}
		}

		public char Process(char input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		char ITypeConverter<char>.Parse(string input)
		{
			return input.First();
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		string ITypeConverter<string>.Parse(string input)
		{
			return input;
		}

		#endregion
	}
}