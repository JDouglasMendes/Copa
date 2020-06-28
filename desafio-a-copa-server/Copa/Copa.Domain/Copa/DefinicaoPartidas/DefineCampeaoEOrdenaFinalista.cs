using Copa.Domain.Copa.Partidas;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Copa.Domain.Copa.DefinicaoPartidas
{
    public class DefineCampeaoEOrdenaFinalista : IComparer<Equipe>
    {
        private readonly Partida _partida;

        public DefineCampeaoEOrdenaFinalista(Partida partida) => _partida = partida;
                
        public int Compare([AllowNull] Equipe x, [AllowNull] Equipe y) => _partida.ObtenhaVencedor().Equals(x) ? -1 : 1;                        
    }
}
