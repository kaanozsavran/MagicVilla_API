using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a Villa.")]
        public int VillaID { get; set; }

        public string SpecialDetails { get; set; }

    }
}
