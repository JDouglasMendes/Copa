using Copa.Domain.Copa;
using Copa.Domain.Copa.FasesCopa;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Copa.Domain.ServiceDomain
{
    public class CopaBuilder
    {
        private readonly List<Equipe> _todasEquipesDaCopa;

        public CopaBuilder(List<Equipe> equipes) => _todasEquipesDaCopa = equipes;
        
        public CopaBuilder ExecutePrimeiraFase()
        {
            var primeiraFase = FabricaFasesCopa.Singleton.CrieInstancia(EnumFaseCopa.PrimeiraFase);
            Finalistas = primeiraFase.ExecuteFase(_todasEquipesDaCopa);
            return this;
        }

        public CopaBuilder ExecuteSemifinais()
        {
            var semifinal = FabricaFasesCopa.Singleton.CrieInstancia(EnumFaseCopa.Semifinais);
            Finalistas = semifinal.ExecuteFase(Finalistas.ToList());
            return this;
        }

        public CopaBuilder ExecuteFinal()
        {
            var final = FabricaFasesCopa.Singleton.CrieInstancia(EnumFaseCopa.Final);
            Finalistas = final.ExecuteFase(Finalistas.ToList());
            return this;
        }

        public IList<Equipe> Finalistas { get; private set; }
    }
}
