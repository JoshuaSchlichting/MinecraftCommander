using System;
using System.Collections.Generic;

using ShellAdapterPackage;


namespace WindowCommanderPackage
{
	public class WindowCommander: IWindowCommander
 	{
		private IShell Shell;
		private int WindowID { get; init; }

		public WindowCommander(IShell shell, int windowID)
		{
			this.Shell = shell;
			this.WindowID = windowID;
		}

		public void SendKey(KeyEnum key)
		{
		}

		public void SendString(string str)
		{
			
		}

		private string ExecuteCommand(List<string> commandArgs)
		{
			List<string> internalArgs = new List<string>
			{
				"--window", this.WindowID.ToString(),
			};
			internalArgs.AddRange(commandArgs);
			return this.Shell.Execute(
				command: "xdotool",
				args: internalArgs
			);
		}
	}
}