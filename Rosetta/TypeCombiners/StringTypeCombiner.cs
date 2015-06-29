#region References

using System;
using System.Collections.Generic;

#endregion

namespace TransformR.TypeCombiners
{
	public class StringTypeCombiner : TypeCombiner, ITypeCombiner<string>
	{
		#region Constructors

		public StringTypeCombiner(CombineMethod method = CombineMethod.Join, string delimeter = "")
			: base(method, delimeter)
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <returns> The items in a combined format. </returns>
		public string Combine(IEnumerable<string> items)
		{
			switch (Method)
			{
				case CombineMethod.Join:
					return string.Join(Delimiter, items);

				default:
					throw new NotImplementedException();
			}
		}

		#endregion
	}
}