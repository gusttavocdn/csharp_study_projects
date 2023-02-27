using MoviesAPI.Data.Dtos;

namespace MoviesAPI.Data.Dtos
{
    public class ReadMovieDTO
    {
        public string Title { get; set; }
        public string Gender { get; set; }
        public int Duration { get; set; }
        public DateTime time { get; set; } = DateTime.Now;
        public ICollection<ReadSessionDTO> Sessions { get; set; }
    }
}
