using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API.Console;
using API.Interface;
using API.Web.Controllers;
using API.Database;

namespace HelloWorldProgram.Tests
{
    [TestClass]
    public class HelloWorldProgramTest
    {
        private IHelloWorldService ConsoleAPI;
        private IHelloWorldService WebAPI;
        private IHelloWorldService DbAPI;

        [TestInitialize]
        public void TestSetup()
        {
            ConsoleAPI = new ConsoleProgram();
            WebAPI = new HelloWorldController();
            DbAPI = new DatabaseProgram();
        }

        [TestMethod]
        public void TestConsole()
        {
            try
            {
                ConsoleAPI.WriteHelloWorld();
            }
            catch (Exception e)
            {
                Assert.Fail("Exception was thrown: ", e.Message);
            }
        }

        [TestMethod]
        public void TestWeb()
        {
            try
            {
                WebAPI.WriteHelloWorld();
            }
            catch (Exception e)
            {
                Assert.Fail("Exception was thrown: ", e.Message);
            }
        }

        [TestMethod]
        public void TestDB()
        {
            try
            {
                DbAPI.WriteHelloWorld();
            }
            catch (Exception e)
            {
                Assert.Fail("Exception was thrown: ", e.Message);
            }
        }
    }
}
