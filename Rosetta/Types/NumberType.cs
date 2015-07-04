#region References

#endregion

#region References

using System;
using System.Collections.Generic;
using System.Linq;
using Rosetta.Process;

#endregion

namespace Rosetta.Types
{
	public class NumberType : Type, ITypeConverter<byte>, ITypeConverter<sbyte>, ITypeConverter<short>, ITypeConverter<ushort>, ITypeConverter<int>, ITypeConverter<uint>, ITypeConverter<long>, ITypeConverter<ulong>, ITypeCombiner<int>
	{
		#region Methods

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		public int Combine(IEnumerable<int> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return items.Sum(x => x);

				case CombineMethod.Join:
					return int.Parse(string.Join("", items.Select(x => x.ToString())));

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
		public T ConvertTo<T>(int input, string format = null)
		{
			return ConvertTo<T>((long) input);
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(uint input, string format = null)
		{
			return ConvertTo<T>((ulong) input);
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(long input, string format = null)
		{
			var type = typeof (T).FullName;

			switch (type)
			{
				case "System.Boolean":
					return Converter.Parse<T>((input > 0).ToString());

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
				case "System.DateTime":
				case "System.Char":
				case "System.String":
					return Converter.Parse<T>(input.ToString(format));

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
		public T ConvertTo<T>(ulong input, string format = null)
		{
			var type = typeof (T).FullName;

			switch (type)
			{
				case "System.Boolean":
					return Converter.Parse<T>((input > 0).ToString());

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
				case "System.DateTime":
				case "System.Char":
				case "System.String":
					return Converter.Parse<T>(input.ToString(format));

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
		public T ConvertTo<T>(byte input, string format = null)
		{
			return ConvertTo<T>((ulong) input);
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(sbyte input, string format = null)
		{
			return ConvertTo<T>((long) input);
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(short input, string format = null)
		{
			return ConvertTo<T>((long) input);
		}

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(ushort input, string format = null)
		{
			return ConvertTo<T>((ulong) input);
		}

		public int Process(int input, ProcessSettings settings)
		{
			switch (settings.Method)
			{
				case ProcessMethod.Add:
					return input + Converter.Convert<int>(settings.Value);

				case ProcessMethod.Divide:
					return input / Converter.Convert<int>(settings.Value);

				case ProcessMethod.Multiply:
					return input * Converter.Convert<int>(settings.Value);

				case ProcessMethod.Subtract:
					return input - Converter.Convert<int>(settings.Value);

				default:
					throw new NotImplementedException();
			}
		}

		public uint Process(uint input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		public long Process(long input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		public ulong Process(ulong input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		public byte Process(byte input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		public sbyte Process(sbyte input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		public short Process(short input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		public ushort Process(ushort input, ProcessSettings settings)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		ushort ITypeConverter<ushort>.Parse(string input)
		{
			return ushort.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		short ITypeConverter<short>.Parse(string input)
		{
			return short.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		ulong ITypeConverter<ulong>.Parse(string input)
		{
			return ulong.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		sbyte ITypeConverter<sbyte>.Parse(string input)
		{
			return sbyte.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		byte ITypeConverter<byte>.Parse(string input)
		{
			return byte.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		long ITypeConverter<long>.Parse(string input)
		{
			return long.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		uint ITypeConverter<uint>.Parse(string input)
		{
			return uint.Parse(input);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		int ITypeConverter<int>.Parse(string input)
		{
			return string.IsNullOrWhiteSpace(input) ? 0 : int.Parse(input);
		}

		#endregion
	}
}