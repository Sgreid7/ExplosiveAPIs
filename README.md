# Objectives

- Create 2 endpoints, /api/accum and api/explosion, that are based off of the katas,https://www.codewars.com/kata/mumbling and https://www.codewars.com/kata/digits-explosion respectfully.
- Working with EF Core
- Creating a simple API

# Includes

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
- [EF CORE](https://docs.microsoft.com/en-us/ef/core/)
- [CONTROLLERS](https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.controller?view=aspnet-mvc-5.2)
- [POSTMAN](https://www.postman.com/)
- [MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)

# Featured Code

## Kata Controller

```JSX
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
```
