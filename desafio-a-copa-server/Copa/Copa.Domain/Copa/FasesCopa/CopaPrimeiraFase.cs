using Copa.Domain.Copa;
using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Copa.Domain.Copa.FasesCopa
{
    [FaseCopa(EnumFaseCopa.PrimeiraFase)]
    public class CopaPrimeiraFase : IFaseCopa
    {
        private readonly IRegraDefinicaoPartida _regraDefinicaoPartida;
       
        public CopaPrimeiraFase(IRegraDefinicaoPartida regraDefinicaoPartida) => _regraDefinicaoPartida = regraDefinicaoPartida;
        
        public IList<Equipe> ExecuteFase(List<Equipe> equipes)
        {
            equipes.Sort((x, y) => x.NomeEquipe.CompareTo(y.NomeEquipe));
            var partidas = _regraDefinicaoPartida.DefinaPartidasDaFase(equipes);
            var participantesProximaFase = new List<Equipe>(equipes.Count / 2);
            partidas.ForEach(partida => participantesProximaFase.Add(partida.ObtenhaVencedor()));
            return participantesProximaFase;
        }        
    }
}
