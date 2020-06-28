using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Entities
{
    public class NomeEquipeTest
    {

        [Theory]
        [InlineData("AAA","AV",false)]
        [InlineData("AB", "AV", false)]
        [InlineData("AZ", "AV", true)]
        public void NomeEquipeMaior(string eq1, string eq2, bool resultado)
        {
            var nomeEquipe1 = NomeEquipe.Crie(eq1, "sigla");
            var nomeEquipe2 = NomeEquipe.Crie(eq2, "sigla");
            Assert.Equal(resultado, nomeEquipe1 > nomeEquipe2);
        }

        [Theory]
        [InlineData("AAA", "AV", true)]
        [InlineData("AB", "AV", true)]
        public void NomeEquipeMenor(string eq1, string eq2, bool resultado)
        {
            var nomeEquipe1 = NomeEquipe.Crie(eq1, "sigla");
            var nomeEquipe2 = NomeEquipe.Crie(eq2, "sigla");
            Assert.Equal(resultado, nomeEquipe1 < nomeEquipe2);
        }
    }
}
