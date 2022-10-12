using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                "<option value='english' selected>English</option>" +
                "<option value='french'>French</option></select>" +
                "<option value='german'>German</option></select>" +
                "<option value='italian'>Italian</option></select>" +
                "<option value='spanish'>Spanish</option></select>" +
               
                // ... add any other languages here ...
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        // POST: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string helloTranslation = "";
            switch (language)
            {
                case "french":
                    helloTranslation = "Bonjour ";
                    break;
                case "english":
                    helloTranslation = "Hello ";
                    break;
                case "german":
                    helloTranslation = "Guten Tag ";
                    break;
                case "italian":
                    helloTranslation = "Salve ";
                    break;
                case "spanish":
                    helloTranslation = "Hola ";
                    break;
                    // ... add any other languages here ...
            }
            return helloTranslation + name;
        }
    }
}
