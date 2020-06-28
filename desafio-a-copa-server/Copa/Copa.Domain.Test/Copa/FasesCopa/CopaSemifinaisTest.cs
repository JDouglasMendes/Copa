using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Copa.FasesCopa;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.FasesCopa
{
    public class CopaSemifinaisTest
    {
        [Fact]
        public void ExecuteFase()
        {
            var regra = Substitute.For<IRegraDefinicaoPartida>();
            var copaSefinal = new CopaSemifinais(regra);
            var equipes = EquipeBuilder.CrieEquipesAleatorias(4);
            regra.DefinaPartidasDaFase(equipes).Returns(new List<Partida> { new Partida(equipes[0], equipes[1]),
                                                                            new Partida(equipes[2], equipes[3])});
            var resultado = copaSefinal.ExecuteFase(equipes);
            Assert.Equal(equipes[0], resultado[0]);
            Assert.Equal(equipes[2], resultado[1]);
        }
    }
}
