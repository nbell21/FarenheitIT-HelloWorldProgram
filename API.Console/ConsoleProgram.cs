using API.Interface;

namespace API.Console
{
    public class ConsoleProgram : IHelloWorldService
    {
        public void WriteHelloWorld()
        {
            WriteToConsole("Hello World");
        }

        public void WriteToConsole(string arg)
        {
            System.Console.WriteLine(arg);
        }
    }
}
