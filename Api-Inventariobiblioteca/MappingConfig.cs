//using APICL.Models;
//using APICL.Models.dto;
using Api_Inventariobiblioteca.Models;
using Api_Inventariobiblioteca.Models.ModelDto;
using AutoMapper;
namespace APICL
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Autore, AutorDto>().ReverseMap();
            CreateMap<LibroDto, VLibro>().ReverseMap();
            CreateMap<TipoAutorDto, TipoAutor>().ReverseMap();
            CreateMap<TipoLibroDto, TipoLibro>().ReverseMap();



        }
    }
}
