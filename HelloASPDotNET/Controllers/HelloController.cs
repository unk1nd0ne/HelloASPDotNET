using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /helloworld/
        [HttpGet]
        public IActionResult Index()
        {
            //string html = "<h1>" + "Hello World!" + "<h1>";
            string html = "<form method='post' action='/helloworld'>" +
                "<input type='text' name='name' />" +
                "<select name='lang'>" +
                    "<option value='Hello'> English </option>" +
                    "<option value='Bounjour'> French </option>" +
                    "<option value='Hallo'> German </option>" +
                    "<option value='Hola'> Spanish </option>" +
                    "<option value='Hallo'> Norwegian </option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        // POST: /helloworld/
        //[HttpGet("welcome/{name?}")]
        //[HttpPost("welcome")]
        [HttpPost]
        public IActionResult Welcome(string name = "World", string lang = "Hello")
        {
            return Content($"<h1>{lang} {name}.</h1>", "text/html");

            //return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
