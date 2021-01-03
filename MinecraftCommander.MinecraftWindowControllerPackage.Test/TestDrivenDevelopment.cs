using System;
using Xunit;
using MinecraftCommander.MinecraftWindowControllerPackage;

namespace MinecraftCommander.MinecraftWindowControllerPackage.Test
{
    public class TestDrivenDevelopment
    {
        [Fact]
        public void InstantiateMinecraftWindowController()
        {
            MinecraftWindowController controller = new MinecraftWindowController();
        }
    }
}
