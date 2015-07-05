#region References

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Configuration;

#endregion

namespace Rosetta.UnitTests.Configuration
{
	[TestClass]
	public class MappingTests
	{
		#region Methods

		[TestMethod]
		public void DisplayName()
		{
			var mapping = new Mapping
			{
				CombineMethod = CombineMethod.Join,
				CombineValue = " ",
				DestinationHeader = "Destination",
				PostProcess = new ProcessSettings(),
				SourceHeaders = new List<string> { "Source1", "Source2" },
				Type = "System.String"
			};

			var expected = "[Source1,Source2],Destination,Join, ,System.String";
			var actual = mapping.DisplayName;

			Assert.AreEqual(expected, actual);
		}

		#endregion
	}
}