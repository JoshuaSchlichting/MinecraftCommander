using System.Diagnostics;
using System.Collections.Generic;

namespace ShellAdapterPackage
{
	public class ShellWrapper: IShell
	{

		public string Execute(string command, List<string> args)
		{
			Process p = new Process();
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.FileName = command;
			p.StartInfo.Arguments = GetStringFomStringArray(args: args);
			p.Start();
			string output = p.StandardOutput.ReadToEnd();
			return output;
		}

		private string GetStringFomStringArray(List<string> args)
		{
			string result = "";
			foreach(string s in args)
			{
				result += string.Concat(s, " ");
			}
			return result;
		}
	}
}