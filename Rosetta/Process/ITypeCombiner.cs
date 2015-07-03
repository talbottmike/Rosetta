#region References

using System.Collections.Generic;

#endregion

namespace Rosetta.Process
{
	public interface ITypeCombiner<T>
	{
		#region Methods

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <param name="method"> The method used to combine the items. </param>
		/// <param name="delimiter"> The delimiter used when combining the item. </param>
		/// <returns> The items in a combined format. </returns>
		T Combine(IEnumerable<T> items, CombineMethod method, T delimiter);

		#endregion
	}
}