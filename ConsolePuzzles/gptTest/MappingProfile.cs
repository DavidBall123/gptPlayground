﻿using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace gptTest
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress,
                                       opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
        }
    }
}
