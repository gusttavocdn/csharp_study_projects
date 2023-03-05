using System.ComponentModel.DataAnnotations;
using MoviesAPI.Models;

namespace MoviesAPI.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The street is required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "The number is required")]
        public int Number { get; set; }

        public virtual MovieTheater MovieTheater { get; set; }
    }
}