using Copa.Domain.Copa.FasesCopa;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Copa.Domain.Copa.DefinicaoPartidas
{
    [RegraFaseCopa(EnumFaseCopa.Final)]
    public class RegraDefinicaoPartidaFinal : IRegraDefinicaoPartida
    {
        public List<Partida> DefinaPartidasDaFase(List<Equipe> equipes) => new List<Partida>{new Partida(equipes.First(), equipes.Last())};
        
    }
}
