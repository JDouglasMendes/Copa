using Copa.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Application.Contracts
{
    public interface ICopaApplication
    {
        IList<EquipeViewModel> ProcesseCopa(List<EquipeViewModel> equipes);
    }
}
