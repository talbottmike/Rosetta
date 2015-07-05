#region References

using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Rosetta.Configuration;
using Rosetta.Extensions;

#endregion

namespace Rosetta.WinForms
{
	public partial class DataSourceConfigurationControl : UserControl
	{
		#region Fields

		private DataStoreConfiguration _configuration;
		private bool _isSource;

		#endregion

		#region Constructors

		public DataSourceConfigurationControl()
		{
			InitializeComponent();
			_configuration = new DataStoreConfiguration();
		}

		#endregion

		#region Methods

		public void LoadConfiguration(DataStoreConfiguration configuration, bool isSource)
		{
			_configuration = configuration;
			InitializeControls(isSource);
			ApplyConfiguration();
			UpdateControlState();
		}

		private void AddHeaderClick(object sender, EventArgs e)
		{
			_configuration.Columns.Add(new DataStoreColumn
			{
				Alignment = AlignmentLeft.Checked ? ColumnAlignment.Left : ColumnAlignment.Right,
				Length = (int) HeaderLength.Value,
				Name = HeaderName.Text,
				PaddingCharacter = PadCharacter.Text.Length > 0 ? PadCharacter.Text.First() : ' ',
				Source = string.Empty
			});

			HeaderName.Clear();
			HeaderLength.Value = 0;
			PadCharacter.Text = string.Empty;
			ApplyConfiguration();
		}

		private void ApplyConfiguration()
		{
			switch (_configuration.StoreFullName)
			{
				case "Rosetta.DataStores.CommaSeperatedFileDataStore":
				case "Rosetta.DataStores.FlatFileDataStore":
					FileConnectionString.Text = _configuration.ConnectionString;
					FileName.Text = string.IsNullOrWhiteSpace(_configuration.ConnectionString)
						? "Select File" : Path.GetFileName(FileConnectionString.Text);
					break;

				case "Rosetta.DataStores.SqlDataStore":
					SqlConnectionString.Text = string.IsNullOrWhiteSpace(_configuration.ConnectionString)
						? "Data Source=localhost;Initial Catalog=Rosetta;Integrated Security=True;"
						: _configuration.ConnectionString;
					SqlTables.LoadItems(_configuration.Columns.Select(x => x.Source).Distinct().Where(x => x.Length > 0));
					break;
			}

			Headers.LoadItems(_configuration.Columns.Select(x => x.Name));

			UpdateControlState();
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

				_configuration.ConnectionString = dialog.FileName;
				ApplyConfiguration();
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

				_configuration.ConnectionString = dialog.FileName;
				ApplyConfiguration();
			}
		}

		private void DataSourceConfigurationControl_Load(object sender, EventArgs e)
		{
		}

		private void InitializeControls(bool isSource)
		{
			_isSource = isSource;

			ButtonLoad.Visible = _isSource;
			ButtonSave.Visible = !_isSource;
			LoadHeaders.Visible = _isSource;

			FilePanel.Visible = false;
			SqlPanel.Visible = false;
			HeaderNameLabel.Visible = false;
			HeaderName.Visible = false;
			AlignmentPanel.Visible = false;
			LengthPanel.Visible = false;
			PadCharacterPanel.Visible = false;
			RemoveHeader.Visible = false;
			AddHeader.Visible = false;

			if (_configuration.StoreFullName == "Rosetta.DataStores.CommaSeperatedFileDataStore" || _configuration.StoreFullName == "Rosetta.DataStores.FlatFileDataStore")
			{
				FilePanel.Visible = true;
				HeaderNameLabel.Visible = true;
				HeaderName.Visible = true;
				AddHeader.Visible = true;
				RemoveHeader.Visible = true;
			}

			if (_configuration.StoreFullName == "Rosetta.DataStores.FlatFileDataStore")
			{
				AlignmentPanel.Visible = true;
				LengthPanel.Visible = true;
				PadCharacterPanel.Visible = true;
			}

			if (_configuration.StoreFullName == "Rosetta.DataStores.SqlDataStore")
			{
				SqlPanel.Visible = true;
			}
		}

		private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private void LoadHeadersClick(object sender, EventArgs e)
		{
			switch (_configuration.StoreFullName)
			{
				case "Rosetta.DataStores.SqlDataStore":
					LoadHeadersFromSqlTable(SqlTables.SelectedItem.ToString());
					break;
			}
		}

		private void LoadHeadersFromSqlTable(string table)
		{
			using (var connection = new SqlConnection(SqlConnectionString.Text))
			{
				var command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName", connection);
				command.Connection.Open();
				command.Parameters.AddWithValue("@TableName", table);
				var reader = command.ExecuteReader();

				_configuration.Columns.Clear();

				while (reader.Read())
				{
					_configuration.Columns.Add(new DataStoreColumn { Name = reader["COLUMN_NAME"].ToString(), Source = table });
				}
			}

			ApplyConfiguration();
		}

		private void RemoveHeaderClick(object sender, EventArgs e)
		{
			var column = _configuration.Columns.FirstOrDefault(x => x.Name == Headers.SelectedItem.ToString());
			if (column == null)
			{
				return;
			}

			Headers.Items.Remove(column.Name);
			_configuration.Columns.Remove(column);

			ApplyConfiguration();
		}

		private void SqlLoadTablesClick(object sender, EventArgs e)
		{
			using (var connection = new SqlConnection(SqlConnectionString.Text))
			{
				var command = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", connection);
				command.Connection.Open();
				var reader = command.ExecuteReader();

				SqlTables.Items.Clear();

				while (reader.Read())
				{
					SqlTables.Items.Add(reader["TABLE_NAME"].ToString());
				}
			}
		}

		private void TextBoxTextChanged(object sender, EventArgs e)
		{
			var textBox = (TextBox) sender;

			if (textBox == SqlConnectionString && _configuration.StoreFullName == "Rosetta.DataStores.SqlDataStore")
			{
				_configuration.ConnectionString = textBox.Text;
			}

			ApplyConfiguration();
		}

		private void UpdateControlState()
		{
			SqlLoadTables.Enabled = SqlConnectionString.Text.Length > 0;
			LoadHeaders.Visible = SqlTables.SelectedItems.Count > 0;
			AddHeader.Enabled = !string.IsNullOrWhiteSpace(AddHeader.Text);
			RemoveHeader.Enabled = Headers.SelectedIndices.Count > 0;
		}

		#endregion
	}
}