using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public VillaAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: api/<VillaController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(_db.Villas);
        }

        // GET api/<VillaController>/5
        [HttpGet("{id:int}", Name ="GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = _db.Villas.FirstOrDefault(u=>u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        // POST api/<VillaController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO)
        {
            if (_db.Villas.FirstOrDefault(u=>u.Name.ToLower() == villaDTO.Name.ToLower())!=null)
            {
                ModelState.AddModelError("CustomError", "Villa already Exists!");
                return BadRequest();
            }

            if(villaDTO == null)
            {  return BadRequest(); }
            if (villaDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Villa model = new Villa()
            {
                Amenity = villaDTO.Amenity,
                Details = villaDTO.Details,
                Id = villaDTO.Id,
                ImageUrl = villaDTO.ImageUrl,
                Name = villaDTO.Name,
                Occuoancy = villaDTO.Occuoancy,
                Rate = villaDTO.Rate,
                Sqft = villaDTO.Sqft,
            };
            _db.Villas.Add(model);
            _db.SaveChanges();
            return CreatedAtRoute("GetVilla", new { id = villaDTO.Id }, villaDTO);
        }

        // PUT api/<VillaController>/5
        [HttpPut("{id:int}", Name ="UpdateVilla")]
        public IActionResult UpdateVilla(int id, [FromBody] VillaDTO villaDTO)
        {
            if (villaDTO == null||id != villaDTO.Id) {  return BadRequest(); }
            Villa model = new Villa(){ 
                Id = villaDTO.Id,
                Amenity = villaDTO.Amenity,
                Details = villaDTO.Details,
                ImageUrl= villaDTO.ImageUrl,
                Name = villaDTO.Name,
                Occuoancy= villaDTO.Occuoancy,
                Rate = villaDTO.Rate,
                Sqft = villaDTO.Sqft,
                
            };
            _db.Update(model);
            _db.SaveChanges();
            return NoContent();
        }

        // DELETE api/<VillaController>/5
        [HttpDelete("{id:int}", Name ="DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = _db.Villas.FirstOrDefault(x => x.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            _db.Villas.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }

        
    }
}
