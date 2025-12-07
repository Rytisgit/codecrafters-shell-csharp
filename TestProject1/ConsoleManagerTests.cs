using CodecraftersShell;

namespace TestProject1
{
    public class ConsoleManagerTests
    {
        int exitCode = 0;
        int FinalExitCode = 99;

        private void ExitAction(int x) { exitCode = FinalExitCode; }


        ConsoleManager manager;
        public ConsoleManagerTests()
        {
            manager = new ConsoleManager(ExitAction);
        }
        [Fact]
        public void WhenExitCommandIsEntered_ThenExitMethodIsCalled()
        {
            var output = manager.CommandInput("exit");
            Assert.Equal(exitCode, FinalExitCode);
        }
        [Fact]
        public void WhenEchoCommandIsEntered_ThenEchoMethodIsCalled()
        {
            var output = manager.CommandInput("echo test");

            Assert.Equal("test", output);
        }
    }
}
