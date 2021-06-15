using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.Controllers
{
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiController]
  [ApiVersion("1.0")]
  [ApiVersion("1.1")]
  public class DefaultController : ControllerBase
  {
    string[] authors = new string[]
    { "Giancarlo Vigneri" };
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return authors;
    }
    [HttpGet("{id}")]
    [MapToApiVersion("2.0")]
    public string Get(int id)
    {
      if (id > authors.Length + 1)
      {
        return "YOOOO! this aint real.";
      }
      return authors[id];
    }
  }
}