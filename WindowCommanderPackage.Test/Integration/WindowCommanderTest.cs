using System;
using System.Linq;
using System.Collections.Generic;

using Xunit;
using Moq;

using ShellAdapterPackage;

namespace WindowCommanderPackage.Test
{
	public class WindowCommanderTest
	{
		private const string CommandPrefix = "xdotool --window";

		[Fact]
		public void TestWindowCommanderSendsFKeys()
		{
			var mockShell = new Mock<IShell>();
			WindowCommander commander = new WindowCommander(shell: mockShell.Object, windowID:0);

			for (int i = 0; i < 12; i++)
			{
				string fKey = (i + 1).ToString();
				commander.SendKey(/*TODO: Dynamically call KeyEnum.F<dynamic this part, fkey number>*/);
				mockShell.Verify(
					x => x.Execute(
						It.Is<string>(s => s.StartsWith("xdotool")),
						It.Is<List<string>>(s => s[2].Equals(string.Concat("F", fKey)))
					)
				);
			}
		}
	}
}
