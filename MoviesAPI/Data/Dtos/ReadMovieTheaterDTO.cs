namespace MoviesAPI.Data.Dtos;

public class ReadMovieTheaterDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ReadAddressDTO Address { get; set; }
    public ICollection<ReadSessionDTO> Sessions { get; set; }
}