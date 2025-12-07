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

        public string CommandInput(string input)
        {
            if (input == null)
            {
                return "";
            }
            string[] splitInput = ParseInput(input);

            return CommandHandler(splitInput[0], splitInput.Skip(1).ToArray());
        }

        public static string[] ParseInput(string input)
        {
            var firstSpace = input.IndexOf(' ');
            if(firstSpace > -1)
            {
                var command = new string(input.Take(firstSpace).ToArray());
                var argsToParse = 
                    (firstSpace == input.Length) 
                    ? "" 
                    : input.Substring(firstSpace+1);
                var parsed = ParseSingleQuote(argsToParse);
                return new string[] { command, parsed };
            }
           
            return new string[] { input };
        }
        private static string[] WhiteSpaceSplit(string input)
        {
            var list = new List<string>();
        }
        private static string ParseSingleQuote(string input)
        {
            var finalString = "";
            var nextQuoteIndex = input.IndexOf(@"'", StringComparison.Ordinal);
            while (nextQuoteIndex >= 0)
            {
                
                var prestring = input.Substring(0, nextQuoteIndex);
                if()
                finalString +=
                input = input.Substring(nextQuoteIndex+1).TrimEnd()+" ";
                nextQuoteIndex = input.IndexOf(@"'", StringComparison.Ordinal);
                finalString += input.Substring(0, nextQuoteIndex);
            }
        }
    }
}
