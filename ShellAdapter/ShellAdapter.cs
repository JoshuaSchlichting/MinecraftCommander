using System.Diagnostics;


namespace ShellAdapter
{
	public class ShellWrapper: IShell
	{

		public string Execute(string command, string[] args, bool printToConsole=false)
		{
			Process p = new Process();
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.FileName = "xdotool";
			p.StartInfo.Arguments = GetStringFomStringArray(args: args);
			p.Start();
			// TODO: Read this as a stream, printint everything to console
			//       if required
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