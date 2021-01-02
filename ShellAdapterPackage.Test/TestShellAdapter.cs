using System;
using System.Threading;
using Xunit;

using ShellAdapter;

namespace ShellAdapter.Test
{
	public class TestShellWrapper
	{
		[Fact]
		public void ShellAdapterShallReturnTextFromCommand()
		{
			IShell shellAdapter = new ShellWrapper();
			CancellationToken cancelToken = new CancellationToken();
			string responseString = shellAdapter.Execute(
				command: "echo",
				args: new string[]{"hello world"}
			);
			Assert.Equal("hello world\n", responseString);

		}
	}
}
