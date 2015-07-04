namespace Rosetta.WinForms
{
	partial class DataSourceConfigurationControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.LoadHeaders = new System.Windows.Forms.Button();
			this.Headers = new System.Windows.Forms.ListBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.AlignmentPanel = new System.Windows.Forms.Panel();
			this.AlignmentRight = new System.Windows.Forms.RadioButton();
			this.AlignmentLeft = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.LengthPanel = new System.Windows.Forms.Panel();
			this.HeaderLength = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.PadCharacterPanel = new System.Windows.Forms.Panel();
			this.PadCharacter = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.AddHeader = new System.Windows.Forms.Button();
			this.RemoveHeader = new System.Windows.Forms.Button();
			this.HeaderName = new System.Windows.Forms.TextBox();
			this.HeaderNameLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.FilePanel = new System.Windows.Forms.Panel();
			this.FileName = new System.Windows.Forms.Label();
			this.FileConnectionString = new System.Windows.Forms.Label();
			this.ButtonLoad = new System.Windows.Forms.Button();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.SqlPanel = new System.Windows.Forms.Panel();
			this.SqlLoadTables = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SqlConnectionString = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SqlTables = new System.Windows.Forms.ListBox();
			this.HeaderPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.AlignmentPanel.SuspendLayout();
			this.LengthPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HeaderLength)).BeginInit();
			this.PadCharacterPanel.SuspendLayout();
			this.FilePanel.SuspendLayout();
			this.SqlPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Controls.Add(this.LoadHeaders);
			this.HeaderPanel.Controls.Add(this.Headers);
			this.HeaderPanel.Controls.Add(this.flowLayoutPanel1);
			this.HeaderPanel.Controls.Add(this.RemoveHeader);
			this.HeaderPanel.Controls.Add(this.HeaderName);
			this.HeaderPanel.Controls.Add(this.HeaderNameLabel);
			this.HeaderPanel.Controls.Add(this.label3);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HeaderPanel.Location = new System.Drawing.Point(239, 82);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(531, 389);
			this.HeaderPanel.TabIndex = 0;
			// 
			// LoadHeaders
			// 
			this.LoadHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LoadHeaders.Location = new System.Drawing.Point(25, 346);
			this.LoadHeaders.Name = "LoadHeaders";
			this.LoadHeaders.Size = new System.Drawing.Size(100, 23);
			this.LoadHeaders.TabIndex = 87;
			this.LoadHeaders.Text = "Load";
			this.LoadHeaders.UseVisualStyleBackColor = true;
			this.LoadHeaders.Click += new System.EventHandler(this.LoadHeadersClick);
			// 
			// Headers
			// 
			this.Headers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Headers.FormattingEnabled = true;
			this.Headers.Location = new System.Drawing.Point(25, 37);
			this.Headers.Name = "Headers";
			this.Headers.Size = new System.Drawing.Size(209, 303);
			this.Headers.TabIndex = 86;
			this.Headers.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.flowLayoutPanel1.Controls.Add(this.AlignmentPanel);
			this.flowLayoutPanel1.Controls.Add(this.LengthPanel);
			this.flowLayoutPanel1.Controls.Add(this.PadCharacterPanel);
			this.flowLayoutPanel1.Controls.Add(this.AddHeader);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(264, 63);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 284);
			this.flowLayoutPanel1.TabIndex = 81;
			// 
			// AlignmentPanel
			// 
			this.AlignmentPanel.Controls.Add(this.AlignmentRight);
			this.AlignmentPanel.Controls.Add(this.AlignmentLeft);
			this.AlignmentPanel.Controls.Add(this.label6);
			this.AlignmentPanel.Location = new System.Drawing.Point(0, 0);
			this.AlignmentPanel.Margin = new System.Windows.Forms.Padding(0);
			this.AlignmentPanel.Name = "AlignmentPanel";
			this.AlignmentPanel.Size = new System.Drawing.Size(209, 56);
			this.AlignmentPanel.TabIndex = 0;
			// 
			// AlignmentRight
			// 
			this.AlignmentRight.AutoSize = true;
			this.AlignmentRight.Location = new System.Drawing.Point(45, 24);
			this.AlignmentRight.Name = "AlignmentRight";
			this.AlignmentRight.Size = new System.Drawing.Size(45, 17);
			this.AlignmentRight.TabIndex = 80;
			this.AlignmentRight.TabStop = true;
			this.AlignmentRight.Text = "right";
			this.AlignmentRight.UseVisualStyleBackColor = true;
			// 
			// AlignmentLeft
			// 
			this.AlignmentLeft.AutoSize = true;
			this.AlignmentLeft.Location = new System.Drawing.Point(0, 24);
			this.AlignmentLeft.Name = "AlignmentLeft";
			this.AlignmentLeft.Size = new System.Drawing.Size(39, 17);
			this.AlignmentLeft.TabIndex = 79;
			this.AlignmentLeft.TabStop = true;
			this.AlignmentLeft.Text = "left";
			this.AlignmentLeft.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label6.Location = new System.Drawing.Point(-3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 17);
			this.label6.TabIndex = 78;
			this.label6.Text = "alignment";
			// 
			// LengthPanel
			// 
			this.LengthPanel.Controls.Add(this.HeaderLength);
			this.LengthPanel.Controls.Add(this.label7);
			this.LengthPanel.Location = new System.Drawing.Point(0, 56);
			this.LengthPanel.Margin = new System.Windows.Forms.Padding(0);
			this.LengthPanel.Name = "LengthPanel";
			this.LengthPanel.Size = new System.Drawing.Size(209, 56);
			this.LengthPanel.TabIndex = 1;
			// 
			// HeaderLength
			// 
			this.HeaderLength.Location = new System.Drawing.Point(0, 20);
			this.HeaderLength.Name = "HeaderLength";
			this.HeaderLength.Size = new System.Drawing.Size(209, 20);
			this.HeaderLength.TabIndex = 80;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label7.Location = new System.Drawing.Point(-3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 17);
			this.label7.TabIndex = 79;
			this.label7.Text = "length";
			// 
			// PadCharacterPanel
			// 
			this.PadCharacterPanel.Controls.Add(this.PadCharacter);
			this.PadCharacterPanel.Controls.Add(this.label8);
			this.PadCharacterPanel.Location = new System.Drawing.Point(0, 112);
			this.PadCharacterPanel.Margin = new System.Windows.Forms.Padding(0);
			this.PadCharacterPanel.Name = "PadCharacterPanel";
			this.PadCharacterPanel.Size = new System.Drawing.Size(209, 56);
			this.PadCharacterPanel.TabIndex = 81;
			// 
			// PadCharacter
			// 
			this.PadCharacter.Location = new System.Drawing.Point(0, 20);
			this.PadCharacter.MaxLength = 1;
			this.PadCharacter.Name = "PadCharacter";
			this.PadCharacter.Size = new System.Drawing.Size(209, 20);
			this.PadCharacter.TabIndex = 80;
			this.PadCharacter.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label8.Location = new System.Drawing.Point(-3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 17);
			this.label8.TabIndex = 79;
			this.label8.Text = "pad character";
			// 
			// AddHeader
			// 
			this.AddHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddHeader.Location = new System.Drawing.Point(109, 168);
			this.AddHeader.Margin = new System.Windows.Forms.Padding(0);
			this.AddHeader.Name = "AddHeader";
			this.AddHeader.Size = new System.Drawing.Size(100, 23);
			this.AddHeader.TabIndex = 80;
			this.AddHeader.Text = "Add";
			this.AddHeader.UseVisualStyleBackColor = true;
			this.AddHeader.Click += new System.EventHandler(this.AddHeaderClick);
			// 
			// RemoveHeader
			// 
			this.RemoveHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveHeader.Location = new System.Drawing.Point(134, 346);
			this.RemoveHeader.Name = "RemoveHeader";
			this.RemoveHeader.Size = new System.Drawing.Size(100, 23);
			this.RemoveHeader.TabIndex = 79;
			this.RemoveHeader.Text = "Remove";
			this.RemoveHeader.UseVisualStyleBackColor = true;
			this.RemoveHeader.Click += new System.EventHandler(this.RemoveHeaderClick);
			// 
			// HeaderName
			// 
			this.HeaderName.Location = new System.Drawing.Point(264, 37);
			this.HeaderName.Name = "HeaderName";
			this.HeaderName.Size = new System.Drawing.Size(209, 20);
			this.HeaderName.TabIndex = 78;
			this.HeaderName.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
			// 
			// HeaderNameLabel
			// 
			this.HeaderNameLabel.AutoSize = true;
			this.HeaderNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeaderNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
			this.HeaderNameLabel.Location = new System.Drawing.Point(261, 17);
			this.HeaderNameLabel.Name = "HeaderNameLabel";
			this.HeaderNameLabel.Size = new System.Drawing.Size(85, 17);
			this.HeaderNameLabel.TabIndex = 77;
			this.HeaderNameLabel.Text = "header name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(22, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 17);
			this.label3.TabIndex = 76;
			this.label3.Text = "headers";
			// 
			// FilePanel
			// 
			this.FilePanel.Controls.Add(this.FileName);
			this.FilePanel.Controls.Add(this.FileConnectionString);
			this.FilePanel.Controls.Add(this.ButtonLoad);
			this.FilePanel.Controls.Add(this.ButtonSave);
			this.FilePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.FilePanel.Location = new System.Drawing.Point(0, 0);
			this.FilePanel.Name = "FilePanel";
			this.FilePanel.Size = new System.Drawing.Size(770, 82);
			this.FilePanel.TabIndex = 2;
			this.FilePanel.Visible = false;
			// 
			// FileName
			// 
			this.FileName.AutoSize = true;
			this.FileName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileName.Location = new System.Drawing.Point(103, 10);
			this.FileName.Name = "FileName";
			this.FileName.Size = new System.Drawing.Size(175, 32);
			this.FileName.TabIndex = 4;
			this.FileName.Text = "Select FileName";
			// 
			// FileConnectionString
			// 
			this.FileConnectionString.AutoSize = true;
			this.FileConnectionString.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileConnectionString.Location = new System.Drawing.Point(105, 45);
			this.FileConnectionString.Name = "FileConnectionString";
			this.FileConnectionString.Size = new System.Drawing.Size(196, 21);
			this.FileConnectionString.TabIndex = 5;
			this.FileConnectionString.Text = "C:\\Users\\John Doe\\Desktop";
			// 
			// ButtonLoad
			// 
			this.ButtonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonLoad.BackColor = System.Drawing.SystemColors.Highlight;
			this.ButtonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonLoad.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonLoad.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.ButtonLoad.Location = new System.Drawing.Point(14, 16);
			this.ButtonLoad.Name = "ButtonLoad";
			this.ButtonLoad.Size = new System.Drawing.Size(75, 50);
			this.ButtonLoad.TabIndex = 6;
			this.ButtonLoad.Text = "";
			this.ButtonLoad.UseVisualStyleBackColor = false;
			this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
			// 
			// ButtonSave
			// 
			this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonSave.BackColor = System.Drawing.SystemColors.Highlight;
			this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSave.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.ButtonSave.Location = new System.Drawing.Point(14, 16);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(75, 50);
			this.ButtonSave.TabIndex = 3;
			this.ButtonSave.Text = "";
			this.ButtonSave.UseVisualStyleBackColor = false;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// SqlPanel
			// 
			this.SqlPanel.Controls.Add(this.SqlLoadTables);
			this.SqlPanel.Controls.Add(this.label5);
			this.SqlPanel.Controls.Add(this.SqlConnectionString);
			this.SqlPanel.Controls.Add(this.label4);
			this.SqlPanel.Controls.Add(this.SqlTables);
			this.SqlPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.SqlPanel.Location = new System.Drawing.Point(0, 82);
			this.SqlPanel.Name = "SqlPanel";
			this.SqlPanel.Size = new System.Drawing.Size(239, 389);
			this.SqlPanel.TabIndex = 3;
			this.SqlPanel.Visible = false;
			// 
			// SqlLoadTables
			// 
			this.SqlLoadTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SqlLoadTables.Location = new System.Drawing.Point(24, 346);
			this.SqlLoadTables.Name = "SqlLoadTables";
			this.SqlLoadTables.Size = new System.Drawing.Size(100, 23);
			this.SqlLoadTables.TabIndex = 84;
			this.SqlLoadTables.Text = "Load";
			this.SqlLoadTables.UseVisualStyleBackColor = true;
			this.SqlLoadTables.Click += new System.EventHandler(this.SqlLoadTablesClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label5.Location = new System.Drawing.Point(22, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 17);
			this.label5.TabIndex = 83;
			this.label5.Text = "tables";
			// 
			// SqlConnectionString
			// 
			this.SqlConnectionString.Location = new System.Drawing.Point(25, 37);
			this.SqlConnectionString.Name = "SqlConnectionString";
			this.SqlConnectionString.Size = new System.Drawing.Size(209, 20);
			this.SqlConnectionString.TabIndex = 80;
			this.SqlConnectionString.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(22, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 17);
			this.label4.TabIndex = 79;
			this.label4.Text = "connection string";
			// 
			// SqlTables
			// 
			this.SqlTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SqlTables.FormattingEnabled = true;
			this.SqlTables.Location = new System.Drawing.Point(24, 89);
			this.SqlTables.Name = "SqlTables";
			this.SqlTables.Size = new System.Drawing.Size(209, 251);
			this.SqlTables.TabIndex = 85;
			this.SqlTables.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
			// 
			// DataSourceConfigurationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.HeaderPanel);
			this.Controls.Add(this.SqlPanel);
			this.Controls.Add(this.FilePanel);
			this.Name = "DataSourceConfigurationControl";
			this.Size = new System.Drawing.Size(770, 471);
			this.Load += new System.EventHandler(this.DataSourceConfigurationControl_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.AlignmentPanel.ResumeLayout(false);
			this.AlignmentPanel.PerformLayout();
			this.LengthPanel.ResumeLayout(false);
			this.LengthPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.HeaderLength)).EndInit();
			this.PadCharacterPanel.ResumeLayout(false);
			this.PadCharacterPanel.PerformLayout();
			this.FilePanel.ResumeLayout(false);
			this.FilePanel.PerformLayout();
			this.SqlPanel.ResumeLayout(false);
			this.SqlPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Button AddHeader;
		private System.Windows.Forms.Button RemoveHeader;
		private System.Windows.Forms.TextBox HeaderName;
		private System.Windows.Forms.Label HeaderNameLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel FilePanel;
		private System.Windows.Forms.Panel SqlPanel;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Label FileName;
		private System.Windows.Forms.Label FileConnectionString;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox SqlConnectionString;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel AlignmentPanel;
		private System.Windows.Forms.Panel LengthPanel;
		private System.Windows.Forms.RadioButton AlignmentRight;
		private System.Windows.Forms.RadioButton AlignmentLeft;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown HeaderLength;
		private System.Windows.Forms.Panel PadCharacterPanel;
		private System.Windows.Forms.TextBox PadCharacter;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button ButtonLoad;
		private System.Windows.Forms.Button SqlLoadTables;
		private System.Windows.Forms.ListBox Headers;
		private System.Windows.Forms.ListBox SqlTables;
		private System.Windows.Forms.Button LoadHeaders;
	}
}
