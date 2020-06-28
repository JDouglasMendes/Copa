using Copa.Domain.Copa.Partidas;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Copa.Partidas
{
    public class PartidaInconclusivaExceptionTest
    {
        [Theory]
        [InlineData("teste mensagem")]
        public void TesteMensagemException(string mensagem)
        {
            var exception = new PartidaInconclusivaException(mensagem);
            Assert.Equal(mensagem, exception.Message);
        }
    }
}
