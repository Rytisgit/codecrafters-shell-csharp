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
        private void test(int x) { }
        ConsoleManager manager;
        public InputTests()
        {
            Action<int> fakeExit = test;
            manager = new ConsoleManager(test);
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
        [Theory]
        [InlineData(@"'hello    world'", "hello    world")]
        [InlineData(@"hello    world", "hello world")]
        [InlineData(@"'hello''world'", "helloworld")]
        [InlineData(@"hello''world", "helloworld")]
        [InlineData(@"asdfasdfas    ' asdfas'  asdf", "asdfasdfas  asdfas asdf")]
        [InlineData(@"'hello    world'    'hello    world'", "hello    world hello    world")]
        public void WhenSingleQuoteParamenterAreInput_ThenArgumentsAreParsedCorrectly(string argumentToParse, string expectedOutput)
        {
            var output = ConsoleManager.ParseInput(argumentToParse);
            Assert.Equal(expectedOutput, string.Join(" ", output));
        }
    }
}
