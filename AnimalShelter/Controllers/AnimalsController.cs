using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    ///<summary>
    ///Get every Instance of Animal
    ///</summary>

    ///<remarks>Lookup an animal by inputted properties and return key details about the animal</remarks>

    ///<param name="name" example="Snickers">Name</param>
    ///<param name="category" example="Horse">Category</param>
    ///<param name="intelligence" example="4">Intelligence</param>
    ///<param name="temperment" example="Stupid">Temperment</param>
    ///<param name="friendliness" example="Sweet">Friendliness</param>
    ///<param name="ailment" example="Hip Dysplasia">Ailment</param>

    ///<returns>JSON describing animal data to the entered animal id# (I think)</returns>

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string name, string category, int intelligence, string temperment, string friendliness, string ailment)
    {
      var query = _db.Animals.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }

      if (intelligence != 0)
      {
        query = query.Where(entry => entry.Intelligence == intelligence);
      }

      if (temperment != null)
      {
        query = query.Where(entry => entry.Temperment == temperment);
      }

      if (friendliness != null)
      {
        query = query.Where(entry => entry.Friendliness == friendliness);
      }

      if (ailment != null)
      {
        query = query.Where(entry => entry.Ailment == ailment);
      }
      return await query.ToListAsync();
    }
    ///<summary>
    ///Update Animal Information.
    ///</summary>

    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { IDbContextFactory = animal.AnimalId }, animal);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }
      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }
      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }
      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  }
}