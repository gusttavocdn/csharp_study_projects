using AutoMapper;
using MoviesAPI.Models;
using MoviesAPI.Data.Dtos;

namespace MoviesAPI.Profiles;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, ReadAddressDTO>();
        CreateMap<CreateAddressDTO, Address>();
        CreateMap<UpdateAddressDTO, Address>();
    }
}