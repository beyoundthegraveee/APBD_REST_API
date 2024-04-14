using APBD_REST_API.Database;
using Microsoft.AspNetCore.Mvc;
namespace APBD_REST_API.Controllers;
[Route("api/animals")]
[ApiController]
public class AnimalController: ControllerBase
{
    
    [HttpGet()]
    public IActionResult GetAnimals()
    {
        var data = Data._animals;
        return Ok(data);
    }
    
    

    [HttpGet( "{id:int}")]
    public IActionResult GetAnimalWithId(int id)
    {
        var animal = Data._animals.FirstOrDefault(s => s.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with an id {id} not found.");
            
        }
        return Ok(animal);
    }
    
    
    [HttpPost()]
    public IActionResult AddAnimal(Animal animal)
    {
        Data._animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var tmp = Data._animals.FirstOrDefault(s => s.Id == id);
        if (tmp == null)
        {
            return NotFound($"Animal with an id {id} not found.");
            
        }

        Data._animals.Remove(tmp);
        Data._animals.Add(animal);

        return StatusCode(StatusCodes.Status202Accepted);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var tmp = Data._animals.FirstOrDefault(s => s.Id == id);
        if (tmp == null)
        {
            return NotFound($"Animal with an id {id} not found.");
            
        }

        Data._animals.Remove(tmp);
        return StatusCode(StatusCodes.Status202Accepted);
    }
    
    
    
    
    

}