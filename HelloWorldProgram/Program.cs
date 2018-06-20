using API.Interface;
using System.Collections.Generic;

namespace HelloWorldProgram
{
    class Program
    {
        public static List<string> apiTypes = new List<string>() { "Console", "Web", "Database" };

        static void Main(string[] args)
        {
            foreach (var apiType in apiTypes)
            {

                IHelloWorldService apiService = ApiFactory.GetHelloWorldService(apiType);

                apiService.WriteHelloWorld(); 
            }
        }
    }
}
