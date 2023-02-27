using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class AddressController : ControllerBase
{
    private readonly MovieContext _context;
    private readonly IMapper _mapper;

    public AddressController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddAddress([FromBody] CreateAddressDTO addressDto)
    {
        var address = _mapper.Map<Address>(addressDto);
        _context.Addresses.Add(address);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetAddressById), new { id = address.Id }, address);
    }

    [HttpGet]
    public IEnumerable<ReadAddressDTO> GetAddresses()
    {
        var addresses = _context.Addresses.ToList();
        return _mapper.Map<List<ReadAddressDTO>>(addresses);
    }

    [HttpGet("{id}")]
    public IActionResult GetAddressById(int id)
    {
        var address = _context.Addresses.FirstOrDefault(a => a.Id == id);
        if (address != null)
        {
            var addressDto = _mapper.Map<ReadAddressDTO>(address);
            return Ok(addressDto);
        }
        return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDTO addressDto)
    {
        var address = _context.Addresses.FirstOrDefault(a => a.Id == id);
        if (address == null)
        {
            return NotFound();
        }
        _mapper.Map(addressDto, address);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAddress(int id)
    {
        var address = _context.Addresses.FirstOrDefault(a => a.Id == id);
        if (address == null)
        {
            return NotFound();
        }
        _context.Addresses.Remove(address);
        _context.SaveChanges();
        return NoContent();
    }
}
