using APBD_REST_API.Database;
using Microsoft.AspNetCore.Mvc;

namespace APBD_REST_API.Controllers;
[Route("api/visits")]
public class VisitsController : ControllerBase
{
    
    [HttpGet()]
    public IActionResult GetVisits()
    {
        var data = Data._visits;
        return Ok(data);
    }
    
    [HttpPost()]
    public IActionResult AddVisit(Visit visit)
    {
        
        foreach (var animal in Data._visits)
        {
            if (animal.Animal.Id == visit.Animal.Id)
            {
                Data._visits.Add(visit);
                return StatusCode(StatusCodes.Status201Created);
            }

        }
        return NotFound($"Animal with an id {visit.Animal.Id} not found.");
    }
}