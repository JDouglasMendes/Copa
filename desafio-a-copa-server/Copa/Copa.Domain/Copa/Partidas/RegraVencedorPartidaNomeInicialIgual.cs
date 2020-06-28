using Copa.Domain.Entities;
using Copa.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.Partidas
{
    public class RegraVencedorPartidaNomeInicialIgual : IRegraVencedorPartida
    {
        public short PrioridadeRegra => 3;

        public Equipe ExecuteRegra(Equipe primeiraEquipe, Equipe segundaEquipe)
        {
            if(primeiraEquipe.Nome.GetPrimeiraDescricao().Equals(segundaEquipe.Nome.GetPrimeiraDescricao(), StringComparison.OrdinalIgnoreCase))
            {
                if (primeiraEquipe.Nome.Length < segundaEquipe.Nome.Length)
                    return primeiraEquipe;

                return segundaEquipe;
            }
            return null;
        }
    }
}
