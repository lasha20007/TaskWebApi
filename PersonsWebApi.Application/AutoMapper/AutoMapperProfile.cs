using AutoMapper;
using PersonsWebApi.Application.DataTransferObject;
using PersonsWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CityDto, City>();
            CreateMap<CityDto, City>().ReverseMap();

            CreateMap<PhoneDto, Phone>();
            CreateMap<PhoneDto, Phone>().ReverseMap();

            CreateMap<PersonDto, Person>();
            CreateMap<PersonDto, Person>().ReverseMap();
        }
    }
}
