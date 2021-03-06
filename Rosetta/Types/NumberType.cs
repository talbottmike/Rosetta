#region References

using System;
using System.Collections.Generic;
using System.Linq;
using Rosetta.Configuration;
using Rosetta.Extensions;

#endregion

namespace Rosetta.Types
{
	public class NumberType : Type,
		ITypeConverter<byte>, ITypeConverter<sbyte>, ITypeCombiner<byte>, ITypeCombiner<sbyte>,
		ITypeConverter<short>, ITypeConverter<ushort>, ITypeCombiner<short>, ITypeCombiner<ushort>,
		ITypeConverter<int>, ITypeConverter<uint>, ITypeCombiner<int>, ITypeCombiner<uint>,
		ITypeConverter<long>, ITypeConverter<ulong>, ITypeCombiner<long>, ITypeCombiner<ulong>
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
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		public byte Combine(IEnumerable<byte> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return (byte) Enumerable.Sum(items, x => x);

				case CombineMethod.Join:
					return byte.Parse(string.Join("", items.Select(x => x.ToString())));

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
		public sbyte Combine(IEnumerable<sbyte> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return (sbyte) items.Sum(x => x);

				case CombineMethod.Join:
					return sbyte.Parse(string.Join("", items.Select(x => x.ToString())));

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
		public short Combine(IEnumerable<short> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return (short) items.Sum(x => x);

				case CombineMethod.Join:
					return short.Parse(string.Join("", items.Select(x => x.ToString())));

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
		public ushort Combine(IEnumerable<ushort> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return (ushort) Enumerable.Sum(items, x => x);

				case CombineMethod.Join:
					return ushort.Parse(string.Join("", items.Select(x => x.ToString())));

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
		public uint Combine(IEnumerable<uint> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return (uint) Enumerable.Sum(items, x => x);

				case CombineMethod.Join:
					return uint.Parse(string.Join("", items.Select(x => x.ToString())));

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
		public long Combine(IEnumerable<long> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return items.Sum(x => x);

				case CombineMethod.Join:
					return long.Parse(string.Join("", items.Select(x => x.ToString())));

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
		public ulong Combine(IEnumerable<ulong> items, CombineMethod method, string delimiter)
		{
			switch (method)
			{
				case CombineMethod.Sum:
					return items.Sum();

				case CombineMethod.Join:
					return ulong.Parse(string.Join("", items.Select(x => x.ToString())));

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
			return (int) Process((long) input, settings);
		}

		public uint Process(uint input, ProcessSettings settings)
		{
			return (uint) Process((ulong) input, settings);
		}

		public long Process(long input, ProcessSettings settings)
		{
			switch (settings.Method)
			{
				case ProcessMethod.Add:
					return input + Converter.Convert<long>(settings.Value);

				case ProcessMethod.Divide:
					return input / Converter.Convert<long>(settings.Value);

				case ProcessMethod.Multiply:
					return input * Converter.Convert<long>(settings.Value);

				case ProcessMethod.Subtract:
					return input - Converter.Convert<long>(settings.Value);

				default:
					throw new NotImplementedException();
			}
		}

		public ulong Process(ulong input, ProcessSettings settings)
		{
			switch (settings.Method)
			{
				case ProcessMethod.Add:
					return input + Converter.Convert<ulong>(settings.Value);

				case ProcessMethod.Divide:
					return input / Converter.Convert<ulong>(settings.Value);

				case ProcessMethod.Multiply:
					return input * Converter.Convert<ulong>(settings.Value);

				case ProcessMethod.Subtract:
					return input - Converter.Convert<ulong>(settings.Value);

				default:
					throw new NotImplementedException();
			}
		}

		public byte Process(byte input, ProcessSettings settings)
		{
			return (byte) Process((ulong) input, settings);
		}

		public sbyte Process(sbyte input, ProcessSettings settings)
		{
			return (sbyte) Process((long) input, settings);
		}

		public short Process(short input, ProcessSettings settings)
		{
			return (short) Process((long) input, settings);
		}

		public ushort Process(ushort input, ProcessSettings settings)
		{
			return (ushort) Process((ulong) input, settings);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out int value)
		{
			return int.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out uint value)
		{
			return uint.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out long value)
		{
			return long.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out ulong value)
		{
			return ulong.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out byte value)
		{
			return byte.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out sbyte value)
		{
			return sbyte.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out short value)
		{
			return short.TryParse(input, out value);
		}

		/// <summary>
		/// Try to parses the object from a string.
		/// </summary>
		/// <param name="input"> The input to parse. </param>
		/// <param name="value"> The value if the parse was successful. </param>
		/// <returns> True if parse was successful; false if otherwise. </returns>
		public bool TryParse(string input, out ushort value)
		{
			return ushort.TryParse(input, out value);
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		ushort ITypeConverter<ushort>.Parse(string input)
		{
			var value = decimal.Parse(input);

			if (value < ushort.MinValue)
			{
				return ushort.MinValue;
			}

			if (value > ushort.MaxValue)
			{
				return ushort.MaxValue;
			}

			return (ushort) value;
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		short ITypeConverter<short>.Parse(string input)
		{
			var value = decimal.Parse(input);

			if (value < short.MinValue)
			{
				return short.MinValue;
			}

			if (value > short.MaxValue)
			{
				return short.MaxValue;
			}

			return (short) value;
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		ulong ITypeConverter<ulong>.Parse(string input)
		{
			var value = decimal.Parse(input);

			if (value < ulong.MinValue)
			{
				return ulong.MinValue;
			}

			if (value > ulong.MaxValue)
			{
				return ulong.MaxValue;
			}

			return (ulong) value;
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		sbyte ITypeConverter<sbyte>.Parse(string input)
		{
			var value = decimal.Parse(input);

			if (value < sbyte.MinValue)
			{
				return sbyte.MinValue;
			}

			if (value > sbyte.MaxValue)
			{
				return sbyte.MaxValue;
			}

			return (sbyte) value;
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		byte ITypeConverter<byte>.Parse(string input)
		{
			var value = decimal.Parse(input);

			if (value < byte.MinValue)
			{
				return byte.MinValue;
			}

			if (value > byte.MaxValue)
			{
				return byte.MaxValue;
			}

			return (byte) value;
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		long ITypeConverter<long>.Parse(string input)
		{
			var value = decimal.Parse(input);

			if (value < long.MinValue)
			{
				return long.MinValue;
			}

			if (value > long.MaxValue)
			{
				return long.MaxValue;
			}

			return (long) value;
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		uint ITypeConverter<uint>.Parse(string input)
		{
			var value = decimal.Parse(input);

			if (value < uint.MinValue)
			{
				return uint.MinValue;
			}

			if (value > uint.MaxValue)
			{
				return uint.MaxValue;
			}

			return (uint) value;
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="input"> </param>
		/// <returns> </returns>
		int ITypeConverter<int>.Parse(string input)
		{
			var value = decimal.Parse(input);

			if (value < int.MinValue)
			{
				return int.MinValue;
			}

			if (value > int.MaxValue)
			{
				return int.MaxValue;
			}

			return (int) value;
		}

		#endregion
	}
}