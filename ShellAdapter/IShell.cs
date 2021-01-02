using System;

namespace ShellAdapter
{
	public interface IShell
	{
		public string Execute(string command, string[] args);
	}
}