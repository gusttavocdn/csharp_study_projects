using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class CreateSessionDTO
{
    [Required(ErrorMessage = "The field with name {0} is required")]
    public int MovieId { get; set; }

    [Required(ErrorMessage = "The field with name {0} is required")]
    public int MovieTheaterId { get; set; }
}
