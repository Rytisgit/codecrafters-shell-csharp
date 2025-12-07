namespace CodecraftersShell
{
    class Program
    {
        static void Main()
        {
            //TODO: Uncomment the code below to pass the first stage
            Console.Write("$ ");
            var command = Console.ReadLine();
            ConsoleManager manager = new ConsoleManager();
            
            Console.WriteLine(manager.CommandInput(command));
        }
    }

}
