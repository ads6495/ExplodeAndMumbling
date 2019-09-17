using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ExplodeAndMumbling.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> GetMyMath(string s)

    {
      return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }

  }
}