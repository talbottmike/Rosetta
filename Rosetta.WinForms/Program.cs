﻿#region References

using System;
using System.Windows.Forms;

#endregion

namespace Rosetta.WinForms
{
	internal static class Program
	{
		#region Methods

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		#endregion
	}
}