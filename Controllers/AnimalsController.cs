using Microsoft.EntityFrameworkCore;
using ShelterApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly ShelterApiContext _db;

    public AnimalsController(ShelterApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()
    {
      return await _db.Animals.ToListAsync();
    }
    
  }  
}