using CodecraftersShell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class InputTests
    {
        ConsoleManager manager;
        public InputTests()
        {
            manager = new ConsoleManager();
        }
        [Fact]
        public void WhenInvalidCommandIsEntered_ThenConsoleManagerReturnsBadCommand()
        {
            var output = manager.CommandInput("test");
            Assert.Equal("test: command not found", output);
        }
        [Fact]
        public void WhenNullCommandIsEntered_ThenConsoleManagerReturnsNothing()
        {
            var output = manager.CommandInput(null);
            Assert.Equal("", output);
        }
    }
}
