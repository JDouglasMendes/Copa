using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.DefinicaoPartidas
{
    public class DefineCampeaoEOrdenaFinalistaTest
    {
        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(2, 1, -1)]      
        public void CompareEquipesPorGols(short gols1, short gols2, int resultado)
        {
            var equipe1 = new EquipeBuilder().InicieCenarioConsiderandoGols(gols1).GetEquipe;
            var equipe2 = new EquipeBuilder().InicieCenarioConsiderandoGols(gols2).GetEquipe;
            var partida = new Partida(equipe1, equipe2);
            var define = new DefineCampeaoEOrdenaFinalista(partida);
            Assert.Equal(resultado, define.Compare(equipe1, equipe2));
        }
    }
}
