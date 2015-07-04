#region References

using System;
using System.IO;
using System.Windows.Forms;
using Rosetta.Configuration;

#endregion

namespace Rosetta.WinForms
{
	public partial class DataSourceConfigurationControl : UserControl
	{
		#region Fields

		private DataStoreConfiguration _configuration;
		private string _fullName;
		private bool _isSource;

		#endregion

		#region Constructors

		public DataSourceConfigurationControl()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		public void LoadConfiguration(DataStoreConfiguration configuration)
		{
			_configuration = configuration;
			SqlConnectionString.Text = _configuration.ConnectionString;
			FileConnectionString.Text = _configuration.ConnectionString;
		}

		public DataStoreConfiguration ReadConfiguration()
		{
			var response = _configuration;

			switch (_fullName)
			{
				case "Rosetta.DataStores.CommaSeperatedFileDataStore":
				case "Rosetta.DataStores.FlatFileDataStore":
					response.ConnectionString = FileConnectionString.Text;
					break;

				case "Rosetta.DataStores.SqlDataStore":
					response.ConnectionString = SqlConnectionString.Text;
					break;
			}

			return response;
		}

		public void SetStoreType(string fullName, bool isSource)
		{
			_fullName = fullName;
			_isSource = isSource;

			ButtonLoad.Visible = _isSource;
			ButtonSave.Visible = !_isSource;

			FilePanel.Visible = false;
			SqlPanel.Visible = false;
			HeaderNameLabel.Visible = false;
			HeaderName.Visible = false;
			AlignmentPanel.Visible = false;
			LengthPanel.Visible = false;
			PadCharacterPanel.Visible = false;
			RemoveHeader.Visible = false;
			AddHeader.Visible = false;

			switch (_fullName)
			{
				case "Rosetta.DataStores.CommaSeperatedFileDataStore":
					FilePanel.Visible = true;
					HeaderNameLabel.Visible = true;
					HeaderName.Visible = true;
					AddHeader.Visible = true;
					RemoveHeader.Visible = true;
					break;

				case "Rosetta.DataStores.FlatFileDataStore":
					FilePanel.Visible = true;
					HeaderNameLabel.Visible = true;
					HeaderName.Visible = true;
					AddHeader.Visible = true;
					RemoveHeader.Visible = true;
					break;

				case "Rosetta.DataStores.SqlDataStore":
					SqlPanel.Visible = true;
					break;
			}
		}

		private void ButtonLoadClick(object sender, EventArgs e)
		{
			using (var dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
				dialog.Filter = _configuration.Filter;

				if (dialog.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				FileConnectionString.Text = dialog.FileName;
				FileName.Text = Path.GetFileName(FileConnectionString.Text);
			}
		}

		private void ButtonSaveClick(object sender, EventArgs e)
		{
			using (var dialog = new SaveFileDialog())
			{
				dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
				dialog.Filter = _configuration.Filter;

				if (dialog.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				FileConnectionString.Text = dialog.FileName;
				FileName.Text = Path.GetFileName(FileConnectionString.Text);
			}
		}

		private void DataSourceConfigurationControl_Load(object sender, EventArgs e)
		{
		}

		#endregion
	}
}