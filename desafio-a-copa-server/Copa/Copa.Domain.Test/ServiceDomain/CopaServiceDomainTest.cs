using Copa.Domain.ServiceDomain;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.ServiceDomain
{
    public class CopaServiceDomainTest
    {
        [Fact]
        public void ProcesseCopa()
        {
            var equipes = EquipeBuilder.CrieEquipesAleatorias(8);
            var copaService = new CopaServiceDomain();
            var result = copaService.ProcesseCopa(equipes);
            Assert.Equal(equipes[7], result.First());
            Assert.Equal(equipes[3], result.Last());
        }
    }
}
