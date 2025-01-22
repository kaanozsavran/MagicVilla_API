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
        public IEnumerable<VillaDTO> GetVillas() {
            return VillaStore.villaList;
        }

        [HttpGet("{id:int}")] // you can use like just id
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        }
    }
}
