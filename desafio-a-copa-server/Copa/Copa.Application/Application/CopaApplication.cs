using AutoMapper;
using Copa.Application.Contracts;
using Copa.Application.ViewModels;
using Copa.Domain.Contracts.Services;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Application.Application
{
    public class CopaApplication : ICopaApplication
    {
        private readonly ICopaServiceDomain _copaServiceDomain;
        private readonly IMapper _mapper;

        public CopaApplication(ICopaServiceDomain copaServiceDomain,
                              IMapper mapper)
        {
            _copaServiceDomain = copaServiceDomain;
            _mapper = mapper;
        }
            

        public IList<EquipeViewModel> ProcesseCopa(List<EquipeViewModel> equipes) =>
            _mapper.Map<List<EquipeViewModel>>(_copaServiceDomain.ProcesseCopa(_mapper.Map<List<Equipe>>(equipes)));
        
    }
}
