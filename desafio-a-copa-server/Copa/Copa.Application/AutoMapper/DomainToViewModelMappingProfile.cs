using AutoMapper;
using Copa.Application.Application;
using Copa.Application.ViewModels;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Copa.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Equipe, EquipeViewModel>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomeEquipe.NomeCompleto))
                .ForMember(dest => dest.Sigla, opt => opt.MapFrom(src => src.NomeEquipe.Sigla));

        }
    }
}
