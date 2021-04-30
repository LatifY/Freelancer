using Freelancer.Entities;
using System;
using System.Windows.Forms;

namespace Freelancer
{
	public class LogManager
	{
		public void LogInfo(string data)
		{
			Console.WriteLine("INFO: "+data);
		}

		public void LogWarning(string data)
		{
			Console.WriteLine("WARNING: " + data);
		}

		public void LogError(string data)
		{
			Console.WriteLine("ERROR: "+data);
		}

		public void LogMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			MessageBox.Show(message, title, buttons, icon);
		}
	}
}
