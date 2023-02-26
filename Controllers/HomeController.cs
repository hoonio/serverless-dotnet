using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace serverless.Controllers
{
  [ApiController]
  [Route("/")]
  public class HomeController: Controller
  {  

    [HttpGet("pong")]
    public string Get()
    {
      return "serverless";
    }
  
    [HttpGet("version")]
    public string Version()
    {
      return Environment.GetEnvironmentVariable("VERSION");
    }

  }
}
