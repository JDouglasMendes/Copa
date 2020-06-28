using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.Partidas
{
    public class RegraVencedorPartidaConsiderandoNumerosNoNomeTest
    {
        [Theory]
        [InlineData("Equipe 19", "Equipe 100", "Equipe 19")]
        [InlineData("E 1", "A 2", "E 1")]
        [InlineData("E", "A", null)]
        public void ExecuteRegra(string equipe1, string equipe2, string resultado)
        {
            var regra = new RegraVencedorPartidaConsiderandoNumerosNoNome();
            var eq1 = EquipeBuilder.CrieEquipeRegraNomeAlfanumerico(equipe1);
            var eq2 = EquipeBuilder.CrieEquipeRegraNomeAlfanumerico(equipe2);
            var result = regra.ExecuteRegra(eq1, eq2);
            if (resultado != null)
                Assert.Equal(resultado, result.NomeEquipe.NomeCompleto);
            if (resultado == null && result == null)
                Assert.True(true);           
        }
    }
}
