using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextService.API.Models;

namespace TextService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        // POST api/text/charactercount/
        [HttpPost("characterCount/")]
        public ActionResult<int> CharacterCount([FromBody] InputModel input)
        {
            return input.Text.Length;
        }

        // POST api/text/wordcount/
        [HttpPost("wordCount/")]
        public ActionResult<int> WordCount ([FromBody] InputModel input)
        {
            return input.Text.Split(" ").Length;
        }

    }
}
