namespace CodecraftersShell
{
    class Program
    {
        static void Main()
        {
            //TODO: Uncomment the code below to pass the first stage


            ConsoleManager manager = new ConsoleManager();
            while (true)
            {
                Console.Write("$ ");
                var command = Console.ReadLine();
                Console.WriteLine(manager.CommandInput(command));
            }
            
        }
    }

}
