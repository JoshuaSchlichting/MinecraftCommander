using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ShellAdapterPackage
{
	public class ShellWrapper: IShell
	{

		public string Execute(string command, string[] args)
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

		private string GetStringFomStringArray(string[] args)
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