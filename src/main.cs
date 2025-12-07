namespace CodecraftersShell
{
    class Program
    {
        private const string StartOfInputConsole = "$ ";

        static void Main()
        {
            //TODO: Uncomment the code below to pass the first stage


            ConsoleManager manager = new ConsoleManager();
            while (true)
            {
                Console.Write(StartOfInputConsole);
                var command = Console.ReadLine();
                Console.WriteLine(manager.CommandInput(command));
            }
            
        }
    }

}
