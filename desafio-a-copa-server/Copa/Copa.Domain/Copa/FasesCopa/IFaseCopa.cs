using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.FasesCopa
{
    public interface IFaseCopa
    {
        IList<Equipe> ExecuteFase(List<Equipe> equipes);
    }
}
