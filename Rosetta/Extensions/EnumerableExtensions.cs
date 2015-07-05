#region References

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Rosetta.Extensions
{
	public static class EnumerableExtensions
	{
		#region Methods

		public static ulong Sum(this IEnumerable<ulong> source)
		{
			var sum = 0UL;
			foreach (var number in source)
			{
				sum += number;
			}
			return sum;
		}

		public static ulong? Sum(this IEnumerable<ulong?> source)
		{
			var sum = 0UL;
			foreach (var nullable in source)
			{
				if (nullable.HasValue)
				{
					sum += nullable.GetValueOrDefault();
				}
			}
			return sum;
		}

		public static ulong Sum<T>(this IEnumerable<T> source, Func<T, ulong> selector)
		{
			return source.Select(selector).Sum();
		}

		public static ulong? Sum<T>(this IEnumerable<T> source, Func<T, ulong?> selector)
		{
			return source.Select(selector).Sum();
		}

		#endregion
	}
}