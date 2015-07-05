#region References

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Rosetta.Configuration;
using Rosetta.DataStores;
using Rosetta.Extensions;
using Rosetta.Process;

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

		private void AddMappingClick(object sender, EventArgs e)
		{
			_settings.Mappings.Add(new Mapping
			{
				CombineMethod = (CombineMethod) Enum.Parse(typeof (CombineMethod), MappingCombineMethod.Text),
				CombineValue = MappingCombineValue.Text,
				DestinationHeader = MappingDestination.Text,
				SourceHeaders = MappingSource.SelectedItems.Cast<string>().ToList(),
				Type = MappingType.Text
			});

			ApplySettings();
		}

		private void AddPreProcessorClick(object sender, EventArgs e)
		{
			var mapping = _settings.Mappings[ProcessorMappings.SelectedIndex];
			mapping.PreProcesses.Add(new ProcessSettings
			{
				Filter = ProcessorFilter.Text,
				Method = (ProcessMethod) Enum.Parse(typeof (ProcessMethod), ProcessorMethod.Text),
				Value = ProcessorValue.Text
			});

			ProcessorValue.Clear();
			ApplySettings();
		}

		private void ApplySettings()
		{
			Sources.SelectedValue = _settings.SourceStoreConfiguration.StoreFullName;
			SourceConfiguration.LoadConfiguration(_settings.SourceStoreConfiguration, true);
			Destinations.SelectedValue = _settings.DestinationStoreConfiguration.StoreFullName;
			DestinationConfiguration.LoadConfiguration(_settings.DestinationStoreConfiguration, false);
			MappingSource.LoadItems(_settings.SourceStoreConfiguration.Columns.Select(x => x.Name));
			MappingDestination.LoadItems(_settings.DestinationStoreConfiguration.Columns.Select(x => x.Name));
			Mappings.LoadItems(_settings.Mappings.Select(x => x.DisplayName));
			ProcessorMappings.LoadItems(_settings.Mappings.Select(x => x.DisplayName));
			PreProcessors.LoadItems(_settings.Mappings.SelectMany(x => x.PreProcesses.Select(y => x.DisplayName + "|" + y.DisplayName)));

			UpdateControlState();
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
			else if (sender == ProcessorsBack)
			{
				TabControl.SelectedTab = MappingPage;
			}
			else if (sender == ProcessBack)
			{
				TabControl.SelectedTab = ProcessorPage;
			}

			Header.Text = TabControl.SelectedTab.Text;
		}

		private DataStore GetDataStore(DataStoreConfiguration configuration)
		{
			var dataStoreType = Type.GetType(configuration.StoreFullName + ",Rosetta");
			if (dataStoreType == null)
			{
				throw new ArgumentException("Failed to find type for data store.");
			}

			var dataStore = Activator.CreateInstance(dataStoreType, configuration) as DataStore;
			if (dataStore == null)
			{
				throw new ArgumentException("Failed to create an instance of the data store.");
			}

			dataStore.Initialize();
			return dataStore;
		}

		private string GetStoreFilter(string typeFullName)
		{
			switch (typeFullName)
			{
				case "Rosetta.DataStores.CommaSeperatedFileDataStore":
					return CommaSeperatedFileDataStore.Filter;

				case "Rosetta.DataStores.FlatFileDataStore":
					return FlatFileDataStore.Filter;

				default:
					return string.Empty;
			}
		}

		private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			var control = (ListBox) sender;
			if (control.SelectedItems.Count > 0)
			{
				var dataStore = (control.SelectedValue ?? control.SelectedItem).ToString();

				if (control == Sources)
				{
					_settings.SourceStoreConfiguration.StoreFullName = dataStore;
					_settings.SourceStoreConfiguration.Filter = GetStoreFilter(dataStore);
					SourceConfiguration.LoadConfiguration(_settings.SourceStoreConfiguration, true);
				}
				else if (control == Destinations)
				{
					_settings.DestinationStoreConfiguration.StoreFullName = dataStore;
					_settings.DestinationStoreConfiguration.Filter = GetStoreFilter(dataStore);
					DestinationConfiguration.LoadConfiguration(_settings.DestinationStoreConfiguration, false);
				}
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

			ProcessorMethod.LoadItems(Enum.GetNames(typeof (ProcessMethod)));
			MappingCombineMethod.LoadItems(Enum.GetNames(typeof (CombineMethod)));
			MappingCombineMethod.SelectedIndex = 0;
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
			ApplySettings();
		}

		private void ProcessButtonClick(object sender, EventArgs e)
		{
			var sourceDataStore = GetDataStore(_settings.SourceStoreConfiguration);
			var destinationStore = GetDataStore(_settings.DestinationStoreConfiguration);

			UpdateProcess("Starting conversion...");
			Converter.Convert(sourceDataStore, _settings.Mappings, destinationStore);

			UpdateProcess("Done.");
			ProcessLabel.Text = string.Empty;
		}

		private void RemoveMappingClick(object sender, EventArgs e)
		{
			if (Mappings.SelectedItems.Count <= 0)
			{
				return;
			}

			var mapping = _settings.Mappings.FirstOrDefault(x => x.DisplayName == Mappings.SelectedItem.ToString());
			if (mapping != null)
			{
				_settings.Mappings.Remove(mapping);
				ApplySettings();
			}
		}

		private void RemovePreProcessorClick(object sender, EventArgs e)
		{
			var items = PreProcessors.SelectedItem.ToString().Split('|');
			var mapping = _settings.Mappings.FirstOrDefault(x => x.DisplayName == items[0]);
			var preProcessor = mapping?.PreProcesses.FirstOrDefault(x => x.DisplayName == items[1]);

			if (preProcessor == null)
			{
				return;
			}

			mapping.PreProcesses.Remove(preProcessor);
			ApplySettings();
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

		private void TextBoxTextChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private void UpdateControlState()
		{
			DataStoresNext.Enabled = Sources.SelectedItems.Count > 0 && Destinations.SelectedItems.Count > 0;
			AddMapping.Enabled = MappingSource.SelectedItems.Count > 0 && MappingDestination.SelectedItems.Count > 0;
			RemoveMapping.Enabled = Mappings.SelectedItems.Count > 0;
			AddPreProcessor.Enabled = ProcessorMappings.SelectedItems.Count > 0 && ProcessorMethod.SelectedItems.Count > 0;
			RemovePreProcessor.Enabled = PreProcessors.SelectedItems.Count > 0;
		}

		private void UpdateProcess(string message)
		{
			ProcessLabel.Text = message;
			ProcessTextBox.Text += message + Environment.NewLine;
		}

		#endregion
	}
}