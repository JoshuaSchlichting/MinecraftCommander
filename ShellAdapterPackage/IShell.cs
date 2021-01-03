using System.Collections.Generic;


namespace ShellAdapterPackage
{
	public interface IShell
	{
		public string Execute(string command, List<string> args);
	}
}