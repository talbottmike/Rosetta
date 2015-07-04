namespace Rosetta.WinForms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Header = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.LoadButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CsvFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.TabControl = new Rosetta.WinForms.CustomTabControl();
			this.DataStoresPage = new System.Windows.Forms.TabPage();
			this.Sources = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.DataStoresNext = new System.Windows.Forms.Button();
			this.Destinations = new System.Windows.Forms.ListBox();
			this.ConfigureSourcePage = new System.Windows.Forms.TabPage();
			this.SourceConfiguration = new Rosetta.WinForms.DataSourceConfigurationControl();
			this.ConfigureSourceBack = new System.Windows.Forms.Button();
			this.ConfigureSourceNext = new System.Windows.Forms.Button();
			this.ConfigureDestinationPage = new System.Windows.Forms.TabPage();
			this.DestinationConfiguration = new Rosetta.WinForms.DataSourceConfigurationControl();
			this.ConfigureDestinationBack = new System.Windows.Forms.Button();
			this.ConfigureDestinationNext = new System.Windows.Forms.Button();
			this.MappingPage = new System.Windows.Forms.TabPage();
			this.MappingType = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.MappingBack = new System.Windows.Forms.Button();
			this.MappingNext = new System.Windows.Forms.Button();
			this.Mappings = new System.Windows.Forms.ListBox();
			this.RemoveMapping = new System.Windows.Forms.Button();
			this.AddMapping = new System.Windows.Forms.Button();
			this.MappingDestination = new System.Windows.Forms.ListBox();
			this.MappingSource = new System.Windows.Forms.ListBox();
			this.ProcessorPage = new System.Windows.Forms.TabPage();
			this.AddPreProcessor = new System.Windows.Forms.Button();
			this.RemovePreProcessor = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.ProcessorValue = new System.Windows.Forms.TextBox();
			this.PreProcessors = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ProcessorMethod = new System.Windows.Forms.ListBox();
			this.ProcessorsBack = new System.Windows.Forms.Button();
			this.ProcessorsNext = new System.Windows.Forms.Button();
			this.ProcessorMappings = new System.Windows.Forms.ListBox();
			this.ProcessPage = new System.Windows.Forms.TabPage();
			this.ProcessLabel = new System.Windows.Forms.Label();
			this.ProcessBack = new System.Windows.Forms.Button();
			this.ProcessTextBox = new System.Windows.Forms.TextBox();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.Process = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.DataStoresPage.SuspendLayout();
			this.ConfigureSourcePage.SuspendLayout();
			this.ConfigureDestinationPage.SuspendLayout();
			this.MappingPage.SuspendLayout();
			this.ProcessorPage.SuspendLayout();
			this.ProcessPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header
			// 
			this.Header.AutoSize = true;
			this.Header.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Header.Location = new System.Drawing.Point(19, 9);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(175, 45);
			this.Header.TabIndex = 0;
			this.Header.Text = "Data Stores";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.LoadButton);
			this.panel1.Controls.Add(this.SaveButton);
			this.panel1.Controls.Add(this.Header);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 71);
			this.panel1.TabIndex = 0;
			// 
			// LoadButton
			// 
			this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LoadButton.BackColor = System.Drawing.Color.Transparent;
			this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoadButton.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadButton.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.LoadButton.Location = new System.Drawing.Point(697, 11);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(75, 50);
			this.LoadButton.TabIndex = 2;
			this.LoadButton.Text = "";
			this.LoadButton.UseVisualStyleBackColor = false;
			this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.BackColor = System.Drawing.Color.Transparent;
			this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveButton.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.SaveButton.Location = new System.Drawing.Point(616, 11);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 50);
			this.SaveButton.TabIndex = 1;
			this.SaveButton.Text = "";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// CsvFileDialog
			// 
			this.CsvFileDialog.DefaultExt = "*.csv";
			this.CsvFileDialog.FileName = "CsvFileDialog";
			this.CsvFileDialog.Filter = "CSV (csv)|*.csv";
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.DataStoresPage);
			this.TabControl.Controls.Add(this.ConfigureSourcePage);
			this.TabControl.Controls.Add(this.ConfigureDestinationPage);
			this.TabControl.Controls.Add(this.MappingPage);
			this.TabControl.Controls.Add(this.ProcessorPage);
			this.TabControl.Controls.Add(this.ProcessPage);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 71);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(784, 490);
			this.TabControl.TabIndex = 1;
			// 
			// DataStoresPage
			// 
			this.DataStoresPage.Controls.Add(this.Sources);
			this.DataStoresPage.Controls.Add(this.label5);
			this.DataStoresPage.Controls.Add(this.label3);
			this.DataStoresPage.Controls.Add(this.DataStoresNext);
			this.DataStoresPage.Controls.Add(this.Destinations);
			this.DataStoresPage.Location = new System.Drawing.Point(4, 22);
			this.DataStoresPage.Name = "DataStoresPage";
			this.DataStoresPage.Padding = new System.Windows.Forms.Padding(3);
			this.DataStoresPage.Size = new System.Drawing.Size(776, 464);
			this.DataStoresPage.TabIndex = 0;
			this.DataStoresPage.Text = "Data Stores";
			this.DataStoresPage.UseVisualStyleBackColor = true;
			// 
			// Sources
			// 
			this.Sources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Sources.FormattingEnabled = true;
			this.Sources.Location = new System.Drawing.Point(28, 40);
			this.Sources.Name = "Sources";
			this.Sources.Size = new System.Drawing.Size(209, 316);
			this.Sources.TabIndex = 4;
			this.Sources.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label5.Location = new System.Drawing.Point(264, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "destination";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(25, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "source";
			// 
			// DataStoresNext
			// 
			this.DataStoresNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DataStoresNext.Enabled = false;
			this.DataStoresNext.Location = new System.Drawing.Point(676, 409);
			this.DataStoresNext.Name = "DataStoresNext";
			this.DataStoresNext.Size = new System.Drawing.Size(75, 30);
			this.DataStoresNext.TabIndex = 2;
			this.DataStoresNext.Text = "Next";
			this.DataStoresNext.UseVisualStyleBackColor = true;
			this.DataStoresNext.Click += new System.EventHandler(this.NextButtonClick);
			// 
			// Destinations
			// 
			this.Destinations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Destinations.FormattingEnabled = true;
			this.Destinations.Location = new System.Drawing.Point(267, 40);
			this.Destinations.Name = "Destinations";
			this.Destinations.Size = new System.Drawing.Size(209, 316);
			this.Destinations.TabIndex = 1;
			this.Destinations.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// ConfigureSourcePage
			// 
			this.ConfigureSourcePage.Controls.Add(this.SourceConfiguration);
			this.ConfigureSourcePage.Controls.Add(this.ConfigureSourceBack);
			this.ConfigureSourcePage.Controls.Add(this.ConfigureSourceNext);
			this.ConfigureSourcePage.Location = new System.Drawing.Point(4, 22);
			this.ConfigureSourcePage.Name = "ConfigureSourcePage";
			this.ConfigureSourcePage.Size = new System.Drawing.Size(776, 464);
			this.ConfigureSourcePage.TabIndex = 5;
			this.ConfigureSourcePage.Text = "Configure Source";
			this.ConfigureSourcePage.UseVisualStyleBackColor = true;
			// 
			// SourceConfiguration
			// 
			this.SourceConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceConfiguration.Location = new System.Drawing.Point(3, 3);
			this.SourceConfiguration.Name = "SourceConfiguration";
			this.SourceConfiguration.Size = new System.Drawing.Size(770, 400);
			this.SourceConfiguration.TabIndex = 0;
			// 
			// ConfigureSourceBack
			// 
			this.ConfigureSourceBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfigureSourceBack.Location = new System.Drawing.Point(595, 409);
			this.ConfigureSourceBack.Name = "ConfigureSourceBack";
			this.ConfigureSourceBack.Size = new System.Drawing.Size(75, 30);
			this.ConfigureSourceBack.TabIndex = 1;
			this.ConfigureSourceBack.Text = "Back";
			this.ConfigureSourceBack.UseVisualStyleBackColor = true;
			this.ConfigureSourceBack.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// ConfigureSourceNext
			// 
			this.ConfigureSourceNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfigureSourceNext.Location = new System.Drawing.Point(676, 409);
			this.ConfigureSourceNext.Name = "ConfigureSourceNext";
			this.ConfigureSourceNext.Size = new System.Drawing.Size(75, 30);
			this.ConfigureSourceNext.TabIndex = 2;
			this.ConfigureSourceNext.Text = "Next";
			this.ConfigureSourceNext.UseVisualStyleBackColor = true;
			this.ConfigureSourceNext.Click += new System.EventHandler(this.NextButtonClick);
			// 
			// ConfigureDestinationPage
			// 
			this.ConfigureDestinationPage.Controls.Add(this.DestinationConfiguration);
			this.ConfigureDestinationPage.Controls.Add(this.ConfigureDestinationBack);
			this.ConfigureDestinationPage.Controls.Add(this.ConfigureDestinationNext);
			this.ConfigureDestinationPage.Location = new System.Drawing.Point(4, 22);
			this.ConfigureDestinationPage.Name = "ConfigureDestinationPage";
			this.ConfigureDestinationPage.Padding = new System.Windows.Forms.Padding(3);
			this.ConfigureDestinationPage.Size = new System.Drawing.Size(776, 464);
			this.ConfigureDestinationPage.TabIndex = 1;
			this.ConfigureDestinationPage.Text = "Configure Destination";
			this.ConfigureDestinationPage.UseVisualStyleBackColor = true;
			// 
			// DestinationConfiguration
			// 
			this.DestinationConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DestinationConfiguration.Location = new System.Drawing.Point(3, 3);
			this.DestinationConfiguration.Name = "DestinationConfiguration";
			this.DestinationConfiguration.Size = new System.Drawing.Size(770, 400);
			this.DestinationConfiguration.TabIndex = 0;
			// 
			// ConfigureDestinationBack
			// 
			this.ConfigureDestinationBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfigureDestinationBack.Location = new System.Drawing.Point(595, 409);
			this.ConfigureDestinationBack.Name = "ConfigureDestinationBack";
			this.ConfigureDestinationBack.Size = new System.Drawing.Size(75, 30);
			this.ConfigureDestinationBack.TabIndex = 1;
			this.ConfigureDestinationBack.Text = "Back";
			this.ConfigureDestinationBack.UseVisualStyleBackColor = true;
			this.ConfigureDestinationBack.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// ConfigureDestinationNext
			// 
			this.ConfigureDestinationNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfigureDestinationNext.Location = new System.Drawing.Point(676, 409);
			this.ConfigureDestinationNext.Name = "ConfigureDestinationNext";
			this.ConfigureDestinationNext.Size = new System.Drawing.Size(75, 30);
			this.ConfigureDestinationNext.TabIndex = 2;
			this.ConfigureDestinationNext.Text = "Next";
			this.ConfigureDestinationNext.UseVisualStyleBackColor = true;
			this.ConfigureDestinationNext.Click += new System.EventHandler(this.NextButtonClick);
			// 
			// MappingPage
			// 
			this.MappingPage.Controls.Add(this.MappingType);
			this.MappingPage.Controls.Add(this.label12);
			this.MappingPage.Controls.Add(this.label9);
			this.MappingPage.Controls.Add(this.label8);
			this.MappingPage.Controls.Add(this.label7);
			this.MappingPage.Controls.Add(this.MappingBack);
			this.MappingPage.Controls.Add(this.MappingNext);
			this.MappingPage.Controls.Add(this.Mappings);
			this.MappingPage.Controls.Add(this.RemoveMapping);
			this.MappingPage.Controls.Add(this.AddMapping);
			this.MappingPage.Controls.Add(this.MappingDestination);
			this.MappingPage.Controls.Add(this.MappingSource);
			this.MappingPage.Location = new System.Drawing.Point(4, 22);
			this.MappingPage.Name = "MappingPage";
			this.MappingPage.Size = new System.Drawing.Size(776, 464);
			this.MappingPage.TabIndex = 2;
			this.MappingPage.Text = "Mapping";
			this.MappingPage.UseVisualStyleBackColor = true;
			// 
			// MappingType
			// 
			this.MappingType.FormattingEnabled = true;
			this.MappingType.Items.AddRange(new object[] {
            "System.Boolean",
            "System.Byte",
            "System.SByte",
            "System.Int16",
            "System.UInt16",
            "System.Int32",
            "System.UInt32",
            "System.Int64",
            "System.UInt64",
            "System.Decimal",
            "System.Double",
            "System.Single",
            "System.DateTime",
            "System.Char",
            "System.String"});
			this.MappingType.Location = new System.Drawing.Point(439, 40);
			this.MappingType.Name = "MappingType";
			this.MappingType.Size = new System.Drawing.Size(312, 21);
			this.MappingType.TabIndex = 5;
			this.MappingType.Text = "System.String";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label12.Location = new System.Drawing.Point(436, 20);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(33, 17);
			this.label12.TabIndex = 4;
			this.label12.Text = "type";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label9.Location = new System.Drawing.Point(436, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 17);
			this.label9.TabIndex = 7;
			this.label9.Text = "mappings";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label8.Location = new System.Drawing.Point(230, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 17);
			this.label8.TabIndex = 2;
			this.label8.Text = "destination";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label7.Location = new System.Drawing.Point(25, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "source";
			// 
			// MappingBack
			// 
			this.MappingBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.MappingBack.Location = new System.Drawing.Point(595, 409);
			this.MappingBack.Name = "MappingBack";
			this.MappingBack.Size = new System.Drawing.Size(75, 30);
			this.MappingBack.TabIndex = 11;
			this.MappingBack.Text = "Back";
			this.MappingBack.UseVisualStyleBackColor = true;
			this.MappingBack.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// MappingNext
			// 
			this.MappingNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.MappingNext.Location = new System.Drawing.Point(676, 409);
			this.MappingNext.Name = "MappingNext";
			this.MappingNext.Size = new System.Drawing.Size(75, 30);
			this.MappingNext.TabIndex = 0;
			this.MappingNext.Text = "Next";
			this.MappingNext.UseVisualStyleBackColor = true;
			this.MappingNext.Click += new System.EventHandler(this.NextButtonClick);
			// 
			// Mappings
			// 
			this.Mappings.FormattingEnabled = true;
			this.Mappings.Location = new System.Drawing.Point(438, 118);
			this.Mappings.Name = "Mappings";
			this.Mappings.Size = new System.Drawing.Size(312, 238);
			this.Mappings.TabIndex = 9;
			this.Mappings.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// RemoveMapping
			// 
			this.RemoveMapping.Enabled = false;
			this.RemoveMapping.Location = new System.Drawing.Point(438, 362);
			this.RemoveMapping.Name = "RemoveMapping";
			this.RemoveMapping.Size = new System.Drawing.Size(100, 23);
			this.RemoveMapping.TabIndex = 10;
			this.RemoveMapping.Text = "Remove";
			this.RemoveMapping.UseVisualStyleBackColor = true;
			this.RemoveMapping.Click += new System.EventHandler(this.RemoveMappingClick);
			// 
			// AddMapping
			// 
			this.AddMapping.Location = new System.Drawing.Point(651, 67);
			this.AddMapping.Name = "AddMapping";
			this.AddMapping.Size = new System.Drawing.Size(100, 23);
			this.AddMapping.TabIndex = 6;
			this.AddMapping.Text = "Add";
			this.AddMapping.UseVisualStyleBackColor = true;
			this.AddMapping.Click += new System.EventHandler(this.AddMappingClick);
			// 
			// MappingDestination
			// 
			this.MappingDestination.FormattingEnabled = true;
			this.MappingDestination.Location = new System.Drawing.Point(233, 40);
			this.MappingDestination.Name = "MappingDestination";
			this.MappingDestination.Size = new System.Drawing.Size(180, 355);
			this.MappingDestination.TabIndex = 3;
			this.MappingDestination.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// MappingSource
			// 
			this.MappingSource.FormattingEnabled = true;
			this.MappingSource.Location = new System.Drawing.Point(28, 40);
			this.MappingSource.Name = "MappingSource";
			this.MappingSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.MappingSource.Size = new System.Drawing.Size(180, 355);
			this.MappingSource.TabIndex = 1;
			this.MappingSource.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// ProcessorPage
			// 
			this.ProcessorPage.Controls.Add(this.AddPreProcessor);
			this.ProcessorPage.Controls.Add(this.RemovePreProcessor);
			this.ProcessorPage.Controls.Add(this.label11);
			this.ProcessorPage.Controls.Add(this.label10);
			this.ProcessorPage.Controls.Add(this.ProcessorValue);
			this.ProcessorPage.Controls.Add(this.PreProcessors);
			this.ProcessorPage.Controls.Add(this.label2);
			this.ProcessorPage.Controls.Add(this.label1);
			this.ProcessorPage.Controls.Add(this.ProcessorMethod);
			this.ProcessorPage.Controls.Add(this.ProcessorsBack);
			this.ProcessorPage.Controls.Add(this.ProcessorsNext);
			this.ProcessorPage.Controls.Add(this.ProcessorMappings);
			this.ProcessorPage.Location = new System.Drawing.Point(4, 22);
			this.ProcessorPage.Name = "ProcessorPage";
			this.ProcessorPage.Size = new System.Drawing.Size(776, 464);
			this.ProcessorPage.TabIndex = 4;
			this.ProcessorPage.Text = "Processors";
			this.ProcessorPage.UseVisualStyleBackColor = true;
			// 
			// AddPreProcessor
			// 
			this.AddPreProcessor.Enabled = false;
			this.AddPreProcessor.Location = new System.Drawing.Point(651, 66);
			this.AddPreProcessor.Name = "AddPreProcessor";
			this.AddPreProcessor.Size = new System.Drawing.Size(100, 23);
			this.AddPreProcessor.TabIndex = 6;
			this.AddPreProcessor.Text = "Add";
			this.AddPreProcessor.UseVisualStyleBackColor = true;
			this.AddPreProcessor.Click += new System.EventHandler(this.AddPreProcessorClick);
			// 
			// RemovePreProcessor
			// 
			this.RemovePreProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemovePreProcessor.Enabled = false;
			this.RemovePreProcessor.Location = new System.Drawing.Point(28, 398);
			this.RemovePreProcessor.Name = "RemovePreProcessor";
			this.RemovePreProcessor.Size = new System.Drawing.Size(100, 23);
			this.RemovePreProcessor.TabIndex = 9;
			this.RemovePreProcessor.Text = "Remove";
			this.RemovePreProcessor.UseVisualStyleBackColor = true;
			this.RemovePreProcessor.Click += new System.EventHandler(this.RemovePreProcessorClick);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label11.Location = new System.Drawing.Point(25, 160);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 17);
			this.label11.TabIndex = 7;
			this.label11.Text = "pre-processors";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label10.Location = new System.Drawing.Point(592, 20);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 17);
			this.label10.TabIndex = 4;
			this.label10.Text = "value";
			// 
			// ProcessorValue
			// 
			this.ProcessorValue.Location = new System.Drawing.Point(595, 40);
			this.ProcessorValue.Name = "ProcessorValue";
			this.ProcessorValue.Size = new System.Drawing.Size(156, 20);
			this.ProcessorValue.TabIndex = 5;
			this.ProcessorValue.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
			// 
			// PreProcessors
			// 
			this.PreProcessors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PreProcessors.FormattingEnabled = true;
			this.PreProcessors.Location = new System.Drawing.Point(28, 180);
			this.PreProcessors.Name = "PreProcessors";
			this.PreProcessors.Size = new System.Drawing.Size(723, 212);
			this.PreProcessors.TabIndex = 8;
			this.PreProcessors.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(25, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "mappings";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(353, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "method";
			// 
			// ProcessorMethod
			// 
			this.ProcessorMethod.FormattingEnabled = true;
			this.ProcessorMethod.Location = new System.Drawing.Point(356, 40);
			this.ProcessorMethod.Name = "ProcessorMethod";
			this.ProcessorMethod.Size = new System.Drawing.Size(223, 108);
			this.ProcessorMethod.TabIndex = 3;
			this.ProcessorMethod.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// ProcessorsBack
			// 
			this.ProcessorsBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessorsBack.Location = new System.Drawing.Point(595, 409);
			this.ProcessorsBack.Name = "ProcessorsBack";
			this.ProcessorsBack.Size = new System.Drawing.Size(75, 30);
			this.ProcessorsBack.TabIndex = 10;
			this.ProcessorsBack.Text = "Back";
			this.ProcessorsBack.UseVisualStyleBackColor = true;
			this.ProcessorsBack.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// ProcessorsNext
			// 
			this.ProcessorsNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessorsNext.Location = new System.Drawing.Point(676, 409);
			this.ProcessorsNext.Name = "ProcessorsNext";
			this.ProcessorsNext.Size = new System.Drawing.Size(75, 30);
			this.ProcessorsNext.TabIndex = 11;
			this.ProcessorsNext.Text = "Next";
			this.ProcessorsNext.UseVisualStyleBackColor = true;
			this.ProcessorsNext.Click += new System.EventHandler(this.NextButtonClick);
			// 
			// ProcessorMappings
			// 
			this.ProcessorMappings.FormattingEnabled = true;
			this.ProcessorMappings.Location = new System.Drawing.Point(28, 40);
			this.ProcessorMappings.Name = "ProcessorMappings";
			this.ProcessorMappings.Size = new System.Drawing.Size(312, 108);
			this.ProcessorMappings.TabIndex = 1;
			this.ProcessorMappings.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// ProcessPage
			// 
			this.ProcessPage.Controls.Add(this.ProcessLabel);
			this.ProcessPage.Controls.Add(this.ProcessBack);
			this.ProcessPage.Controls.Add(this.ProcessTextBox);
			this.ProcessPage.Controls.Add(this.ProgressBar);
			this.ProcessPage.Controls.Add(this.Process);
			this.ProcessPage.Location = new System.Drawing.Point(4, 22);
			this.ProcessPage.Name = "ProcessPage";
			this.ProcessPage.Size = new System.Drawing.Size(776, 464);
			this.ProcessPage.TabIndex = 3;
			this.ProcessPage.Text = "Process";
			this.ProcessPage.UseVisualStyleBackColor = true;
			// 
			// ProcessLabel
			// 
			this.ProcessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ProcessLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProcessLabel.ForeColor = System.Drawing.SystemColors.Highlight;
			this.ProcessLabel.Location = new System.Drawing.Point(28, 385);
			this.ProcessLabel.Name = "ProcessLabel";
			this.ProcessLabel.Size = new System.Drawing.Size(513, 21);
			this.ProcessLabel.TabIndex = 1;
			this.ProcessLabel.Visible = false;
			// 
			// ProcessBack
			// 
			this.ProcessBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessBack.Location = new System.Drawing.Point(595, 409);
			this.ProcessBack.Name = "ProcessBack";
			this.ProcessBack.Size = new System.Drawing.Size(75, 30);
			this.ProcessBack.TabIndex = 3;
			this.ProcessBack.Text = "Back";
			this.ProcessBack.UseVisualStyleBackColor = true;
			this.ProcessBack.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// ProcessTextBox
			// 
			this.ProcessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessTextBox.Location = new System.Drawing.Point(28, 27);
			this.ProcessTextBox.Multiline = true;
			this.ProcessTextBox.Name = "ProcessTextBox";
			this.ProcessTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ProcessTextBox.Size = new System.Drawing.Size(723, 343);
			this.ProcessTextBox.TabIndex = 0;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgressBar.Location = new System.Drawing.Point(28, 409);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(549, 30);
			this.ProgressBar.TabIndex = 2;
			// 
			// Process
			// 
			this.Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Process.Location = new System.Drawing.Point(676, 409);
			this.Process.Name = "Process";
			this.Process.Size = new System.Drawing.Size(75, 30);
			this.Process.TabIndex = 4;
			this.Process.Text = "Process";
			this.Process.UseVisualStyleBackColor = true;
			this.Process.Click += new System.EventHandler(this.ProcessButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(600, 600);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rosetta";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.TabControl.ResumeLayout(false);
			this.DataStoresPage.ResumeLayout(false);
			this.DataStoresPage.PerformLayout();
			this.ConfigureSourcePage.ResumeLayout(false);
			this.ConfigureDestinationPage.ResumeLayout(false);
			this.MappingPage.ResumeLayout(false);
			this.MappingPage.PerformLayout();
			this.ProcessorPage.ResumeLayout(false);
			this.ProcessorPage.PerformLayout();
			this.ProcessPage.ResumeLayout(false);
			this.ProcessPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label Header;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.OpenFileDialog CsvFileDialog;
		private CustomTabControl TabControl;
		private System.Windows.Forms.TabPage ConfigureDestinationPage;
		private System.Windows.Forms.Button ConfigureDestinationBack;
		private System.Windows.Forms.Button ConfigureDestinationNext;
		private System.Windows.Forms.TabPage MappingPage;
		private System.Windows.Forms.ListBox Mappings;
		private System.Windows.Forms.Button RemoveMapping;
		private System.Windows.Forms.Button AddMapping;
		private System.Windows.Forms.ListBox MappingDestination;
		private System.Windows.Forms.ListBox MappingSource;
		private System.Windows.Forms.TabPage ProcessPage;
		private System.Windows.Forms.Button Process;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.TextBox ProcessTextBox;
		private System.Windows.Forms.TabPage ProcessorPage;
		private System.Windows.Forms.ListBox ProcessorMappings;
		private System.Windows.Forms.Button MappingBack;
		private System.Windows.Forms.Button MappingNext;
		private System.Windows.Forms.Button ProcessorsBack;
		private System.Windows.Forms.Button ProcessorsNext;
		private System.Windows.Forms.Button ProcessBack;
		private System.Windows.Forms.Label ProcessLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox ProcessorMethod;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox PreProcessors;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox ProcessorValue;
		private System.Windows.Forms.Button AddPreProcessor;
		private System.Windows.Forms.Button RemovePreProcessor;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox MappingType;
		private System.Windows.Forms.Button LoadButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TabPage DataStoresPage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button DataStoresNext;
		private System.Windows.Forms.TabPage ConfigureSourcePage;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button ConfigureSourceBack;
		private System.Windows.Forms.Button ConfigureSourceNext;
		private DataSourceConfigurationControl SourceConfiguration;
		private DataSourceConfigurationControl DestinationConfiguration;
		private System.Windows.Forms.ListBox Sources;
		private System.Windows.Forms.ListBox Destinations;
	}
}

