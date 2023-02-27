using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

public class Movie
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    [MaxLength(50, ErrorMessage = "The gender cannot be 50 char longer")]
    public string Gender { get; set; }

    [Required()]
    [Range(70, 600, ErrorMessage = "Duration must be between 70 and 600 minutes")]
    public int Duration { get; set; }

    public virtual ICollection<Session> Sessions { get; set; }
}