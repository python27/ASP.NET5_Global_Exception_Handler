using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TestApplication.Controllers
{
    public class ValuesController : Controller
    {
        [Route("api/[controller]")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new Exception();
        }
    }
}
