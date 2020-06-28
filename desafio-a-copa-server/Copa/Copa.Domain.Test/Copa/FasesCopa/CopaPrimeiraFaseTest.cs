using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Copa.FasesCopa;
using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.FasesCopa
{
    public class CopaPrimeiraFaseTest
    {
        [Fact]
        public void ExecuteFase()
        {
            var regra = Substitute.For<IRegraDefinicaoPartida>();
            var copaPrimeriaFase = new CopaPrimeiraFase(regra);
            var equipes = EquipeBuilder.CrieEquipesAleatorias(8);
            regra.DefinaPartidasDaFase(equipes).Returns(new List<Partida> { new Partida(equipes[0], equipes[7]),
                                                                            new Partida(equipes[1], equipes[6]),
                                                                            new Partida(equipes[2], equipes[5]),
                                                                            new Partida(equipes[3], equipes[4])});

            var resultado = copaPrimeriaFase.ExecuteFase(equipes);
            Assert.Equal(equipes[7], resultado[0]);
            Assert.Equal(equipes[6], resultado[1]);
            Assert.Equal(equipes[5], resultado[2]);
            Assert.Equal(equipes[4], resultado[3]);

        }
    }
}
