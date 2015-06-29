#region References

using System;
using System.Linq;
using System.Reflection;

#endregion

namespace Rosetta.TypeConverters
{
	public abstract class TypeConverter
	{
		#region Constructors

		protected TypeConverter()
		{
			var type = GetType();
			var methods = type.GetMethods().Where(x => x.Name == "ConvertTo");
			TypeNames = methods
				.Select(x => x.GetParameters().First().ParameterType.FullName)
				.Where(x => x != "System.Object")
				.ToArray();
		}

		#endregion

		#region Properties

		/// <summary>
		/// The type names this converter supports.
		/// </summary>
		public string[] TypeNames { get; private set; }

		#endregion

		#region Methods

		/// <summary>
		/// Convert the input to a specific type with optional formatting.
		/// </summary>
		/// <param name="input"> The object to convert. </param>
		/// <param name="format"> The optional format to assist in conversion. </param>
		/// <returns> The new object converted to. </returns>
		public T ConvertTo<T>(object input, string format = null)
		{
			var type = GetType();
			var inputType = input.GetType();
			var methods = type.GetMethods().Where(x => x.Name == "ConvertTo");
			var method = methods.FirstOrDefault(x => x.GetParameters().First().ParameterType.FullName == inputType.FullName);

			if (method == null)
			{
				throw new ArgumentException("The type converter does not support this type.");
			}

			var genericMethod = method.MakeGenericMethod(typeof (T));
			return (T) genericMethod.Invoke(this, new[] { input, format });
		}

		public object ConvertTo(object input, string type, string format = "")
		{
			var toType = Type.GetType(type);
			if (toType == null)
			{
				throw new ArgumentException("Failed to find the target type.", nameof(type));
			}

			var myType = GetType();
			var inputType = input.GetType();
			var methods = myType.GetMethods().Where(x => x.Name == "ConvertTo");
			var method = methods.FirstOrDefault(x => x.GetParameters().First().ParameterType.FullName == inputType.FullName);

			if (method == null)
			{
				throw new ArgumentException("The type converter does not support this type.");
			}

			var genericMethod = method.MakeGenericMethod(toType);
			return genericMethod.Invoke(this, new[] { input, format });
		}

		/// <summary>
		/// Parses the object from a string.
		/// </summary>
		/// <param name="typeName"> </param>
		/// <param name="input"> </param>
		/// <returns> </returns>
		public object Parse(string typeName, string input)
		{
			var methods = GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			var method = methods.FirstOrDefault(x => x.ReturnType.FullName == typeName && (x.Name.Equals("Parse") || x.Name.EndsWith(".Parse")));

			if (method == null)
			{
				throw new ArgumentException("The type converter does not support this type.");
			}

			return method.Invoke(this, new object[] { input });
		}

		public string PostProcess(object value, string type, ProcessSettings settings)
		{
			var response = settings == null ? value : Process(value, type, settings);
			return ConvertTo<string>(response);
		}

		public object Process(object value, string type, ProcessSettings settings)
		{
			if (settings == null)
			{
				return value;
			}

			var toType = Type.GetType(type);
			if (toType == null)
			{
				throw new ArgumentException("Failed to find the target type.", nameof(type));
			}

			var myType = GetType();
			var inputType = value.GetType();
			var methods = myType.GetMethods().Where(x => x.Name == "Process");
			var method = methods.FirstOrDefault(x => x.GetParameters().First().ParameterType.FullName == inputType.FullName);

			if (method == null)
			{
				throw new ArgumentException("The type converter does not support this type.");
			}

			return method.Invoke(this, new[] { value, settings });
		}

		#endregion
	}
}