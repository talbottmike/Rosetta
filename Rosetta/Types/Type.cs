#region References

using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using Rosetta.Process;

#endregion

namespace Rosetta.Types
{
	public abstract class Type
	{
		#region Constructors

		protected Type()
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

		public T Combine<T>(object input, CombineMethod method, T value)
		{
			var type = GetType();
			var inputType = input.GetType();
			var methodInfos = type.GetMethods().Where(x => x.Name == "Combine");
			var methodInfo = methodInfos.FirstOrDefault(x =>
			{
				var parameter = x.GetParameters().First();
				if (!parameter.ParameterType.IsGenericType)
				{
					return false;
				}

				var generic = parameter.ParameterType.GetGenericArguments()[0];
				return generic != null && generic.FullName == inputType.FullName;
			});

			if (methodInfo == null)
			{
				throw new ArgumentException("The type converter does not support this type.");
			}

			var genericMethod = methodInfo.MakeGenericMethod(typeof (T));
			return (T) genericMethod.Invoke(this, new[] { input, method, value });
		}

		public object Combine(IEnumerable input, string type, CombineMethod method, object value)
		{
			var toType = System.Type.GetType(type);
			if (toType == null)
			{
				throw new ArgumentException("Failed to find the target type.", nameof(type));
			}

			var myType = GetType();
			var methodInfos = myType.GetMethods().Where(x => x.Name == "Combine");
			var methodInfo = methodInfos.FirstOrDefault(x =>
			{
				var parameter = x.GetParameters().First();
				if (!parameter.ParameterType.IsGenericType)
				{
					return false;
				}

				var generic = parameter.ParameterType.GetGenericArguments()[0];
				return generic != null && generic.FullName == type;
			});

			if (methodInfo == null)
			{
				throw new ArgumentException("The type converter does not support this type.");
			}

			return methodInfo.Invoke(this, new [] { input, method, value });
		}

		public object ConvertTo(object input, string type, string format = "")
		{
			var toType = System.Type.GetType(type);
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
				return Activator.CreateInstance(myType);
			}

			var genericMethod = method.MakeGenericMethod(toType);
			return genericMethod.Invoke(this, new[] { input, format });
		}

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
			return ConvertTo(response, type).ToString();
		}

		public object Process(object value, string type, ProcessSettings settings)
		{
			if (settings == null)
			{
				return value;
			}

			var toType = System.Type.GetType(type);
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