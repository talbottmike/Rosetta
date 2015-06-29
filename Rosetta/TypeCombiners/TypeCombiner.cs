#region References

using System;
using System.Collections;
using System.Linq;

#endregion

namespace TransformR.TypeCombiners
{
	public abstract class TypeCombiner
	{
		#region Constructors

		protected TypeCombiner(CombineMethod method, string delimeter = "")
		{
			var type = GetType();
			var methods = type.GetMethods().Where(x => x.Name == "Combine");
			TypeNames = methods
				.Select(x => x.GetParameters().First().ParameterType.FullName)
				.Where(x => x != "System.Object")
				.ToArray();

			Method = method;
			Delimiter = delimeter;
		}

		#endregion

		#region Properties

		public string Delimiter { get; set; }
		public CombineMethod Method { get; set; }

		/// <summary>
		/// The type names this converter supports.
		/// </summary>
		public string[] TypeNames { get; private set; }

		#endregion

		#region Methods

		/// <summary>
		/// Combines the input values.
		/// </summary>
		/// <param name="input"> The object values to combine. </param>
		/// <returns> The new combined objects. </returns>
		public object Combine(IEnumerable input)
		{
			var type = GetType();
			var inputType = input.GetType().GetGenericArguments().FirstOrDefault();
			if (inputType == null)
			{
				throw new ArgumentException("The input is not a generic list.", nameof(input));
			}

			var methods = type.GetMethods().Where(x => x.Name == "Combine").ToList();
			var method = methods.FirstOrDefault(x =>
			{
				var parameter = x.GetParameters().First();
				var argument = parameter.ParameterType.GetGenericArguments().First();

				return parameter.ParameterType.IsGenericType && argument.FullName == inputType.FullName;
			});

			if (method == null)
			{
				throw new ArgumentException("The type converter does not support this type.", nameof(input));
			}

			return method.Invoke(this, new[] { input });
		}

		#endregion
	}
}