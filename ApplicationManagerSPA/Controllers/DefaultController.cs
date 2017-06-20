using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationManagerSPA.ViewModels;

namespace ApplicationManagerSPA.Controllers
{
    [Produces("application/json")]
    [Route("api/Default")]
    public class DefaultController : Controller
    {
        [HttpGet]
        public string Get() => "hello";

        [HttpPost]
        public IActionResult InsertImage(ImageData imageData)
        {
          
            return new OkObjectResult("Account created");
        }
    }

}