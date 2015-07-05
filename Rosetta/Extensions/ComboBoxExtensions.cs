#region References

using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace Rosetta.Extensions
{
	public static class ComboBoxExtensions
	{
		#region Methods

		public static void LoadItems(this ComboBox comboBox, IEnumerable<string> items)
		{
			comboBox.Items.Clear();

			foreach (var item in items)
			{
				comboBox.Items.Add(item);
			}
		}

		#endregion
	}
}