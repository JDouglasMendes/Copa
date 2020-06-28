using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.DefinicaoPartidas
{
    public class RegraDefinicaoPartidaFinalTest
    {
        [Fact]
        public void DefinaPartidasDaFase()
        {
            var equipe1 = new EquipeBuilder().InicieCenarioConsiderandoGols(1).GetEquipe;
            var equipe2 = new EquipeBuilder().InicieCenarioConsiderandoGols(2).GetEquipe;
            var regra = new RegraDefinicaoPartidaFinal();
            var resultado = regra.DefinaPartidasDaFase(EquipeBuilder.CrieEquipes(equipe1, equipe2));
            Assert.Single(resultado);
        }
    }
}
