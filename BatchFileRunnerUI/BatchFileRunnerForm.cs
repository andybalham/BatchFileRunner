using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFileRunnerUI
{
	public partial class BatchFileRunnerForm : Form
	{
        private const string BatchFilesFileName = "BatchFiles.bat";

        #region Member declarations

        private List<BatchFile> batchFiles = new List<BatchFile>();

		#endregion

		#region Constructors

		public BatchFileRunnerForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Private methods

		private void BatchFileRunnerForm_Load(object sender, EventArgs e)
		{
			RefreshBatchFileList();
		}


		private void RefreshBatchFileList()
		{
			using (new WaitCursor())
			{
				if (!File.Exists(BatchFilesFileName))
                {
					using (var streamWriter = File.CreateText(BatchFilesFileName)) {}
                }

				string[] batchFileLines = File.ReadAllLines(BatchFilesFileName);

				this.batchFiles.Clear();

				BatchFile currentBatchFile = null;

				foreach (string batchFileLine in batchFileLines)
				{
					Match batchFileStartMatch = Regex.Match(batchFileLine, "rem ==(?<title>.*)", RegexOptions.IgnoreCase);

					if (batchFileStartMatch.Success)
					{
						if (currentBatchFile != null)
						{
							this.batchFiles.Add(currentBatchFile);
						}

						currentBatchFile = new BatchFile(batchFileStartMatch.Groups["title"].Value, batchFileLine);
					}
					else
					{
						if (currentBatchFile != null)
						{
							currentBatchFile.Lines.Add(batchFileLine);
						}
					}
				}

				if (currentBatchFile != null)
				{
					this.batchFiles.Add(currentBatchFile);
				}

				this.batchFileListBox.DataSource = null;
				this.batchFileListBox.DataSource = batchFiles;
			}
		}


		private void refreshButton_Click(object sender, EventArgs e)
		{
			RefreshBatchFileList();
		}


		private void executeButton_Click(object sender, EventArgs e)
		{
			using (new WaitCursor())
			{
				const string tempBatFileName = "Temp.bat";

				File.WriteAllText(tempBatFileName, this.previewTextBox.Text);

				Process process = new Process();
				process.StartInfo.FileName = tempBatFileName;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.Start();

				this.outputTextBox.Text = process.StandardOutput.ReadToEnd();

			}

			MessageBox.Show("Done", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		private void batchFileListBox_SelectedValueChanged(object sender, EventArgs e)
		{
			using (new WaitCursor())
			{
				StringBuilder previewBuilder = new StringBuilder();

				foreach (BatchFile selectedBatchFile in this.batchFileListBox.SelectedItems)
				{
					selectedBatchFile.Lines.ForEach(l => previewBuilder.AppendLine(l));
				}

				this.previewTextBox.Text = previewBuilder.ToString();
			}
		}

		#endregion
	}
}
