#region References

using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace Rosetta.Extensions
{
	public static class ListBoxExtensions
	{
		#region Methods

		public static void LoadItems(this ListBox listBox, IEnumerable<string> items)
		{
			listBox.Items.Clear();

			foreach (var item in items)
			{
				listBox.Items.Add(item);
			}
		}

		#endregion
	}
}