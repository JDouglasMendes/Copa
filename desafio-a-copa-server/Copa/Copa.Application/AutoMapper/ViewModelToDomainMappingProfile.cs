using AutoMapper;
using Copa.Application.Application;
using Copa.Application.ViewModels;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Copa.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EquipeViewModel, Equipe>()
                .ConstructUsing(e => new Equipe(e.Id, e.Nome, e.Sigla,e.Gols));

        }
    }
}
