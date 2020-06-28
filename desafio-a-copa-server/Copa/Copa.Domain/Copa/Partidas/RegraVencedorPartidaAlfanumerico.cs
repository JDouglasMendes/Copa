using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.Partidas
{
    public class RegraVencedorPartidaAlfanumerico : IRegraVencedorPartida
    {
        public short PrioridadeRegra => 4;

        public Equipe ExecuteRegra(Equipe primeiraEquipe, Equipe segundaEquipe) => 
           primeiraEquipe.NomeEquipe < segundaEquipe.NomeEquipe ? primeiraEquipe : segundaEquipe;        
    }
}
