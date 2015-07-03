#region References

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Rosetta.Data;
using Rosetta.DataStores;
using Rosetta.Process;

#endregion

namespace Rosetta.WinForms
{
	public partial class MainForm : Form
	{
		#region Fields

		private readonly DataService _dataService;
		private string _destinationPath;
		private string _sourcePath;

		#endregion

		#region Constructors

		public MainForm()
		{
			InitializeComponent();

			_dataService = new DataService();
		}

		#endregion

		#region Methods

		private void AddDestinationHeader_Click(object sender, EventArgs e)
		{
			DestinationHeaders.Items.Add(DestinationHeader.Text);
			DestinationHeader.Text = string.Empty;
			UpdateControlState();
		}

		private void AddItems(ListBox listView, ICollection<string> items)
		{
			listView.Items.Clear();

			foreach (var item in items)
			{
				listView.Items.Add(item);
			}
		}

		private void AddMapping_Click(object sender, EventArgs e)
		{
			var sources = string.Join(",", MappingSource.SelectedItems.Cast<string>());
			var mapping = "[" + sources + "]," + MappingDestination.SelectedItem + "," + MappingType.Text;
			Mappings.Items.Add(mapping);
			ProcessorMappings.Items.Add(mapping);
			UpdateControlState();
		}

		private void AddPreProcessor_Click(object sender, EventArgs e)
		{
			PreProcessors.Items.Add(ProcessorMappings.SelectedItem + "|" + ProcessorMethod.SelectedItem + "," + ProcessorValue.Text);
		}

		private void AddSourceHeader_Click(object sender, EventArgs e)
		{
			SourceHeaders.Items.Add(SourceHeader.Text);
			SourceHeader.Text = string.Empty;
			UpdateControlState();
		}

		private void DesinationOpenFile_Click(object sender, EventArgs e)
		{
			var destinationStore = Destinations.SelectedItems[0].Text;
			var store = _dataService.Stores.FirstOrDefault(x => x.DisplayName == destinationStore) as FileDataStore;
			if (store == null)
			{
				return;
			}

			using (var dialog = new SaveFileDialog())
			{
				dialog.Filter = store.Filter;
				dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\Sample Data";

				if (dialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				_destinationPath = dialog.FileName;
				DestinationFileName.Text = Path.GetFileName(_destinationPath);
				DestinationFileName.Visible = true;
			}
		}

		private void DestinationBack_Click(object sender, EventArgs e)
		{
			TabControl.SelectedTab = SourcePage;
		}

		private void DestinationHeader_TextChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private void DestinationHeaders_SelectedIndexChanged(object sender, EventArgs e)
		{
			RemoveDestinationHeader.Enabled = DestinationHeaders.SelectedItems.Count > 0;
		}

		private void DestinationNext_Click(object sender, EventArgs e)
		{
			TabControl.SelectedTab = MappingPage;
		}

		private void Destinations_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private IEnumerable<Mapping> GetMappings()
		{
			var mappings = new List<Mapping>();

			foreach (string item in Mappings.Items)
			{
				var items = item.Split(new[] { "]," }, StringSplitOptions.None);
				var sourceHeader = items[0].Substring(1);
				var destinationHeader = items[1].Split(',')[0];
				var type = items[1].Split(',')[1];

				var mapping = new Mapping
				{
					DestinationHeader = destinationHeader,
					SourceHeaders = sourceHeader.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries),
					Type = type
				};

				var processors = new List<ProcessSettings>();
				foreach (string processorItem in PreProcessors.Items)
				{
					if (!processorItem.StartsWith(item))
					{
						continue;
					}

					var processorSettingParts = processorItem.Split('|')[1].Split(',');
					processors.Add(new ProcessSettings
					{
						Method = (ProcessMethod) Enum.Parse(typeof (ProcessMethod), processorSettingParts[0]),
						Value = processorSettingParts[1]
					});
				}

				mapping.PreProcesses = processors.ToArray();
				mappings.Add(mapping);
			}

			return mappings;
		}

		private Settings GetSettings()
		{
			return new Settings
			{
				SelectedSource = Sources.SelectedItems.Count <= 0 ? "" : Sources.SelectedItems[0].Text,
				SourcePath = _sourcePath,
				SourceHeaders = SourceHeaders.Items.Cast<string>().ToList(),
				DestinationSource = Destinations.SelectedItems.Count <= 0 ? "" : Destinations.SelectedItems[0].Text,
				DestinationPath = _destinationPath,
				DestinationHeaders = DestinationHeaders.Items.Cast<string>().ToList(),
				MappingSource = MappingSource.Items.Cast<string>().ToList(),
				MappingDestination = MappingDestination.Items.Cast<string>().ToList(),
				Mappings = Mappings.Items.Cast<string>().ToList(),
				ProcessorMappings = ProcessorMappings.Items.Cast<string>().ToList(),
				PreProcessors = PreProcessors.Items.Cast<string>().ToList()
			};
		}

