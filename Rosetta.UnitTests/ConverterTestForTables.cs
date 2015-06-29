#region References

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Data;
using Rosetta.TypeCombiners;
using Rosetta.TypeConverters;

#endregion

namespace Rosetta.UnitTests
{
	[TestClass]
	public class ConverterTestForTables
	{
		#region Methods

		[TestMethod]
		public void ConvertTableOneToOneMapping()
		{
			var source = new DataTable { Columns = { "First Name", "Last Name", "Age" } };
			source.NewRow("John", "Doe", "23");
			source.NewRow("Jane", "Doe", "23");

			var mappings = new List<Mapping>
			{
				new Mapping { DestinationHeader = "Name", SourceHeaders = new[] { "First Name" }, Type = "System.String" }
			};

			var expected = new DataTable { Columns = { "Name" } };
			expected.NewRow("John");
			expected.NewRow("Jane");

			var actual = Converter.Convert(source, mappings);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMapping()
		{
			var source = new DataTable { Columns = { "First Name", "Last Name", "Age" } };
			source.NewRow("John", "Doe", "23");
			source.NewRow("Jane", "Doe", "23");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Name",
					SourceHeaders = new[] { "First Name", "Last Name" },
					Type = "System.String"
				}
			};

			var expected = new DataTable { Columns = { "Name" } };
			expected.NewRow("JohnDoe");
			expected.NewRow("JaneDoe");

			var actual = Converter.Convert(source, mappings);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMappingWithNumberCombiner()
		{
			var source = new DataTable { TableName = "Users", Columns = { "First Name", "Last Name", "Height Inches", "Height Feet" } };
			source.NewRow("John", "Doe", "11", "5");
			source.NewRow("Jane", "Doe", "6", "5");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Height In Inches",
					SourceHeaders = new[] { "Height Inches", "Height Feet" },
					Combiner = new NumberTypeCombiner(),
					Type = "System.Int32",
					PreProcesses = new[] { new ProcessSettings { Method = ProcessMethod.Multiply, Value = "12", Filter = "Height Feet" } }
				}
			};

			var expected = new DataTable { TableName = "Users", Columns = { "Height In Inches" } };
			expected.NewRow("71");
			expected.NewRow("66");

			var actual = Converter.Convert(source, mappings);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMappingWithNumericCombiner()
		{
			var source = new DataTable { Columns = { "First Name", "Last Name", "Age" } };
			source.NewRow("John", "Doe", "23");
			source.NewRow("Jane", "Doe", "23");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Name",
					SourceHeaders = new[] { "First Name", "Last Name" },
					Type = "System.String",
					Combiner = new StringTypeCombiner(delimeter: " ")
				}
			};

			var expected = new DataTable { Columns = { "Name" } };
			expected.NewRow("John Doe");
			expected.NewRow("Jane Doe");

			var actual = Converter.Convert(source, mappings);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMappingWithStringCombiner()
		{
			var source = new DataTable { Columns = { "First Name", "Last Name", "Age" } };
			source.NewRow("John", "Doe", "23");
			source.NewRow("Jane", "Doe", "23");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Name",
					SourceHeaders = new[] { "First Name", "Last Name" },
					Type = "System.String",
					Combiner = new StringTypeCombiner(delimeter: " ")
				}
			};

			var expected = new DataTable { Columns = { "Name" } };
			expected.NewRow("John Doe");
			expected.NewRow("Jane Doe");

			var actual = Converter.Convert(source, mappings);
			TestHelper.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConvertTableTwoToOneMappingWithStringCombinerAndPreProcessTrimming()
		{
			var source = new DataTable { Columns = { "First Name", "Last Name", "Middle", "Age" } };
			source.NewRow("John  ", "  Doe", "James  ", "23");
			source.NewRow(" Jane", "  Doe", "Jill  ", "21");

			var mappings = new List<Mapping>
			{
				new Mapping
				{
					DestinationHeader = "Name",
					SourceHeaders = new[] { "First Name", "Last Name" },
					Type = "System.String",
					Combiner = new StringTypeCombiner(delimeter: " "),
					PreProcesses = new[]
					{
						new ProcessSettings { Method = ProcessMethod.Trim, Filter = "First" },
						new ProcessSettings { Method = ProcessMethod.TrimLeft, Filter = "Last" },
						new ProcessSettings { Method = ProcessMethod.TrimRight, Filter = "Middle" }
					}
				}
			};

			var expected = new DataTable { Columns = { "Name" } };
			expected.NewRow("John Doe");
			expected.NewRow("Jane Doe");

			var actual = Converter.Convert(source, mappings);
			TestHelper.AreEqual(expected, actual);
		}

		#endregion
	}
}