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

        public string CommandHandler(string command, string[] args)
        {
            var res = "";
            switch (command)
            {
                case "exit":
                    ExecExit();
                    break;
                case "echo":
                    res = HandleEcho(args);
                    break;
                default:
                    res = $"{command}: command not found";
                    break;
            }
            return res;
        }

        public string HandleEcho(string[] args)
        {
            return string.Join(" ", args);
        }

        private void ExecExit() {
            exitAction(0);
        }

        public string CommandInput(string input) {
            if (input == null) {
                return "";
            }
            var splitInput = input.Split(' ');

            return CommandHandler(splitInput[0], splitInput.Skip(1).ToArray());
        }
    }
}
