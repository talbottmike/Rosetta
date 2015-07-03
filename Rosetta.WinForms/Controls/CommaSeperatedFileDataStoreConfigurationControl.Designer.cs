namespace Rosetta.WinForms.Controls
{
	partial class CommaSeperatedFileDataStoreConfigurationControl
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
			this.sourceIncludeHeaders = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SourceFileName = new System.Windows.Forms.Label();
			this.RemoveSourceHeader = new System.Windows.Forms.Button();
			this.SourceHeader = new System.Windows.Forms.TextBox();
			this.AddSourceHeader = new System.Windows.Forms.Button();
			this.SourceHeaders = new System.Windows.Forms.ListBox();
			this.SourceOpenFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// sourceIncludeHeaders
			// 
			this.sourceIncludeHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceIncludeHeaders.AutoSize = true;
			this.sourceIncludeHeaders.Checked = true;
			this.sourceIncludeHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
			this.sourceIncludeHeaders.Location = new System.Drawing.Point(856, -284);
			this.sourceIncludeHeaders.Name = "sourceIncludeHeaders";
			this.sourceIncludeHeaders.Size = new System.Drawing.Size(66, 17);
			this.sourceIncludeHeaders.TabIndex = 77;
			this.sourceIncludeHeaders.Text = "Headers";
			this.sourceIncludeHeaders.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(3, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 17);
			this.label4.TabIndex = 76;
			this.label4.Text = "headers";
			// 
			// SourceFileName
			// 
			this.SourceFileName.AutoSize = true;
			this.SourceFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceFileName.ForeColor = System.Drawing.SystemColors.Highlight;
			this.SourceFileName.Location = new System.Drawing.Point(107, 6);
			this.SourceFileName.Name = "SourceFileName";
			this.SourceFileName.Size = new System.Drawing.Size(71, 21);
			this.SourceFileName.TabIndex = 75;
			this.SourceFileName.Text = "Input.csv";
			this.SourceFileName.Visible = false;
			// 
			// RemoveSourceHeader
			// 
			this.RemoveSourceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveSourceHeader.Enabled = false;
			this.RemoveSourceHeader.Location = new System.Drawing.Point(79, 370);
			this.RemoveSourceHeader.Name = "RemoveSourceHeader";
			this.RemoveSourceHeader.Size = new System.Drawing.Size(67, 23);
			this.RemoveSourceHeader.TabIndex = 74;
			this.RemoveSourceHeader.Text = "Remove";
			this.RemoveSourceHeader.UseVisualStyleBackColor = true;
			// 
			// SourceHeader
			// 
			this.SourceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceHeader.Enabled = false;
			this.SourceHeader.Location = new System.Drawing.Point(6, 344);
			this.SourceHeader.Name = "SourceHeader";
			this.SourceHeader.Size = new System.Drawing.Size(916, 20);
			this.SourceHeader.TabIndex = 73;
			// 
			// AddSourceHeader
			// 
			this.AddSourceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddSourceHeader.Enabled = false;
			this.AddSourceHeader.Location = new System.Drawing.Point(6, 370);
			this.AddSourceHeader.Name = "AddSourceHeader";
			this.AddSourceHeader.Size = new System.Drawing.Size(67, 23);
			this.AddSourceHeader.TabIndex = 72;
			this.AddSourceHeader.Text = "Add";
			this.AddSourceHeader.UseVisualStyleBackColor = true;
			// 
			// SourceHeaders
			// 
			this.SourceHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourceHeaders.Enabled = false;
			this.SourceHeaders.FormattingEnabled = true;
			this.SourceHeaders.Location = new System.Drawing.Point(6, 61);
			this.SourceHeaders.Name = "SourceHeaders";
			this.SourceHeaders.Size = new System.Drawing.Size(916, 277);
			this.SourceHeaders.TabIndex = 71;
			// 
			// SourceOpenFile
			// 
			this.SourceOpenFile.Enabled = false;
			this.SourceOpenFile.Location = new System.Drawing.Point(3, 3);
			this.SourceOpenFile.Name = "SourceOpenFile";
			this.SourceOpenFile.Size = new System.Drawing.Size(98, 30);
			this.SourceOpenFile.TabIndex = 70;
			this.SourceOpenFile.Text = "Open File";
			this.SourceOpenFile.UseVisualStyleBackColor = true;
			// 
			// CommaSeperatedFileDataStoreConfigurationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.sourceIncludeHeaders);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.SourceFileName);
			this.Controls.Add(this.RemoveSourceHeader);
			this.Controls.Add(this.SourceHeader);
			this.Controls.Add(this.AddSourceHeader);
			this.Controls.Add(this.SourceHeaders);
			this.Controls.Add(this.SourceOpenFile);
			this.Name = "CommaSeperatedFileDataStoreConfigurationControl";
			this.Size = new System.Drawing.Size(925, 404);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox sourceIncludeHeaders;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label SourceFileName;
		private System.Windows.Forms.Button RemoveSourceHeader;
		private System.Windows.Forms.TextBox SourceHeader;
		private System.Windows.Forms.Button AddSourceHeader;
		private System.Windows.Forms.ListBox SourceHeaders;
		private System.Windows.Forms.Button SourceOpenFile;
	}
}
