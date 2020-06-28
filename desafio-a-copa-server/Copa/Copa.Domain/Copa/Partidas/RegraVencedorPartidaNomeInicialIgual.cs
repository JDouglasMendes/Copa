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
            if(primeiraEquipe.GetPrimeiroNome().Equals(segundaEquipe.GetPrimeiroNome(), StringComparison.OrdinalIgnoreCase))
            {
                if (primeiraEquipe.TamanhoNome < segundaEquipe.TamanhoNome)
                    return primeiraEquipe;

                return segundaEquipe;
            }
            return null;
        }
    }
}
