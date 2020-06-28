using Copa.Domain.Copa.FasesCopa;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.DefinicaoPartidas
{
    [RegraFaseCopa(EnumFaseCopa.PrimeiraFase)]
    public class RegraDefinicaoPartidasPrimeiraFase : IRegraDefinicaoPartida
    {
        public List<Partida> DefinaPartidasDaFase(List<Equipe> equipes)
        {
            var mandante = 0;
            var visitante = equipes.Count - 1;
            var partidas = new List<Partida>();
            while (mandante < visitante)
            {
                partidas.Add(new Partida(equipes[mandante], equipes[visitante]));
                mandante++;
                visitante--;
            }
            return partidas;
        }
    }
}
