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
      

        [HttpPost]
        public IActionResult Post([FromBody]CredentialsViewModel imageData)
        {
          
            return new OkObjectResult("Account created");
        }
    }

}