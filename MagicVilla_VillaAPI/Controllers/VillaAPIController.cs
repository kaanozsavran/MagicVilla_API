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
        public ActionResult <IEnumerable<VillaDTO>> GetVillas() {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}")] // you can use like just id
        public ActionResult <VillaDTO> GetVilla(int id)
        {
            if(id == 0)
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
    }
}
