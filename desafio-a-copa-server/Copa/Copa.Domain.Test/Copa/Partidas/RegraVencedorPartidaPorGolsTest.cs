using Copa.Domain.Copa.Partidas;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.Partidas
{
    public class RegraVencedorPartidaPorGolsTest
    {        
        [Fact]
        public void ExecuteRegra()
        {
            var regra = new RegraVencedorPartidaPorGols();
            var equipes = EquipeBuilder.CrieEquipesAleatorias(2);            
            var result = regra.ExecuteRegra(equipes.First(), equipes.Last());
            Assert.Equal(equipes.First(), result);
        }
    }
}
