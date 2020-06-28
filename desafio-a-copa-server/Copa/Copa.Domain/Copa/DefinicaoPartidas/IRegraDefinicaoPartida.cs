using Copa.Domain.Copa.Partidas;
using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.DefinicaoPartidas
{
    public interface IRegraDefinicaoPartida
    {
        List<Partida> DefinaPartidasDaFase(List<Equipe> equipes);
    }
}
