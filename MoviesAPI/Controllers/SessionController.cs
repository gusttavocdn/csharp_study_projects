using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class SessionController : ControllerBase
{
    private MovieContext _context;
    private IMapper _mapper;

    public SessionController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddSession(CreateSessionDTO sessionDTO)
    {
        Session session = _mapper.Map<Session>(sessionDTO);
        _context.Sessions.Add(session);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetSessionById),
            new
            {
                movieId = session.MovieId,
                movieTheaterId = session.MovieTheaterId
            }, session);
    }

    [HttpGet]
    public IEnumerable<ReadSessionDTO> GetSessions()
    {
        return _mapper.Map<List<ReadSessionDTO>>(_context.Sessions.ToList());
    }

    [HttpGet("{movieId}/{movieTheaterId}")]
    public IActionResult GetSessionById(int movieId, int movieTheaterId)
    {
        Session session = _context.Sessions.FirstOrDefault(s =>
            s.MovieId == movieId && s.MovieTheaterId == movieTheaterId);

        if (session == null) return NotFound();

        ReadSessionDTO sessionDto = _mapper.Map<ReadSessionDTO>(session);
        return new OkObjectResult(sessionDto);
    }
}

