using Copa.Domain.Contracts.Services;
using Copa.Domain.Copa;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.ServiceDomain
{
    public class CopaServiceDomain : ICopaServiceDomain
    {
        public IList<Equipe> ProcesseCopa(List<Equipe> equipes) => new CopaBuilder(equipes)
                                                                        .ExecutePrimeiraFase()
                                                                        .ExecuteSemifinais()
                                                                        .ExecuteFinal()
                                                                        .Finalistas;
        
    }
}
