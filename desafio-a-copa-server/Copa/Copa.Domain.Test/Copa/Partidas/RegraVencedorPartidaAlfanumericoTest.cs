using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.Partidas
{
    public class RegraVencedorPartidaAlfanumericoTest
    {
        [Theory]
        [InlineData("teste","ateste", "ateste")]
        [InlineData("teste1", "bteste", "bteste")]
        [InlineData("bteste", "teste1", "bteste")]
        public void ExecuteRegra(string equipe1, string equipe2, string resultado)
        {
            var regra = new RegraVencedorPartidaAlfanumerico();
            var eq1 = EquipeBuilder.CrieEquipeRegraNomeAlfanumerico(equipe1);
            var eq2 = EquipeBuilder.CrieEquipeRegraNomeAlfanumerico(equipe2);
            var result = regra.ExecuteRegra(eq1, eq2);
            Assert.Equal(resultado, result.NomeEquipe.NomeCompleto);
        }
    }
}
