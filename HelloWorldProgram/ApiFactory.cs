using API.Console;
using API.Database;
using API.Interface;
using API.Web.Controllers;
using System;

namespace HelloWorldProgram
{
    public static class ApiFactory
    {
        public static IHelloWorldService GetHelloWorldService(string apiType)
        {
            IHelloWorldService service = null;
            switch(apiType)
            {
                case "Console": service = new ConsoleProgram();
                    break;
                case "Web": service = new HelloWorldController();
                    break;
                case "Database":
                    service = new DatabaseProgram();
                    break;
                default:
                    throw new ArgumentException("Invalid apiType");
            }
            return service;
        }
    }
}
