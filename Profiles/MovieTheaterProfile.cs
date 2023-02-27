using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles;

public class MovieTheaterProfile : Profile
{
    public MovieTheaterProfile()
    {
        CreateMap<CreateMovieTheaterDTO, MovieTheater>();
        CreateMap<UpdateMovieTheaterDTO, MovieTheater>();
        CreateMap<MovieTheater, ReadMovieTheaterDTO>()
            .ForMember(movieTheaterDTO => movieTheaterDTO.Address,
             opt => opt.MapFrom(movieTheater => movieTheater.Address))
            .ForMember(movieTheaterDTO => movieTheaterDTO.Sessions,
             opt => opt.MapFrom(movieTheater => movieTheater.Sessions));
    }
}