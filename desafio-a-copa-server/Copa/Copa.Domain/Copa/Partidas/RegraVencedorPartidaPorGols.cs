using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.Partidas
{
    public class RegraVencedorPartidaPorGols : IRegraVencedorPartida
    {
        public short PrioridadeRegra => 1;

        public Equipe ExecuteRegra(Equipe primeiraEquipe, Equipe segundaEquipe)
        {
            if (primeiraEquipe.Gols == segundaEquipe.Gols)
                return null;

            if (primeiraEquipe.Gols > segundaEquipe.Gols)
                return primeiraEquipe;

            return segundaEquipe;
        }
    }
}
