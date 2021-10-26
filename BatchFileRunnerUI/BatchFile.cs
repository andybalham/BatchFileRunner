using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFileRunnerUI
{
	class BatchFile
	{
		#region Public properties

		public Guid Id { get; private set; }

		public string Title { get; private set; }

		public List<string> Lines { get; private set; }

		#endregion

		#region Constructors

		public BatchFile(string title, string firstLine)
		{
			this.Id = new Guid();
			this.Title = title;
			this.Lines = new List<string>(new string[] { firstLine });
		}

		#endregion

		#region Overrides

		public override string ToString()
		{
			return this.Title;
		}

		#endregion
	}
}
