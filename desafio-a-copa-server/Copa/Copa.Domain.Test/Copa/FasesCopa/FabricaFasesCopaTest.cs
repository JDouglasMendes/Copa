using Copa.Domain.Copa.FasesCopa;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.FasesCopa
{
    public class FabricaFasesCopaTest
    {
        [Theory]
        [InlineData(EnumFaseCopa.PrimeiraFase, typeof(CopaPrimeiraFase))]
        [InlineData(EnumFaseCopa.Semifinais, typeof(CopaSemifinais))]
        [InlineData(EnumFaseCopa.Final, typeof(CopaFinal))]
        public void CrieInstancia(EnumFaseCopa enumfase, Type tipo) =>
            Assert.IsType(tipo, FabricaFasesCopa.Singleton.CrieInstancia(enumfase));
        
    }
}
