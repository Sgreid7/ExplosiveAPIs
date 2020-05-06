using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExplosiveAPIs2.Controllers.Models
{
  public class CheckIn
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public bool CheckedIn { get; set; }


    // POST: api/TodoItems
    [HttpPost]
    public async Task<ActionResult<CheckIn>> PostCheckIn(CheckIn checkIn)
    {
      _context.CheckIns.Add(checkIn);
      await _context.SaveChangesAsync();

      //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
      return CreatedAtAction(nameof(GetCheckIn), new { id = checkIn.Id }, checkIn);
    }
  }
}