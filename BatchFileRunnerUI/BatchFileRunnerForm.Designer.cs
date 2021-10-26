namespace BatchFileRunnerUI
{
	partial class BatchFileRunnerForm
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
			System.Windows.Forms.GroupBox groupBox1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchFileRunnerForm));
			this.batchFileListBox = new System.Windows.Forms.ListBox();
			this.previewTextBox = new System.Windows.Forms.TextBox();
			this.previewAndOutputTabControl = new System.Windows.Forms.TabControl();
			this.previewTabPage = new System.Windows.Forms.TabPage();
			this.outputTabPage = new System.Windows.Forms.TabPage();
			this.outputTextBox = new System.Windows.Forms.TextBox();
			this.executeButton = new System.Windows.Forms.Button();
			this.refreshButton = new System.Windows.Forms.Button();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			groupBox1 = new System.Windows.Forms.GroupBox();
			groupBox1.SuspendLayout();
			this.previewAndOutputTabControl.SuspendLayout();
			this.previewTabPage.SuspendLayout();
			this.outputTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.batchFileListBox);
			groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			groupBox1.Location = new System.Drawing.Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(744, 242);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Batch &Files";
			// 
			// batchFileListBox
			// 
			this.batchFileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.batchFileListBox.FormattingEnabled = true;
			this.batchFileListBox.Location = new System.Drawing.Point(6, 19);
			this.batchFileListBox.Name = "batchFileListBox";
			this.batchFileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.batchFileListBox.Size = new System.Drawing.Size(732, 212);
			this.batchFileListBox.TabIndex = 0;
			this.batchFileListBox.SelectedValueChanged += new System.EventHandler(this.batchFileListBox_SelectedValueChanged);
			// 
			// previewTextBox
			// 
			this.previewTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewTextBox.Location = new System.Drawing.Point(3, 3);
			this.previewTextBox.Multiline = true;
			this.previewTextBox.Name = "previewTextBox";
			this.previewTextBox.ReadOnly = true;
			this.previewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.previewTextBox.Size = new System.Drawing.Size(730, 206);
			this.previewTextBox.TabIndex = 0;
			this.previewTextBox.WordWrap = false;
			// 
			// previewAndOutputTabControl
			// 
			this.previewAndOutputTabControl.Controls.Add(this.previewTabPage);
			this.previewAndOutputTabControl.Controls.Add(this.outputTabPage);
			this.previewAndOutputTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewAndOutputTabControl.Location = new System.Drawing.Point(0, 0);
			this.previewAndOutputTabControl.Name = "previewAndOutputTabControl";
			this.previewAndOutputTabControl.SelectedIndex = 0;
			this.previewAndOutputTabControl.Size = new System.Drawing.Size(744, 238);
			this.previewAndOutputTabControl.TabIndex = 0;
			// 
			// previewTabPage
			// 
			this.previewTabPage.Controls.Add(this.previewTextBox);
			this.previewTabPage.Location = new System.Drawing.Point(4, 22);
			this.previewTabPage.Name = "previewTabPage";
			this.previewTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.previewTabPage.Size = new System.Drawing.Size(736, 212);
			this.previewTabPage.TabIndex = 0;
			this.previewTabPage.Text = "Preview";
			this.previewTabPage.UseVisualStyleBackColor = true;
			// 
			// outputTabPage
			// 
			this.outputTabPage.Controls.Add(this.outputTextBox);
			this.outputTabPage.Location = new System.Drawing.Point(4, 22);
			this.outputTabPage.Name = "outputTabPage";
			this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.outputTabPage.Size = new System.Drawing.Size(609, 85);
			this.outputTabPage.TabIndex = 1;
			this.outputTabPage.Text = "Output";
			this.outputTabPage.UseVisualStyleBackColor = true;
			// 
			// outputTextBox
			// 
			this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputTextBox.Location = new System.Drawing.Point(3, 3);
			this.outputTextBox.Multiline = true;
			this.outputTextBox.Name = "outputTextBox";
			this.outputTextBox.ReadOnly = true;
			this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.outputTextBox.Size = new System.Drawing.Size(603, 79);
			this.outputTextBox.TabIndex = 1;
			this.outputTextBox.WordWrap = false;
			// 
			// executeButton
			// 
			this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.executeButton.Location = new System.Drawing.Point(762, 31);
			this.executeButton.Name = "executeButton";
			this.executeButton.Size = new System.Drawing.Size(75, 23);
			this.executeButton.TabIndex = 1;
			this.executeButton.Text = "E&xecute";
			this.executeButton.UseVisualStyleBackColor = true;
			this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
			// 
			// refreshButton
			// 
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshButton.Location = new System.Drawing.Point(762, 60);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 23);
			this.refreshButton.TabIndex = 2;
			this.refreshButton.Text = "&Refresh";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(12, 12);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(groupBox1);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.previewAndOutputTabControl);
			this.splitContainer.Size = new System.Drawing.Size(744, 484);
			this.splitContainer.SplitterDistance = 242;
			this.splitContainer.TabIndex = 0;
			// 
			// BatchFileRunnerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 508);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.executeButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BatchFileRunnerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Batch File Runner";
			this.Load += new System.EventHandler(this.BatchFileRunnerForm_Load);
			groupBox1.ResumeLayout(false);
			this.previewAndOutputTabControl.ResumeLayout(false);
			this.previewTabPage.ResumeLayout(false);
			this.previewTabPage.PerformLayout();
			this.outputTabPage.ResumeLayout(false);
			this.outputTabPage.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox batchFileListBox;
		private System.Windows.Forms.TextBox previewTextBox;
		private System.Windows.Forms.TabControl previewAndOutputTabControl;
		private System.Windows.Forms.TabPage previewTabPage;
		private System.Windows.Forms.TabPage outputTabPage;
		private System.Windows.Forms.TextBox outputTextBox;
		private System.Windows.Forms.Button executeButton;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.SplitContainer splitContainer;
	}
}

