using Copa.Domain.Copa.FasesCopa;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.DefinicaoPartidas
{
    [RegraFaseCopa(EnumFaseCopa.Semifinais)]
    public class RegraDefinicaoPartidasSemifinais : IRegraDefinicaoPartida
    {
        public List<Partida> DefinaPartidasDaFase(List<Equipe> equipes)
        {
            var posicaoEquipes = 0;            
            var partidas = new List<Partida>();
            while(posicaoEquipes + 2 <= equipes.Count)
            {
                partidas.Add(new Partida(equipes[posicaoEquipes], equipes[posicaoEquipes + 1])); 
                posicaoEquipes +=2;
            }                        
            return partidas;
        }
    }
}
