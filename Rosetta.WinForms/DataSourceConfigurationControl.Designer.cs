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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.AlignmentPanel = new System.Windows.Forms.Panel();
			this.AlignmentRight = new System.Windows.Forms.RadioButton();
			this.AlignmentLeft = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.LengthPanel = new System.Windows.Forms.Panel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.PadCharacterPanel = new System.Windows.Forms.Panel();
			this.PadCharacter = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.AddHeader = new System.Windows.Forms.Button();
			this.RemoveHeader = new System.Windows.Forms.Button();
			this.HeaderName = new System.Windows.Forms.TextBox();
			this.HeaderNameLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Sources = new System.Windows.Forms.ListView();
			this.FilePanel = new System.Windows.Forms.Panel();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.FileName = new System.Windows.Forms.Label();
			this.FileConnectionString = new System.Windows.Forms.Label();
			this.ButtonLoad = new System.Windows.Forms.Button();
			this.SqlPanel = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.SqlConnectionString = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.HeaderPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.AlignmentPanel.SuspendLayout();
			this.LengthPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.PadCharacterPanel.SuspendLayout();
			this.FilePanel.SuspendLayout();
			this.SqlPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Controls.Add(this.flowLayoutPanel1);
			this.HeaderPanel.Controls.Add(this.RemoveHeader);
			this.HeaderPanel.Controls.Add(this.HeaderName);
			this.HeaderPanel.Controls.Add(this.HeaderNameLabel);
			this.HeaderPanel.Controls.Add(this.label3);
			this.HeaderPanel.Controls.Add(this.Sources);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HeaderPanel.Location = new System.Drawing.Point(239, 82);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(531, 389);
			this.HeaderPanel.TabIndex = 0;
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
			this.LengthPanel.Controls.Add(this.numericUpDown1);
			this.LengthPanel.Controls.Add(this.label7);
			this.LengthPanel.Location = new System.Drawing.Point(0, 56);
			this.LengthPanel.Margin = new System.Windows.Forms.Padding(0);
			this.LengthPanel.Name = "LengthPanel";
			this.LengthPanel.Size = new System.Drawing.Size(209, 56);
			this.LengthPanel.TabIndex = 1;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(0, 20);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(209, 20);
			this.numericUpDown1.TabIndex = 80;
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
			this.AddHeader.Enabled = false;
			this.AddHeader.Location = new System.Drawing.Point(109, 168);
			this.AddHeader.Margin = new System.Windows.Forms.Padding(0);
			this.AddHeader.Name = "AddHeader";
			this.AddHeader.Size = new System.Drawing.Size(100, 23);
			this.AddHeader.TabIndex = 80;
			this.AddHeader.Text = "Add";
			this.AddHeader.UseVisualStyleBackColor = true;
			// 
			// RemoveHeader
			// 
			this.RemoveHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveHeader.Enabled = false;
			this.RemoveHeader.Location = new System.Drawing.Point(134, 353);
			this.RemoveHeader.Name = "RemoveHeader";
			this.RemoveHeader.Size = new System.Drawing.Size(100, 23);
			this.RemoveHeader.TabIndex = 79;
			this.RemoveHeader.Text = "Remove";
			this.RemoveHeader.UseVisualStyleBackColor = true;
			// 
			// HeaderName
			// 
			this.HeaderName.Location = new System.Drawing.Point(264, 37);
			this.HeaderName.Name = "HeaderName";
			this.HeaderName.Size = new System.Drawing.Size(209, 20);
			this.HeaderName.TabIndex = 78;
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
			// Sources
			// 
			this.Sources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Sources.HideSelection = false;
			this.Sources.Location = new System.Drawing.Point(25, 37);
			this.Sources.Name = "Sources";
			this.Sources.Size = new System.Drawing.Size(209, 310);
			this.Sources.TabIndex = 75;
			this.Sources.UseCompatibleStateImageBehavior = false;
			this.Sources.View = System.Windows.Forms.View.List;
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
			// SqlPanel
			// 
			this.SqlPanel.Controls.Add(this.label5);
			this.SqlPanel.Controls.Add(this.listView1);
			this.SqlPanel.Controls.Add(this.button1);
			this.SqlPanel.Controls.Add(this.SqlConnectionString);
			this.SqlPanel.Controls.Add(this.label4);
			this.SqlPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.SqlPanel.Location = new System.Drawing.Point(0, 82);
			this.SqlPanel.Name = "SqlPanel";
			this.SqlPanel.Size = new System.Drawing.Size(239, 389);
			this.SqlPanel.TabIndex = 3;
			this.SqlPanel.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label5.Location = new System.Drawing.Point(22, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 17);
			this.label5.TabIndex = 83;
			this.label5.Text = "tables";
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(25, 114);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(209, 233);
			this.listView1.TabIndex = 82;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(134, 63);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 81;
			this.button1.Text = "connect";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// SqlConnectionString
			// 
			this.SqlConnectionString.Location = new System.Drawing.Point(25, 37);
			this.SqlConnectionString.Name = "SqlConnectionString";
			this.SqlConnectionString.Size = new System.Drawing.Size(209, 20);
			this.SqlConnectionString.TabIndex = 80;
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
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
		private System.Windows.Forms.ListView Sources;
		private System.Windows.Forms.Panel FilePanel;
		private System.Windows.Forms.Panel SqlPanel;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Label FileName;
		private System.Windows.Forms.Label FileConnectionString;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox SqlConnectionString;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel AlignmentPanel;
		private System.Windows.Forms.Panel LengthPanel;
		private System.Windows.Forms.RadioButton AlignmentRight;
		private System.Windows.Forms.RadioButton AlignmentLeft;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Panel PadCharacterPanel;
		private System.Windows.Forms.TextBox PadCharacter;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button ButtonLoad;
	}
}
