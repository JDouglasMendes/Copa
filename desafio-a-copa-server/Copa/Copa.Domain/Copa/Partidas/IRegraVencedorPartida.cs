using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.Partidas
{
    public interface IRegraVencedorPartida
    {        
        short PrioridadeRegra { get; }
        Equipe ExecuteRegra(Equipe primeiraEquipe, Equipe segundaEquipe);
    }
}
