using API.Interface;
using System;

namespace API.Database
{
    public class DatabaseProgram : IHelloWorldService
    {
        public void WriteHelloWorld()
        {
            WriteToDatabase("Hello World");
        }

        public void WriteToDatabase(string arg)
        {
            using (var context = new HelloWorldProgramContext())
            {
                // In the future, write to db table using DB Context object
                throw new NotImplementedException();
            }
        }
    }
}
