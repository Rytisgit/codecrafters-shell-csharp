using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecraftersShell
{
        public class ConsoleManager
    {
        private readonly Action<int> exitAction;

        public ConsoleManager(Action<int> ExitAction) {
            exitAction = ExitAction;
        }

        public void CommandHandler(string command)
        {
            if (command == "exit") 
            {
                ExecExit();
            }

        }

        private void ExecExit() {
            exitAction(0);
        }

        public string CommandInput(string command) {
            if (command == null) {
                return "";
            }
            CommandHandler(command);
            return $"{command}: command not found";
        }
    }
}
