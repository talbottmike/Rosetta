#region References

using System.Collections.Generic;

#endregion

namespace Rosetta.Extensions
{
	public static class ListExtensions
	{
		#region Methods

		public static void AddRange<T>(this IList<T> list, IEnumerable<T> items)
		{
			foreach (var item in items)
			{
				list.Add(item);
			}
		}

		#endregion
	}
}