using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Contracts.Services
{
    public interface ICopaServiceDomain
    {
        IList<Equipe> ProcesseCopa(List<Equipe> equipes);
    }
}
