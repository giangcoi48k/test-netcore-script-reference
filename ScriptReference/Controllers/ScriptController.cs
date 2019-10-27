using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScriptReference.Properties;

namespace ScriptReference.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScriptController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok(Resources.Script);
        }
    }
}
