#region References

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Rosetta.Data;
using Rosetta.Process;
using Rosetta.Types;
using Type = Rosetta.Types.Type;

#endregion

namespace Rosetta
{
	/// <summary>
	/// Converts data rows from one format to another. This could be from string to decimal.
	/// </summary>
	public static class Converter
	{
		#region Constructors

		static Converter()
		{
			Providers = new Dictionary<string, Type>();
			var providers = new Type[]
			{
				new BooleanType(),
				new DateTimeType(),
				new DecimalType(),
				new NumberType(),
				new StringType()
			};

			foreach (var provider in providers)
			{
				foreach (var typeName in provider.TypeNames)
				{
					Providers.Add(typeName, provider);
				}
			}
		}

		#endregion

		#region Properties

		public static IDictionary<string, Type> Providers { get; set; }

		#endregion

		#region Methods

		public static DataTable Convert(DataTable source, IEnumerable<Mapping> mappings)
		{
			var response = new DataTable(source.TableName);
			var mappingList = mappings as IList<Mapping> ?? mappings.ToList();

			foreach (var mapping in mappingList)
			{
				response.Columns.Add(mapping.DestinationHeader);
			}

			foreach (var sourceRow in source.Rows)
			{
				var row = response.NewRow();

				foreach (var mapping in mappingList)
				{
					var sourceValues = CreateList(mapping.Type);

					foreach (var sourceHeader in mapping.SourceHeaders)
					{
						var value = Convert(sourceRow[sourceHeader], mapping.Type);

						if (mapping.PreProcesses != null)
						{
							value = mapping.PreProcesses
								.Where(processSettings => string.IsNullOrEmpty(processSettings.Filter) || sourceHeader.Contains(processSettings.Filter))
								.Aggregate(value, (current, processSettings) => PreProcess(current, mapping.Type, processSettings));
						}

						sourceValues.Add(value);
					}

					var combined = Combiner.Combine(sourceValues, mapping.Type, mapping.CombineMethod, mapping.CombineValue);
					row[mapping.DestinationHeader] = PostProcess(combined, mapping.Type, mapping.PostProcess);
				}

				response.Rows.Add(row);
			}

			return response;
		}

		public static T Convert<T>(object input, string format = null)
		{
			return Providers[input.GetType().FullName].ConvertTo<T>(input, format);
		}

		public static object Convert(object input, string type, string format = null)
		{
			return Providers[input.GetType().FullName].ConvertTo(input, type, format);
		}

		public static IList CreateList(string type)
		{
			var myType = System.Type.GetType(type);
			var genericListType = typeof (List<>).MakeGenericType(myType);
			return (IList) Activator.CreateInstance(genericListType);
		}

		public static T Parse<T>(string input)
		{
			var type = typeof (T);

			if (!Providers.ContainsKey(type.FullName))
			{
				throw new ArgumentException("This type is not supported.", nameof(type));
			}

			return (T) Providers[type.FullName].Parse(type.FullName, input);
		}

		private static string PostProcess(object value, string type, ProcessSettings settings)
		{
			return Providers[type].PostProcess(value, type, settings);
		}

		private static object PreProcess(object value, string type, ProcessSettings settings)
		{
			return Providers[type].Process(value, type, settings);
		}

		#endregion
	}
}