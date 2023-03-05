using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos
{

    public class UpdateAddressDTO
    {
        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Number is required")]
        public int Number { get; set; }
    }
}