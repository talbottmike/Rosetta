#region References

using System;
using System.IO;
using System.Windows.Forms;
using Rosetta.DataStores;

#endregion

namespace Rosetta.WinForms
{
	public partial class MainForm : Form
	{
		#region Fields

		private readonly Type[] _dataStores;
		private Settings _settings;

		#endregion

		#region Constructors

		public MainForm()
		{
			InitializeComponent();

			_dataStores = new[]
			{
				typeof (CommaSeperatedFileDataStore),
				typeof (FlatFileDataStore),
				typeof (SqlDataStore),
				typeof (MemoryDataStore)
			};

			_settings = new Settings();
		}

		#endregion

		#region Methods

		private void ApplySettings()
		{
			Sources.SelectedValue = _settings.SourceStore;
			Destinations.SelectedValue = _settings.DestinationStore;
		}

		private void BackButtonClick(object sender, EventArgs e)
		{
			if (sender == ConfigureSourceBack)
			{
				TabControl.SelectedTab = DataStoresPage;
			}
			else if (sender == ConfigureDestinationBack)
			{
				TabControl.SelectedTab = ConfigureSourcePage;
			}
			else if (sender == MappingBack)
			{
				TabControl.SelectedTab = ConfigureDestinationPage;
			}
			else if (sender == ProcessBack)
			{
				TabControl.SelectedTab = MappingPage;
			}

			Header.Text = TabControl.SelectedTab.Text;
		}

		private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			var control = (ListBox) sender;
			var dataStore = control.SelectedValue.ToString();

			if (control == Sources)
			{
				_settings.SourceStore = dataStore;
				SourceConfiguration.SetStoreType(_settings.SourceStore, true);
				SourceConfiguration.LoadConfiguration(_settings.SourceStoreConfiguration);
			}
			else if (control == Destinations)
			{
				_settings.DestinationStore = dataStore;
				DestinationConfiguration.SetStoreType(_settings.DestinationStore, false);
				DestinationConfiguration.LoadConfiguration(_settings.DestinationStoreConfiguration);
			}

			UpdateControlState();
		}

		private void LoadButtonClick(object sender, EventArgs e)
		{
			using (var dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
				dialog.Filter = "JSON (*.json)|*.json";

				if (dialog.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				var data = File.ReadAllText(dialog.FileName);
				_settings = Serializer.Deserialize<Settings>(data);
				ApplySettings();
				UpdateControlState();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Sources.DataSource = _dataStores.Clone();
			Sources.DisplayMember = "Name";
			Sources.ValueMember = "FullName";

			Destinations.DataSource = _dataStores.Clone();
			Destinations.DisplayMember = "Name";
			Destinations.ValueMember = "FullName";
		}

		private void NextButtonClick(object sender, EventArgs e)
		{
			if (sender == DataStoresNext)
			{
				TabControl.SelectedTab = ConfigureSourcePage;
			}
			else if (sender == ConfigureSourceNext)
			{
				TabControl.SelectedTab = ConfigureDestinationPage;
			}
			else if (sender == ConfigureDestinationNext)
			{
				TabControl.SelectedTab = MappingPage;
			}
			else if (sender == MappingNext)
			{
				TabControl.SelectedTab = ProcessorPage;
			}
			else if (sender == ProcessorsNext)
			{
				TabControl.SelectedTab = ProcessPage;
			}

			Header.Text = TabControl.SelectedTab.Text;
		}

		private void ProcessButtonClick(object sender, EventArgs e)
		{
		}

		private void SaveButtonClick(object sender, EventArgs e)
		{
			using (var dialog = new SaveFileDialog())
			{
				dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
				dialog.Filter = "JSON (*.json)|*.json";

				if (dialog.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				var data = Serializer.Serialize(_settings);
				File.WriteAllText(dialog.FileName, data);
			}
		}

		private void UpdateControlState()
		{
			DataStoresNext.Enabled = Sources.SelectedItems.Count > 0 && Destinations.SelectedItems.Count > 0;
		}

		#endregion
	}
}