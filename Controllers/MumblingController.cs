using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace ExplosiveAPIs2.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("mumble")]
    public string Mumble(string s)
    {
      // s.toLower()
      s = s.ToLower();
      // set the repeat to 1
      var timesToRepeatTheLetter = 1;
      var answerString = "";
      // foreach letter in s
      foreach (var letter in s)
      {
        // repeat the letter timesToRepeatTheLetter times
        for (var i = 0; i < timesToRepeatTheLetter; i++)
        {
          if (i == 0)
          {
            answerString += letter.ToString().ToUpper();
          }
          else
          {
            answerString += letter;
          }
        }
        // add hyphen
        answerString += "-";
        //  increment the timestorepeat (++)
        timesToRepeatTheLetter++;
      }
      // return string, trim last hyphen
      return answerString.TrimEnd('-');
    }
  }
}