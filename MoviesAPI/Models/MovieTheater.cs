using System.ComponentModel.DataAnnotations;
using MoviesAPI.Models;

namespace MoviesAPI.Models;

public class MovieTheater
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public int AddressId { get; set; }
    public virtual Address Address { get; set; }

    public virtual ICollection<Session> Sessions { get; set; }
}