using System.Diagnostics;


namespace CommandLineAdapter
{
	public static class CliAdapter
	{

		public static string Execute(string command, string[] args, bool printToConsole=false)
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

		private static string GetStringFomStringArray(string[] args)
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