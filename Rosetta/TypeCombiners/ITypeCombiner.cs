#region References

using System.Collections.Generic;

#endregion

namespace Rosetta.TypeCombiners
{
	public interface ITypeCombiner<T>
	{
		#region Methods

		/// <summary>
		/// Combines the list of items using the provided method.
		/// </summary>
		/// <param name="items"> The items to be combined. </param>
		/// <returns> The items in a combined format. </returns>
		T Combine(IEnumerable<T> items);

		#endregion
	}
}