		private void Load_Click(object sender, EventArgs e)
		{
			using (var dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = Application.ExecutablePath;
				dialog.Filter = "JSON (*.json)|*.json";

				if (dialog.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				var data = File.ReadAllText(dialog.FileName);
				var settings = Serializer.Deserialize<Settings>(data);
				SetSettings(settings);
				UpdateControlState();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Sources.Items.AddRange(_dataService.Stores.Select(x => new ListViewItem(x.DisplayName)).ToArray());
			Destinations.Items.AddRange(_dataService.Stores.Select(x => new ListViewItem(x.DisplayName)).ToArray());

			ProcessorMethod.Items.AddRange(new object[]
			{
				ProcessMethod.Trim.ToString(),
				ProcessMethod.TrimLeft.ToString(),
				ProcessMethod.TrimRight.ToString(),
				ProcessMethod.LowerCase.ToString(),
				ProcessMethod.UpperCase.ToString(),
				ProcessMethod.Add.ToString(),
				ProcessMethod.Subtract.ToString()
			});
		}

		private void MappingBack_Click(object sender, EventArgs e)
		{
			TabControl.SelectedTab = DestinationPage;
		}

		private void MappingNext_Click(object sender, EventArgs e)
		{
			TabControl.SelectedTab = ProcessorPage;
		}

		private void Mappings_SelectedIndexChanged(object sender, EventArgs e)
		{
			RemoveMapping.Enabled = Mappings.SelectedItems.Count > 0;
		}

		private void PreProcessors_SelectedIndexChanged(object sender, EventArgs e)
		{
			RemovePreProcessor.Enabled = PreProcessors.SelectedItems.Count > 0;
		}

		private void Process_Click(object sender, EventArgs e)
		{
			UpdateProcess("Configuring...");

			var mappings = GetMappings();
			var selectedSource = Sources.SelectedItems[0].Text;
			var sourceStore = (FileDataStore) _dataService.Stores.First(x => x.DisplayName == selectedSource);
			sourceStore.FilePath = _sourcePath;

			var source = sourceStore.Read();
			if (sourceIncludeHeaders.Checked)
			{
				source.Rows.RemoveAt(0);
			}

			UpdateProcess("Converting...");
			var destination = Converter.Convert(source, mappings);

			UpdateProcess("Storing...");
			var destinationSource = Destinations.SelectedItems[0].Text;
			var destinationStore = (FileDataStore) _dataService.Stores.First(x => x.DisplayName == destinationSource);
			destinationStore.FilePath = _destinationPath;
			destinationStore.Write(destination);

			UpdateProcess("Done");
			ProcessLabel.Text = string.Empty;
		}

		private void ProcessBack_Click(object sender, EventArgs e)
		{
			TabControl.SelectedTab = ProcessorPage;
		}

		private void ProcessorMappings_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private void ProcessorMethod_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private void ProcessorsBack_Click(object sender, EventArgs e)
		{
			TabControl.SelectedTab = MappingPage;
		}

		private void ProcessorsNext_Click(object sender, EventArgs e)
		{
			TabControl.SelectedTab = ProcessPage;
		}

		private void ProcessorValue_TextChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private void RemoveDestinationHeader_Click(object sender, EventArgs e)
		{
			if (DestinationHeaders.SelectedItems.Count < 0)
			{
				return;
			}

			DestinationHeaders.Items.Remove(DestinationHeaders.SelectedItem);
			UpdateControlState();
		}

		private void RemoveMapping_Click(object sender, EventArgs e)
		{
			if (Mappings.SelectedItems.Count < 0)
			{
				return;
			}

			ProcessorMappings.Items.Remove(Mappings.SelectedItem);
			Mappings.Items.Remove(Mappings.SelectedItem);
			UpdateControlState();
		}

		private void RemovePreProcessor_Click(object sender, EventArgs e)
		{
			if (PreProcessors.SelectedItems.Count <= 0)
			{
				return;
			}

			PreProcessors.Items.Remove(PreProcessors.SelectedItem);
		}

		private void RemoveSourceHeader_Click(object sender, EventArgs e)
		{
			if (SourceHeaders.SelectedItems.Count < 0)
			{
				return;
			}

			SourceHeaders.Items.Remove(SourceHeaders.SelectedItem);
			UpdateControlState();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			using (var dialog = new SaveFileDialog())
			{
				dialog.InitialDirectory = Application.ExecutablePath;
				dialog.Filter = "JSON (*.json)|*.json";

				if (dialog.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				var settings = GetSettings();
				var data = Serializer.Serialize(settings);
				File.WriteAllText(dialog.FileName, data);
			}
		}

		private void SelectItem(ListView listView, string value)
		{
			foreach (ListViewItem item in listView.Items)
			{
				if (item.Text != value)
				{
					continue;
				}

				item.Selected = true;
				listView.Select();
				break;
			}
		}

		private void SetSettings(Settings settings)
		{
			SelectItem(Sources, settings.SelectedSource);
			_sourcePath = settings.SourcePath;
			SourceFileName.Text = Path.GetFileName(_sourcePath);
			AddItems(SourceHeaders, settings.SourceHeaders);
			SelectItem(Destinations, settings.DestinationSource);
			_destinationPath = settings.DestinationPath;
			DestinationFileName.Text = Path.GetFileName(_destinationPath);
			AddItems(DestinationHeaders, settings.DestinationHeaders);
			AddItems(MappingSource, settings.MappingSource);
			AddItems(MappingDestination, settings.MappingDestination);
			AddItems(Mappings, settings.Mappings);
			AddItems(ProcessorMappings, settings.ProcessorMappings);
			AddItems(PreProcessors, settings.PreProcessors);
		}

		private void SourceHeader_TextChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private void SourceHeaders_SelectedIndexChanged(object sender, EventArgs e)
		{
			RemoveSourceHeader.Enabled = SourceHeaders.SelectedItems.Count > 0;
		}

		private void SourceNext_Click(object sender, EventArgs e)
		{
			TabControl.SelectedTab = DestinationPage;
		}

		private void SourceOpenFile_Click(object sender, EventArgs e)
		{
			var selectedSource = Sources.SelectedItems[0].Text;
			var store = _dataService.Stores.FirstOrDefault(x => x.DisplayName == selectedSource) as FileDataStore;
			if (store == null)
			{
				return;
			}

			using (var dialog = new OpenFileDialog())
			{
				dialog.Filter = store.Filter;
				dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\Sample Data";

				if (dialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				_sourcePath = dialog.FileName;
				store.FilePath = _sourcePath;
				var dataTable = store.Read();

				SourceHeaders.Items.Clear();
				SourceHeaders.Items.AddRange(dataTable.Columns.Cast<object>().ToArray());

				SourceFileName.Text = Path.GetFileName(_sourcePath);
				SourceFileName.Visible = true;

				UpdateControlState();
			}
		}

		private void Sources_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateControlState();
		}

		private void TabControl_Selected(object sender, TabControlEventArgs e)
		{
			UpdateControlState();
		}

		private void UpdateControlState()
		{
			Header.Text = TabControl.SelectedTab.Text;
			SourceNext.Enabled = SourceHeaders.Items.Count > 0;
			DestinationNext.Enabled = DestinationHeaders.Items.Count > 0;
			MappingNext.Enabled = Mappings.Items.Count > 0;

			if (TabControl.SelectedTab == SourcePage)
			{
				var selectedSource = Sources.SelectedItems.Count > 0 ? Sources.SelectedItems[0].Text : "";
				var sourceStore = _dataService.Stores.FirstOrDefault(x => x.DisplayName == selectedSource);
				SourceOpenFile.Enabled = sourceStore is FileDataStore;
				SourceHeaders.Enabled = SourceOpenFile.Enabled;
				SourceHeader.Enabled = SourceOpenFile.Enabled;
				AddSourceHeader.Enabled = SourceOpenFile.Enabled && SourceHeader.Text.Length > 0;
			}
			else if (TabControl.SelectedTab == DestinationPage)
			{
				var selectedDestination = Destinations.SelectedItems.Count > 0 ? Destinations.SelectedItems[0].Text : "";
				var destinationStore = _dataService.Stores.FirstOrDefault(x => x.DisplayName == selectedDestination);
				DestinationSelectFile.Enabled = destinationStore is FileDataStore;
				DestinationHeaders.Enabled = DestinationSelectFile.Enabled;
				DestinationHeader.Enabled = DestinationSelectFile.Enabled;
				AddDestinationHeader.Enabled = DestinationSelectFile.Enabled && DestinationHeader.Text.Length > 0;
			}
			else if (TabControl.SelectedTab == MappingPage)
			{
				MappingSource.Items.Clear();
				MappingSource.Items.AddRange(SourceHeaders.Items);
				MappingDestination.Items.Clear();
				MappingDestination.Items.AddRange(DestinationHeaders.Items);
			}
			else if (TabControl.SelectedTab == ProcessorPage)
			{
				AddPreProcessor.Enabled = ProcessorMappings.SelectedIndices.Count > 0 && ProcessorMethod.Items.Count > 0;
			}
		}

		private void UpdateProcess(string message)
		{
			ProcessLabel.Text = message;
			ProcessTextBox.Text += message + Environment.NewLine;
		}

		#endregion
	}
}