using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Copa.FasesCopa;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Entities;
using Copa.Domain.Test.CenarioBuilderTest;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.FasesCopa
{
    public class CopaFinalTest
    {
        [Fact]
        public void ExecuteFase()
        {
            var regra = Substitute.For<IRegraDefinicaoPartida>();            
            var copaFinal = new CopaFinal(regra);
            var equipes = EquipeBuilder.CrieEquipesAleatorias(2);
            regra.DefinaPartidasDaFase(equipes).Returns(new List<Partida> { new Partida(equipes.First(), equipes.Last()) });
            var resultado = copaFinal.ExecuteFase(equipes);
            Assert.Equal(equipes[0], resultado.First());
            Assert.Equal(equipes[1], resultado.Last());
        }
    }
}
