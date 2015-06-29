#region References

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Rosetta.TypeCombiners
{
	public class NumberTypeCombiner : TypeCombiner, ITypeCombiner<int>, ITypeCombiner<long>
	{
		#region Constructors

		public NumberTypeCombiner(CombineMethod method = CombineMethod.Sum, string delimeter = "")
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
		public long Combine(IEnumerable<long> items)
		{
			switch (Method)
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
		/// <returns> The items in a combined format. </returns>
		public int Combine(IEnumerable<int> items)
		{
			switch (Method)
			{
				case CombineMethod.Sum:
					return items.Sum(x => x);

				case CombineMethod.Join:
					return int.Parse(string.Join("", items.Select(x => x.ToString())));

				default:
					throw new NotImplementedException();
			}
		}

		#endregion
	}
}