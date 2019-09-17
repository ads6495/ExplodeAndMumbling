using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ExplodeAndMumbling.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplodeController : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> GetOurMath(string s)
    {
      return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));
    }
  }
}