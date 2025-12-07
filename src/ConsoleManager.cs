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

        public ConsoleManager() {
        }

        public string CommandInput(string command) {
            if (command == null) {
                return "";
            }
            return $"{command}: command not found";
        }
    }
}
