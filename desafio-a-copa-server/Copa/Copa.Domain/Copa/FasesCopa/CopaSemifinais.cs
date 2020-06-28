using Copa.Domain.Copa;
using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.FasesCopa
{
    [FaseCopa(EnumFaseCopa.Semifinais)]
    public class CopaSemifinais : IFaseCopa
    {
        private readonly IRegraDefinicaoPartida _regraDefinicaoPartida;

        public CopaSemifinais(IRegraDefinicaoPartida regraDefinicaoPartida) => _regraDefinicaoPartida = regraDefinicaoPartida;        

        public IList<Equipe> ExecuteFase(List<Equipe> equipes)
        {
            var participantesProximaFase = new List<Equipe>(equipes.Count / 2);
            var partidas = _regraDefinicaoPartida.DefinaPartidasDaFase(equipes);
            partidas.ForEach(partida => participantesProximaFase.Add(partida.ObtenhaVencedor()));
            return participantesProximaFase;
        }        
    }
}
