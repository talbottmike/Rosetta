#region References

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Configuration;
using Rosetta.DataStores;
using Rosetta.Process;

#endregion

namespace Rosetta.UnitTests
{
	[TestClass]
	public class ConvertDataStoreTests
	{
		#region Methods

		[TestMethod]
		public void ConvertTableOneToOneMapping()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age");
			var source = new MemoryDataStore(configuration);
			source.Write("John", "Doe", "23");
			source.Write("Jane", "Doe", "23");

			var mappings = new List<Mapping>
			{
				new Mapping { DestinationHeader = "Name", SourceHeaders = new[] { "First Name" }, Type = "System.String" }
			};

			configuration = DataStoreConfiguration.FromColumns("Name");
			var expected = new MemoryDataStore(configuration);
			expected.Write("John");
			expected.Write("Jane");

			var actual = new MemoryDataStore(configuration);
			Converter.Convert(source, mappings, actual);

			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMapping()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age");
			var source = new MemoryDataStore(configuration);
			source.Write("John", "Doe", "23");
			source.Write("Jane", "Doe", "23");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Name",
					SourceHeaders = new[] { "First Name", "Last Name" },
					Type = "System.String"
				}
			};

			configuration = DataStoreConfiguration.FromColumns("Name");
			var expected = new MemoryDataStore(configuration);
			expected.Write("JohnDoe");
			expected.Write("JaneDoe");

			var actual = new MemoryDataStore(configuration);
			Converter.Convert(source, mappings, actual);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMappingWithFilterPreProcessAndSumCombiner()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Height Inches", "Height Feet");
			var source = new MemoryDataStore(configuration);
			source.Write("John", "Doe", "11", "5");
			source.Write("Jane", "Doe", "6", "5");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Height In Inches",
					SourceHeaders = new[] { "Height Inches", "Height Feet" },
					CombineMethod = CombineMethod.Sum,
					Type = "System.Int32",
					PreProcesses = new[] { new ProcessSettings { Method = ProcessMethod.Multiply, Value = "12", Filter = "Height Feet" } }
				}
			};

			configuration = DataStoreConfiguration.FromColumns("Name");
			var expected = new MemoryDataStore(configuration);
			expected.Write("71");
			expected.Write("66");

			var actual = new MemoryDataStore(configuration);
			Converter.Convert(source, mappings, actual);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMappingWithJoinCombiner()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age");
			var source = new MemoryDataStore(configuration);
			source.Write("John", "Doe", "23");
			source.Write("Jane", "Doe", "23");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Name",
					SourceHeaders = new[] { "First Name", "Last Name" },
					Type = "System.String",
					CombineMethod = CombineMethod.Join,
					CombineValue = " "
				}
			};

			configuration = DataStoreConfiguration.FromColumns("Name");
			var expected = new MemoryDataStore(configuration);
			expected.Write("John Doe");
			expected.Write("Jane Doe");

			var actual = new MemoryDataStore(configuration);
			Converter.Convert(source, mappings, actual);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMappingWithJoinCombinerAndPreProcessTrimming()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Midddle Name", "Age");
			var source = new MemoryDataStore(configuration);
			source.Write("John  ", "  Doe", "James  ", "23");
			source.Write(" Jane", "  Doe", "Jill  ", "21");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Name",
					SourceHeaders = new[] { "First Name", "Last Name" },
					Type = "System.String",
					CombineMethod = CombineMethod.Join,
					CombineValue = " ",
					PreProcesses = new[]
					{
						new ProcessSettings { Method = ProcessMethod.Trim, Filter = "First" },
						new ProcessSettings { Method = ProcessMethod.TrimLeft, Filter = "Last" },
						new ProcessSettings { Method = ProcessMethod.TrimRight, Filter = "Middle" }
					}
				}
			};

			configuration = DataStoreConfiguration.FromColumns("Name");
			var expected = new MemoryDataStore(configuration);
			expected.Write("John Doe");
			expected.Write("Jane Doe");

			var actual = new MemoryDataStore(configuration);
			Converter.Convert(source, mappings, actual);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMappingWithSumCombiner()
		{
			var configuration = DataStoreConfiguration.FromColumns("First Name", "Last Name", "Age");
			var source = new MemoryDataStore(configuration);
			source.Write("John", "Doe", "23");
			source.Write("Jane", "Doe", "23");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Name",
					SourceHeaders = new[] { "First Name", "Last Name" },
					Type = "System.String",
					CombineValue = " "
				}
			};

			configuration = DataStoreConfiguration.FromColumns("Name");
			var expected = new MemoryDataStore(configuration);
			expected.Write("John Doe");
			expected.Write("Jane Doe");

			var actual = new MemoryDataStore(configuration);
			Converter.Convert(source, mappings, actual);
			TestHelper.AreEqual(expected, actual);
		}

		#endregion
	}
}