using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;


[ApiController]
[Route("[controller]")]

public class MovieTheaterController : ControllerBase
{
    private MovieContext _context;
    private IMapper _mapper;

    public MovieTheaterController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddMovieTheater([FromBody] CreateMovieTheaterDTO movieTheaterDTO)
    {
        MovieTheater movieTheater = _mapper.Map<MovieTheater>(movieTheaterDTO);
        _context.MovieTheaters.Add(movieTheater);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetMovieTheaterById), new { id = movieTheater.Id }, movieTheater);
    }

    [HttpGet]
    public IEnumerable<ReadMovieTheaterDTO> GetMovieTheaters([FromQuery] int skip = 0, int take = 10)
    {
        return _mapper.Map<List<ReadMovieTheaterDTO>>(_context.MovieTheaters.Skip(skip).Take(take).ToList());
    }


    [HttpGet("{id}")]
    public IActionResult GetMovieTheaterById(int id)
    {
        var movieTheater = _context.MovieTheaters.FirstOrDefault(movieTheater => movieTheater.Id == id);

        if (movieTheater == null) return NotFound();

        var movieDTO = _mapper.Map<ReadMovieTheaterDTO>(movieTheater);

        return new OkObjectResult(movieDTO);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMovieTheater(int id, [FromBody] UpdateMovieTheaterDTO movieTheaterDTO)
    {
        var movieTheater = _context.MovieTheaters.FirstOrDefault(movieTheater => movieTheater.Id == id);

        if (movieTheater == null) return NotFound();

        _mapper.Map(movieTheaterDTO, movieTheater);

        _context.MovieTheaters.Update(movieTheater);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMovieTheater(int id)
    {
        var movieTheater = _context.MovieTheaters.FirstOrDefault(movieTheater => movieTheater.Id == id);
        if (movieTheater == null) return NotFound();

        _context.MovieTheaters.Remove(movieTheater);
        _context.SaveChanges();

        return NoContent();
    }

}