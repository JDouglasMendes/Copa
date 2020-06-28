using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.Partidas
{
    public class RegraVencedorPartidaNomeInicialIgualTest
    {
        [Theory]
        [InlineData("Equipe", "Equipe 1", "Equipe")]
        [InlineData("E 1", "E", "E")]
        public void ExecuteRegra(string equipe1, string equipe2, string resultado)
        {
            var regra = new RegraVencedorPartidaNomeInicialIgual();
            var eq1 = EquipeBuilder.CrieEquipeRegraNomeAlfanumerico(equipe1);
            var eq2 = EquipeBuilder.CrieEquipeRegraNomeAlfanumerico(equipe2);
            var result = regra.ExecuteRegra(eq1, eq2);
            Assert.Equal(resultado, result.NomeEquipe.NomeCompleto);
        }
    }
}
