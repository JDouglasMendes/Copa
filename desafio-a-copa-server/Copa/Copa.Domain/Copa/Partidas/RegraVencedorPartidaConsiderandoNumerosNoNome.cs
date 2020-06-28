using Copa.Domain.Entities;
using Copa.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.Partidas
{
    public class RegraVencedorPartidaConsiderandoNumerosNoNome : IRegraVencedorPartida
    {
        public short PrioridadeRegra => 2;

        public Equipe ExecuteRegra(Equipe primeiraEquipe, Equipe segundaEquipe)
        {
            if(primeiraEquipe.Nome.ExisteNumeroNaString() && segundaEquipe.Nome.ExisteNumeroNaString())
            {
                var numeroPrimeiraEquipe = primeiraEquipe.Nome.GetNumero();
                var numeroSegundaEquipe = segundaEquipe.Nome.GetNumero();

                if (numeroPrimeiraEquipe < numeroSegundaEquipe)
                    return primeiraEquipe;

                return segundaEquipe;
            }
            return null;
        }        
    }
}
