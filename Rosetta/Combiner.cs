#region References

using System.Collections;
using System.Collections.Generic;
using Rosetta.Types;

#endregion

namespace Rosetta
{
	public static class Combiner
	{
		#region Constructors

		static Combiner()
		{
			Providers = new Dictionary<string, Type>();
			var types = new Type[]
			{
				new BooleanType(),
				new DateTimeType(),
				new DecimalType(),
				new NumberType(),
				new StringType()
			};

			foreach (var type in types)
			{
				foreach (var typeName in type.TypeNames)
				{
					Providers.Add(typeName, type);
				}
			}
		}

		#endregion

		#region Properties

		public static IDictionary<string, Type> Providers { get; set; }

		#endregion

		#region Methods

		public static object Combine(IEnumerable input, string type, CombineMethod method, object value)
		{
			return Providers[type].Combine(input, type, method, value);
		}

		public static T Combine<T>(IEnumerable<T> input, string type, CombineMethod method, T value)
		{
			return Providers[type].Combine(input, method, value);
		}

		#endregion
	}
}