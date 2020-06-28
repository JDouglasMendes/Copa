using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.DefinicaoPartidas
{
    public class RegraDefinicaoPartidasPrimeiraFaseTest
    {
        [Fact]
        public void DefinaPartidasDaFase()
        {
            var equipes = EquipeBuilder.CrieEquipesAleatorias(8);
            Assert.Equal(8, equipes.Count);
            var regra = new RegraDefinicaoPartidasPrimeiraFase();
            var equipesProcessadas = regra.DefinaPartidasDaFase(equipes);
            var partida1 = new Partida(equipes[0], equipes[7]);
            var partida2 = new Partida(equipes[1], equipes[6]);
            var partida3 = new Partida(equipes[2], equipes[5]);
            var partida4 = new Partida(equipes[3], equipes[4]);

            Assert.Equal(partida1.PrimeiraEquipe, equipesProcessadas[0].PrimeiraEquipe);
            Assert.Equal(partida1.SegundaEquipe, equipesProcessadas[0].SegundaEquipe);

            Assert.Equal(partida2.PrimeiraEquipe, equipesProcessadas[1].PrimeiraEquipe);
            Assert.Equal(partida2.SegundaEquipe, equipesProcessadas[1].SegundaEquipe);

            Assert.Equal(partida3.PrimeiraEquipe, equipesProcessadas[2].PrimeiraEquipe);
            Assert.Equal(partida3.SegundaEquipe, equipesProcessadas[2].SegundaEquipe);

            Assert.Equal(partida4.PrimeiraEquipe, equipesProcessadas[3].PrimeiraEquipe);
            Assert.Equal(partida4.SegundaEquipe, equipesProcessadas[3].SegundaEquipe);

        }
    }
}
