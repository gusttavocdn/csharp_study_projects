using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos
{
    public class CreateAddressDTO
    {

        [Required(ErrorMessage = "The street is required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "The number is required")]
        public int Number { get; set; }

    }

}