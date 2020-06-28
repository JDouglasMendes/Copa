using Copa.Domain.Copa;
using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Copa.Domain.Copa.FasesCopa
{
    [FaseCopa(EnumFaseCopa.Final)]
    public class CopaFinal : IFaseCopa
    {
        private readonly IRegraDefinicaoPartida _regraDefinicaoPartida;

        public CopaFinal(IRegraDefinicaoPartida regraDefinicaoPartida) => _regraDefinicaoPartida = regraDefinicaoPartida;        

        public IList<Equipe> ExecuteFase(List<Equipe> equipes)
        {
            var partida = _regraDefinicaoPartida.DefinaPartidasDaFase(equipes);
            equipes.Sort(new DefineCampeaoEOrdenaFinalista(partida.FirstOrDefault()));
            return equipes;
        }        
    }
}
