using Microsoft.AspNetCore.Mvc;

namespace APBD_REST_API.Controllers;
[Route("api/animals")]
[ApiController]
public class AnimalController: ControllerBase
{

    private static readonly List<Animal> _animals = new()
    {
        new Animal(1, "pies", "zwierzę domowe", 36.7, "czarny"),
        new Animal(2, "kot", "zwierzę domowe", 21.2, "rudy"),
        new Animal(3, "papuga", "ptak", 0.05, "niebieski"),
        new Animal(4, "wróbel", "ptak", 0.03, "szary"),
        new Animal(5, "szczupak", "ryba", 2.3, "srebrny"),
        new Animal(6, "okoń", "ryba",0.7, "niebieski")
        
    };

    private static readonly List<Visit> _visits = new()
    {
        new Visit(_animals[0], "Wizyta kontrolna", 50.0, new DateTime(2024, 4, 22)),
        new Visit(_animals[1], "Wizyta szczepionkowa", 40.0, new DateTime(2024, 5, 06)),
        new Visit(_animals[1], "Badanie ogólne", 60.0, new DateTime(2024, 1, 15)),
        new Visit(_animals[4], "Leczenie zranienia", 80.0, new DateTime(2024, 7, 11)),
        new Visit(_animals[4], "Badanie profilaktyczne", 30.0, new DateTime(2024, 12, 11)),
        new Visit(_animals[2], "Konsultacja", 45.0, new DateTime(2024, 9, 12))
    };
    
    [HttpGet("animals")]
    public IActionResult GetAnimals()
    {
        return Ok(_animals);
    }
    
    [HttpGet("visits")]
    public IActionResult GetVisits()
    {
        return Ok(_visits);
    }
    

    [HttpGet( "{id:int}")]
    public IActionResult GetAnimalWithId(int id)
    {
        var animal = _animals.FirstOrDefault(s => s.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with an id {id} not found.");
            
        }
        return Ok(animal);
    }
    
    
    [HttpPost("animals")]
    public IActionResult AddAnimal(Animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPost("visits")]
    public IActionResult AddVisit(Visit visit)
    {
        
        foreach (var animal in _animals)
        {
            if (animal.Id == visit.Animal.Id)
            {
                _visits.Add(visit);
                return StatusCode(StatusCodes.Status201Created);
            }

        }
        return NotFound($"Animal with an id {visit.Animal.Id} not found.");
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var tmp = _animals.FirstOrDefault(s => s.Id == id);
        if (tmp == null)
        {
            return NotFound($"Animal with an id {id} not found.");
            
        }

        _animals.Remove(tmp);
        _animals.Add(animal);

        return StatusCode(StatusCodes.Status202Accepted);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var tmp = _animals.FirstOrDefault(s => s.Id == id);
        if (tmp == null)
        {
            return NotFound($"Animal with an id {id} not found.");
            
        }

        _animals.Remove(tmp);
        return StatusCode(StatusCodes.Status202Accepted);
    }
    
    
    
    
    

}