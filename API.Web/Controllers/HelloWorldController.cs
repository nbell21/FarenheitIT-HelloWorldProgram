using API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Web.Controllers
{
    public class HelloWorldController : Controller, IHelloWorldService
    {
        public void WriteHelloWorld()
        {
            WriteToBrowser("Hello World");
        }

        // GET api/WriteToBrowser/arg
        [HttpGet]
        [Route("api/[controller]/WriteToBrowser/{arg}")]
        public string WriteToBrowser(string arg)
        {
            return arg;
        }

    }
}
