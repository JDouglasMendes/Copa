using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.DefinicaoPartidas
{
    public class RegraDefinicaoPartidasSemifinaisTest
    {
        [Fact]
        public void DefinaPartidasDaFase()
        {
            var equipes = EquipeBuilder.CrieEquipesAleatorias(4);
            Assert.Equal(4, equipes.Count);
            var regra = new RegraDefinicaoPartidasSemifinais();
            var equipesProcessadas = regra.DefinaPartidasDaFase(equipes);
            var partida1 = new Partida(equipes[0], equipes[1]);
            var partida2 = new Partida(equipes[2], equipes[3]);

            Assert.Equal(partida1.PrimeiraEquipe, equipesProcessadas[0].PrimeiraEquipe);
            Assert.Equal(partida1.SegundaEquipe, equipesProcessadas[0].SegundaEquipe);

            Assert.Equal(partida2.PrimeiraEquipe, equipesProcessadas[1].PrimeiraEquipe);
            Assert.Equal(partida2.SegundaEquipe, equipesProcessadas[1].SegundaEquipe);
        }
    }
}
