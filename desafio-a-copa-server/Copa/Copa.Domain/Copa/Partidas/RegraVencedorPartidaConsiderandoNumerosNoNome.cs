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
            if(primeiraEquipe.ExisteNumeroNoNome() && segundaEquipe.ExisteNumeroNoNome())
            {
                var numeroPrimeiraEquipe = primeiraEquipe.GetNumeroNomeEquipe();
                var numeroSegundaEquipe = segundaEquipe.GetNumeroNomeEquipe();

                if (numeroPrimeiraEquipe < numeroSegundaEquipe)
                    return primeiraEquipe;

                return segundaEquipe;
            }
            return null;
        }        
    }
}
