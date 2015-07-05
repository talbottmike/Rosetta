#region References

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rosetta.Configuration;

#endregion

namespace Rosetta.UnitTests.Configuration
{
	[TestClass]
	public class ProcessSettingsTests
	{
		#region Methods

		[TestMethod]
		public void DisplayName()
		{
			var processSettings = new ProcessSettings
			{
				Filter = "Header",
				Method = ProcessMethod.Add,
				Value = "10"
			};

			var expected = "Header,Add,10";
			var actual = processSettings.DisplayName;

			Assert.AreEqual(expected, actual);
		}

		#endregion
	}
}