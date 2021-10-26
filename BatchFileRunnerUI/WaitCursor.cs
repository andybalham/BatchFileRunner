using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFileRunnerUI
{
	internal class WaitCursor : IDisposable
	{
		#region Member declarations

		private Cursor originalCursor;

		#endregion

		#region Constructors

		public WaitCursor()
		{
			this.originalCursor = Cursor.Current;

			Cursor.Current = Cursors.WaitCursor;
		}
		
		#endregion

		#region IDisposable Members

		public void Dispose()
		{
			Cursor.Current = originalCursor;
		}

		#endregion
	}
}
