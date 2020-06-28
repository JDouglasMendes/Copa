using AutoMapper;
using Copa.Application.Application;
using Copa.Application.ViewModels;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Equipe, EquipeViewModel>();
        }
    }
}
