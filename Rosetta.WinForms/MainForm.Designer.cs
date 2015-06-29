namespace TransformR.WinForms
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
			this.CsvFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.TabControl = new TransformR.WinForms.CustomTabControl();
			this.SourcePage = new System.Windows.Forms.TabPage();
			this.SourceFileName = new System.Windows.Forms.Label();
			this.RemoveSourceHeader = new System.Windows.Forms.Button();
			this.SourceHeader = new System.Windows.Forms.TextBox();
			this.AddSourceHeader = new System.Windows.Forms.Button();
			this.SourceHeaders = new System.Windows.Forms.ListBox();
			this.SourceOpenFile = new System.Windows.Forms.Button();
			this.SourceNext = new System.Windows.Forms.Button();
			this.Sources = new System.Windows.Forms.ListView();
			this.DestinationPage = new System.Windows.Forms.TabPage();
			this.DestinationFileName = new System.Windows.Forms.Label();
			this.RemoveDestinationHeader = new System.Windows.Forms.Button();
			this.DestinationHeader = new System.Windows.Forms.TextBox();
			this.AddDestinationHeader = new System.Windows.Forms.Button();
			this.DestinationHeaders = new System.Windows.Forms.ListBox();
			this.DestinationBack = new System.Windows.Forms.Button();
			this.DestinationSelectFile = new System.Windows.Forms.Button();
			this.DestinationNext = new System.Windows.Forms.Button();
			this.Destinations = new System.Windows.Forms.ListView();
			this.MappingPage = new System.Windows.Forms.TabPage();
			this.Mappings = new System.Windows.Forms.ListBox();
			this.RemoveMapping = new System.Windows.Forms.Button();
			this.AddMapping = new System.Windows.Forms.Button();
			this.MappingDestination = new System.Windows.Forms.ListBox();
			this.MappingSource = new System.Windows.Forms.ListBox();
			this.MappingBack = new System.Windows.Forms.Button();
			this.MappingNext = new System.Windows.Forms.Button();
			this.ProcessPage = new System.Windows.Forms.TabPage();
			this.ProcessTextBox = new System.Windows.Forms.TextBox();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.Process = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.SourcePage.SuspendLayout();
			this.DestinationPage.SuspendLayout();
			this.MappingPage.SuspendLayout();
			this.ProcessPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header
			// 
			this.Header.AutoSize = true;
			this.Header.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Header.Location = new System.Drawing.Point(19, 9);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(111, 45);
			this.Header.TabIndex = 0;
			this.Header.Text = "Source";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.Header);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(574, 71);
			this.panel1.TabIndex = 3;
			// 
			// CsvFileDialog
			// 
			this.CsvFileDialog.DefaultExt = "*.csv";
			this.CsvFileDialog.FileName = "CsvFileDialog";
			this.CsvFileDialog.Filter = "CSV (csv)|*.csv";
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.SourcePage);
			this.TabControl.Controls.Add(this.DestinationPage);
			this.TabControl.Controls.Add(this.MappingPage);
			this.TabControl.Controls.Add(this.ProcessPage);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 71);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(574, 350);
			this.TabControl.TabIndex = 0;
			this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
			// 
			// SourcePage
			// 
			this.SourcePage.Controls.Add(this.SourceFileName);
			this.SourcePage.Controls.Add(this.RemoveSourceHeader);
			this.SourcePage.Controls.Add(this.SourceHeader);
			this.SourcePage.Controls.Add(this.AddSourceHeader);
			this.SourcePage.Controls.Add(this.SourceHeaders);
			this.SourcePage.Controls.Add(this.SourceOpenFile);
			this.SourcePage.Controls.Add(this.SourceNext);
			this.SourcePage.Controls.Add(this.Sources);
			this.SourcePage.Location = new System.Drawing.Point(4, 22);
			this.SourcePage.Name = "SourcePage";
			this.SourcePage.Padding = new System.Windows.Forms.Padding(3);
			this.SourcePage.Size = new System.Drawing.Size(566, 324);
			this.SourcePage.TabIndex = 0;
			this.SourcePage.Text = "Source";
			this.SourcePage.UseVisualStyleBackColor = true;
			// 
			// SourceFileName
			// 
			this.SourceFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SourceFileName.AutoSize = true;
			this.SourceFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceFileName.Location = new System.Drawing.Point(136, 273);
			this.SourceFileName.Name = "SourceFileName";
			this.SourceFileName.Size = new System.Drawing.Size(71, 21);
			this.SourceFileName.TabIndex = 53;
			this.SourceFileName.Text = "Input.csv";
			this.SourceFileName.Visible = false;
			// 
			// RemoveSourceHeader
			// 
			this.RemoveSourceHeader.Enabled = false;
			this.RemoveSourceHeader.Location = new System.Drawing.Point(354, 232);
			this.RemoveSourceHeader.Name = "RemoveSourceHeader";
			this.RemoveSourceHeader.Size = new System.Drawing.Size(67, 23);
			this.RemoveSourceHeader.TabIndex = 51;
			this.RemoveSourceHeader.Text = "Remove";
			this.RemoveSourceHeader.UseVisualStyleBackColor = true;
			this.RemoveSourceHeader.Click += new System.EventHandler(this.RemoveSourceHeader_Click);
			// 
			// SourceHeader
			// 
			this.SourceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceHeader.Enabled = false;
			this.SourceHeader.Location = new System.Drawing.Point(281, 206);
			this.SourceHeader.Name = "SourceHeader";
			this.SourceHeader.Size = new System.Drawing.Size(260, 20);
			this.SourceHeader.TabIndex = 50;
			this.SourceHeader.TextChanged += new System.EventHandler(this.SourceHeader_TextChanged);
			// 
			// AddSourceHeader
			// 
			this.AddSourceHeader.Enabled = false;
			this.AddSourceHeader.Location = new System.Drawing.Point(281, 232);
			this.AddSourceHeader.Name = "AddSourceHeader";
			this.AddSourceHeader.Size = new System.Drawing.Size(67, 23);
			this.AddSourceHeader.TabIndex = 49;
			this.AddSourceHeader.Text = "Add";
			this.AddSourceHeader.UseVisualStyleBackColor = true;
			this.AddSourceHeader.Click += new System.EventHandler(this.AddSourceHeader_Click);
			// 
			// SourceHeaders
			// 
			this.SourceHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceHeaders.Enabled = false;
			this.SourceHeaders.FormattingEnabled = true;
			this.SourceHeaders.Location = new System.Drawing.Point(281, 27);
			this.SourceHeaders.Name = "SourceHeaders";
			this.SourceHeaders.Size = new System.Drawing.Size(260, 173);
			this.SourceHeaders.TabIndex = 48;
			this.SourceHeaders.SelectedIndexChanged += new System.EventHandler(this.SourceHeaders_SelectedIndexChanged);
			// 
			// SourceOpenFile
			// 
			this.SourceOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SourceOpenFile.Enabled = false;
			this.SourceOpenFile.Location = new System.Drawing.Point(28, 269);
			this.SourceOpenFile.Name = "SourceOpenFile";
			this.SourceOpenFile.Size = new System.Drawing.Size(98, 30);
			this.SourceOpenFile.TabIndex = 4;
			this.SourceOpenFile.Text = "Open File";
			this.SourceOpenFile.UseVisualStyleBackColor = true;
			this.SourceOpenFile.Click += new System.EventHandler(this.SourceOpenFile_Click);
			// 
			// SourceNext
			// 
			this.SourceNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceNext.Enabled = false;
			this.SourceNext.Location = new System.Drawing.Point(466, 269);
			this.SourceNext.Name = "SourceNext";
			this.SourceNext.Size = new System.Drawing.Size(75, 30);
			this.SourceNext.TabIndex = 2;
			this.SourceNext.Text = "Next";
			this.SourceNext.UseVisualStyleBackColor = true;
			this.SourceNext.Click += new System.EventHandler(this.SourceNext_Click);
			// 
			// Sources
			// 
			this.Sources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Sources.Location = new System.Drawing.Point(28, 27);
			this.Sources.Name = "Sources";
			this.Sources.Size = new System.Drawing.Size(209, 233);
			this.Sources.TabIndex = 1;
			this.Sources.UseCompatibleStateImageBehavior = false;
			this.Sources.View = System.Windows.Forms.View.List;
			this.Sources.SelectedIndexChanged += new System.EventHandler(this.Sources_SelectedIndexChanged);
			// 
			// DestinationPage
			// 
			this.DestinationPage.Controls.Add(this.DestinationFileName);
			this.DestinationPage.Controls.Add(this.RemoveDestinationHeader);
			this.DestinationPage.Controls.Add(this.DestinationHeader);
			this.DestinationPage.Controls.Add(this.AddDestinationHeader);
			this.DestinationPage.Controls.Add(this.DestinationHeaders);
			this.DestinationPage.Controls.Add(this.DestinationBack);
			this.DestinationPage.Controls.Add(this.DestinationSelectFile);
			this.DestinationPage.Controls.Add(this.DestinationNext);
			this.DestinationPage.Controls.Add(this.Destinations);
			this.DestinationPage.Location = new System.Drawing.Point(4, 22);
			this.DestinationPage.Name = "DestinationPage";
			this.DestinationPage.Padding = new System.Windows.Forms.Padding(3);
			this.DestinationPage.Size = new System.Drawing.Size(566, 324);
			this.DestinationPage.TabIndex = 1;
			this.DestinationPage.Text = "Destination";
			this.DestinationPage.UseVisualStyleBackColor = true;
			// 
			// DestinationFileName
			// 
			this.DestinationFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DestinationFileName.AutoSize = true;
			this.DestinationFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DestinationFileName.Location = new System.Drawing.Point(136, 273);
			this.DestinationFileName.Name = "DestinationFileName";
			this.DestinationFileName.Size = new System.Drawing.Size(84, 21);
			this.DestinationFileName.TabIndex = 52;
			this.DestinationFileName.Text = "Output.csv";
			this.DestinationFileName.Visible = false;
			// 
			// RemoveDestinationHeader
			// 
			this.RemoveDestinationHeader.Enabled = false;
			this.RemoveDestinationHeader.Location = new System.Drawing.Point(354, 232);
			this.RemoveDestinationHeader.Name = "RemoveDestinationHeader";
			this.RemoveDestinationHeader.Size = new System.Drawing.Size(67, 23);
			this.RemoveDestinationHeader.TabIndex = 51;
			this.RemoveDestinationHeader.Text = "Remove";
			this.RemoveDestinationHeader.UseVisualStyleBackColor = true;
			this.RemoveDestinationHeader.Click += new System.EventHandler(this.RemoveDestinationHeader_Click);
			// 
			// DestinationHeader
			// 
			this.DestinationHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DestinationHeader.Enabled = false;
			this.DestinationHeader.Location = new System.Drawing.Point(281, 206);
			this.DestinationHeader.Name = "DestinationHeader";
			this.DestinationHeader.Size = new System.Drawing.Size(260, 20);
			this.DestinationHeader.TabIndex = 50;
			this.DestinationHeader.TextChanged += new System.EventHandler(this.DestinationHeader_TextChanged);
			// 
			// AddDestinationHeader
			// 
			this.AddDestinationHeader.Enabled = false;
			this.AddDestinationHeader.Location = new System.Drawing.Point(281, 232);
			this.AddDestinationHeader.Name = "AddDestinationHeader";
			this.AddDestinationHeader.Size = new System.Drawing.Size(67, 23);
			this.AddDestinationHeader.TabIndex = 49;
			this.AddDestinationHeader.Text = "Add";
			this.AddDestinationHeader.UseVisualStyleBackColor = true;
			this.AddDestinationHeader.Click += new System.EventHandler(this.AddDestinationHeader_Click);
			// 
			// DestinationHeaders
			// 
			this.DestinationHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DestinationHeaders.Enabled = false;
			this.DestinationHeaders.FormattingEnabled = true;
			this.DestinationHeaders.Location = new System.Drawing.Point(281, 27);
			this.DestinationHeaders.Name = "DestinationHeaders";
			this.DestinationHeaders.Size = new System.Drawing.Size(260, 173);
			this.DestinationHeaders.TabIndex = 48;
			this.DestinationHeaders.SelectedIndexChanged += new System.EventHandler(this.DestinationHeaders_SelectedIndexChanged);
			// 
			// DestinationBack
			// 
			this.DestinationBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DestinationBack.Location = new System.Drawing.Point(385, 269);
			this.DestinationBack.Name = "DestinationBack";
			this.DestinationBack.Size = new System.Drawing.Size(75, 30);
			this.DestinationBack.TabIndex = 5;
			this.DestinationBack.Text = "Back";
			this.DestinationBack.UseVisualStyleBackColor = true;
			this.DestinationBack.Click += new System.EventHandler(this.DestinationBack_Click);
			// 
			// DestinationSelectFile
			// 
			this.DestinationSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DestinationSelectFile.Enabled = false;
			this.DestinationSelectFile.Location = new System.Drawing.Point(28, 269);
			this.DestinationSelectFile.Name = "DestinationSelectFile";
			this.DestinationSelectFile.Size = new System.Drawing.Size(98, 30);
			this.DestinationSelectFile.TabIndex = 4;
			this.DestinationSelectFile.Text = "Select File";
			this.DestinationSelectFile.UseVisualStyleBackColor = true;
			this.DestinationSelectFile.Click += new System.EventHandler(this.DesinationOpenFile_Click);
			// 
			// DestinationNext
			// 
			this.DestinationNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DestinationNext.Enabled = false;
			this.DestinationNext.Location = new System.Drawing.Point(466, 269);
			this.DestinationNext.Name = "DestinationNext";
			this.DestinationNext.Size = new System.Drawing.Size(75, 30);
			this.DestinationNext.TabIndex = 2;
			this.DestinationNext.Text = "Next";
			this.DestinationNext.UseVisualStyleBackColor = true;
			this.DestinationNext.Click += new System.EventHandler(this.DestinationNext_Click);
			// 
			// Destinations
			// 
			this.Destinations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Destinations.Location = new System.Drawing.Point(28, 27);
			this.Destinations.Name = "Destinations";
			this.Destinations.Size = new System.Drawing.Size(209, 233);
			this.Destinations.TabIndex = 1;
			this.Destinations.UseCompatibleStateImageBehavior = false;
			this.Destinations.View = System.Windows.Forms.View.List;
			this.Destinations.SelectedIndexChanged += new System.EventHandler(this.Destinations_SelectedIndexChanged);
			// 
			// MappingPage
			// 
			this.MappingPage.Controls.Add(this.Mappings);
			this.MappingPage.Controls.Add(this.RemoveMapping);
			this.MappingPage.Controls.Add(this.AddMapping);
			this.MappingPage.Controls.Add(this.MappingDestination);
			this.MappingPage.Controls.Add(this.MappingSource);
			this.MappingPage.Controls.Add(this.MappingBack);
			this.MappingPage.Controls.Add(this.MappingNext);
			this.MappingPage.Location = new System.Drawing.Point(4, 22);
			this.MappingPage.Name = "MappingPage";
			this.MappingPage.Size = new System.Drawing.Size(566, 324);
			this.MappingPage.TabIndex = 2;
			this.MappingPage.Text = "Mapping";
			this.MappingPage.UseVisualStyleBackColor = true;
			// 
			// Mappings
			// 
			this.Mappings.FormattingEnabled = true;
			this.Mappings.Location = new System.Drawing.Point(318, 27);
			this.Mappings.Name = "Mappings";
			this.Mappings.Size = new System.Drawing.Size(223, 173);
			this.Mappings.TabIndex = 60;
			this.Mappings.SelectedIndexChanged += new System.EventHandler(this.Mappings_SelectedIndexChanged);
			// 
			// RemoveMapping
			// 
			this.RemoveMapping.Enabled = false;
			this.RemoveMapping.Location = new System.Drawing.Point(441, 206);
			this.RemoveMapping.Name = "RemoveMapping";
			this.RemoveMapping.Size = new System.Drawing.Size(100, 23);
			this.RemoveMapping.TabIndex = 59;
			this.RemoveMapping.Text = "Remove";
			this.RemoveMapping.UseVisualStyleBackColor = true;
			this.RemoveMapping.Click += new System.EventHandler(this.RemoveMapping_Click);
			// 
			// AddMapping
			// 
			this.AddMapping.Location = new System.Drawing.Point(28, 206);
			this.AddMapping.Name = "AddMapping";
			this.AddMapping.Size = new System.Drawing.Size(100, 23);
			this.AddMapping.TabIndex = 56;
			this.AddMapping.Text = "Add";
			this.AddMapping.UseVisualStyleBackColor = true;
			this.AddMapping.Click += new System.EventHandler(this.AddMapping_Click);
			// 
			// MappingDestination
			// 
			this.MappingDestination.FormattingEnabled = true;
			this.MappingDestination.Location = new System.Drawing.Point(163, 27);
			this.MappingDestination.Name = "MappingDestination";
			this.MappingDestination.Size = new System.Drawing.Size(129, 173);
			this.MappingDestination.TabIndex = 55;
			// 
			// MappingSource
			// 
			this.MappingSource.FormattingEnabled = true;
			this.MappingSource.Location = new System.Drawing.Point(28, 27);
			this.MappingSource.Name = "MappingSource";
			this.MappingSource.Size = new System.Drawing.Size(129, 173);
			this.MappingSource.TabIndex = 54;
			// 
			// MappingBack
			// 
			this.MappingBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.MappingBack.Location = new System.Drawing.Point(385, 269);
			this.MappingBack.Name = "MappingBack";
			this.MappingBack.Size = new System.Drawing.Size(75, 30);
			this.MappingBack.TabIndex = 50;
			this.MappingBack.Text = "Back";
			this.MappingBack.UseVisualStyleBackColor = true;
			this.MappingBack.Click += new System.EventHandler(this.MappingBack_Click);
			// 
			// MappingNext
			// 
			this.MappingNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.MappingNext.Enabled = false;
			this.MappingNext.Location = new System.Drawing.Point(466, 269);
			this.MappingNext.Name = "MappingNext";
			this.MappingNext.Size = new System.Drawing.Size(75, 30);
			this.MappingNext.TabIndex = 49;
			this.MappingNext.Text = "Next";
			this.MappingNext.UseVisualStyleBackColor = true;
			this.MappingNext.Click += new System.EventHandler(this.MappingNext_Click);
			// 
			// ProcessPage
			// 
			this.ProcessPage.Controls.Add(this.ProcessTextBox);
			this.ProcessPage.Controls.Add(this.ProgressBar);
			this.ProcessPage.Controls.Add(this.Process);
			this.ProcessPage.Location = new System.Drawing.Point(4, 22);
			this.ProcessPage.Name = "ProcessPage";
			this.ProcessPage.Size = new System.Drawing.Size(566, 324);
			this.ProcessPage.TabIndex = 3;
			this.ProcessPage.Text = "Process";
			this.ProcessPage.UseVisualStyleBackColor = true;
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
			this.ProcessTextBox.Size = new System.Drawing.Size(513, 211);
			this.ProcessTextBox.TabIndex = 52;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgressBar.Location = new System.Drawing.Point(28, 269);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(408, 30);
			this.ProgressBar.TabIndex = 51;
			// 
			// Process
			// 
			this.Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Process.Location = new System.Drawing.Point(466, 269);
			this.Process.Name = "Process";
			this.Process.Size = new System.Drawing.Size(75, 30);
			this.Process.TabIndex = 50;
			this.Process.Text = "Process";
			this.Process.UseVisualStyleBackColor = true;
			this.Process.Click += new System.EventHandler(this.Process_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 421);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(590, 460);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TransformR";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.TabControl.ResumeLayout(false);
			this.SourcePage.ResumeLayout(false);
			this.SourcePage.PerformLayout();
			this.DestinationPage.ResumeLayout(false);
			this.DestinationPage.PerformLayout();
			this.MappingPage.ResumeLayout(false);
			this.ProcessPage.ResumeLayout(false);
			this.ProcessPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label Header;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.OpenFileDialog CsvFileDialog;
		private System.Windows.Forms.TabPage SourcePage;
		private System.Windows.Forms.Button SourceOpenFile;
		private System.Windows.Forms.Button SourceNext;
		private System.Windows.Forms.ListView Sources;
		private CustomTabControl TabControl;
		private System.Windows.Forms.TabPage DestinationPage;
		private System.Windows.Forms.Button DestinationBack;
		private System.Windows.Forms.Button DestinationSelectFile;
		private System.Windows.Forms.Button DestinationNext;
		private System.Windows.Forms.ListView Destinations;
		private System.Windows.Forms.Button RemoveSourceHeader;
		private System.Windows.Forms.TextBox SourceHeader;
		private System.Windows.Forms.Button AddSourceHeader;
		private System.Windows.Forms.ListBox SourceHeaders;
		private System.Windows.Forms.Button RemoveDestinationHeader;
		private System.Windows.Forms.TextBox DestinationHeader;
		private System.Windows.Forms.Button AddDestinationHeader;
		private System.Windows.Forms.ListBox DestinationHeaders;
		private System.Windows.Forms.Label SourceFileName;
		private System.Windows.Forms.Label DestinationFileName;
		private System.Windows.Forms.TabPage MappingPage;
		private System.Windows.Forms.ListBox Mappings;
		private System.Windows.Forms.Button RemoveMapping;
		private System.Windows.Forms.Button AddMapping;
		private System.Windows.Forms.ListBox MappingDestination;
		private System.Windows.Forms.ListBox MappingSource;
		private System.Windows.Forms.Button MappingBack;
		private System.Windows.Forms.Button MappingNext;
		private System.Windows.Forms.TabPage ProcessPage;
		private System.Windows.Forms.Button Process;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.TextBox ProcessTextBox;
	}
}

