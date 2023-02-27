using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class ReadAddressDTO
{
    public int Id { get; set; }
    public string Street { get; set; }
    public int Number { get; set; }
}