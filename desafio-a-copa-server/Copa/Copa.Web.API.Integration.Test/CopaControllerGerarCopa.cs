using Copa.Application.ViewModels;
using Copa.Domain.Test.CenarioBuilderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Copa.Web.API.Integration.Test
{
    public class CopaControllerGerarCopa : BaseIntegrationTest
    {
        [Fact]
        public async Task GerarCopa()
        {
            var equipes = EquipeBuilder.CrieEquipesViewModelAletorias(8);            
            var response = await Client.PostAsync("/api/copa/processar-copa", equipes.ToJson());
            response.EnsureSuccessStatusCode();
            var resultadoCopa = await JsonToObject<Guid>.Convert(response);

            response = await Client.GetAsync($"/api/copa/resultado-copa/{resultadoCopa}");
            response.EnsureSuccessStatusCode();
            var resultado = await JsonToObject<IEnumerable<EquipeViewModel>>.Convert(response);

            Assert.Equal(equipes[0].Id, resultado.ToList().First().Id); ;

        }
    }
}
