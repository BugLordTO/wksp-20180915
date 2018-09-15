using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Consecutive.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {
        [HttpGet("{input}")]
        public int[] Get(int input)
        {
            var engine = new ConsecutiveEngine();
            var results = engine.Process(input);
            return results;
        }
    }
}
