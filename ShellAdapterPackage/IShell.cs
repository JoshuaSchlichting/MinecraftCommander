using System;

namespace ShellAdapterPackage
{
	public interface IShell
	{
		public string Execute(string command, string[] args);
	}
}