using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExplosiveAPIs2.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("explode")]

    public string Explode(string s)
    {
      // split string into numbers
      var answerString = "";
      foreach (var letter in s)
      {
        var number = int.Parse(letter.ToString());
        // find the value of each number
        // duplicate the number value times
        for (var i = 0; i < number; i++)
        {
          answerString += letter;
        }
      }
      // return a copy of the numbers duplicated
      return answerString;
    }

  }
}