using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")] // For route
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet] //For get method
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}", Name = "GetVilla")] // you can use like just id
        [ProducesResponseType(StatusCodes.Status200OK)] //status code for 200
        [ProducesResponseType(StatusCodes.Status400BadRequest)] //status code for 400
        [ProducesResponseType(StatusCodes.Status404NotFound)] //status code for 404
        //[ProducesResponseType(200, Type=typeof(VillaDTO))]    you can use this code instead of the under code for VillaDTO

        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        //Post
        [HttpPost] // for get method
        [ProducesResponseType(StatusCodes.Status201Created)] //status code for 201
        [ProducesResponseType(StatusCodes.Status400BadRequest)] //status code for 400
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] //status code for 500
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO)
        {
            if(villaDTO == null)
            {
                return BadRequest(villaDTO);
            }
            if (villaDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            villaDTO.Id = VillaStore.villaList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            VillaStore.villaList.Add(villaDTO);

            return CreatedAtRoute("GetVilla", new { id=villaDTO.Id } , villaDTO);
        }
    }
}
