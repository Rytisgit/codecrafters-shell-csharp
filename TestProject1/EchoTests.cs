using CodecraftersShell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class EchoTests
    {
        private void test(int x) { }
        ConsoleManager manager;
        public EchoTests()
        {
            Action<int> fakeExit = test;
            manager = new ConsoleManager(test);
        }
        [Theory]
        [InlineData(new string[] {"test"}, "test")]
        [InlineData(new string[] { "test", "test" }, "test test")]
        [InlineData(new string[] { "test", " " }, "test  ")]
        [InlineData(new string[] { "foo", "bar", "baz" }, "foo bar baz")]
        [InlineData(new string[] { "hello", "world"}, "hello world")]
        public void WhenValidEchoCommandWithArgumentsIsEntered_ThenArgumentsAreCorrectlyEchoed(string[] arguments, string expectedOutput)
        {
            var output = manager.HandleEcho(arguments);
            Assert.Equal(expectedOutput, output);
        }
    }
}
