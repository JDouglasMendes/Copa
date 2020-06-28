using Copa.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Copa.Web.API.Integration.Test
{
    public class EquipeControllerTest : BaseIntegrationTest
    {
        [Fact]
        public async void GetCenarioBase()
        {
            var response = await Client.GetAsync("/api/equipe");
            response.EnsureSuccessStatusCode();
            var resultadoCopa = await JsonToObject<IEnumerable<EquipeViewModel>>.Convert(response);
            Assert.True(resultadoCopa.Count() > 0);
        }
        
    }
}
