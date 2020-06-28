using Copa.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Copa.Domain.Test.Utils
{
    public class StringUtilTest
    {
        [Theory]
        [InlineData("teste  ", "teste ")]
        [InlineData("teste  teste", "teste teste")]
        public void RetiraEspacoDuplicadoTest(string valor, string result) =>
             Assert.Equal(result, StringUtil.RetiraEspacoDuplicado(valor));
        
        [Theory]
        [InlineData("teste  ", false)]
        [InlineData("teste1  ", false)]
        [InlineData("teste 1  ", true)]
        [InlineData("teste 100  ", true)]
        public void ExisteNumeroNaString(string valor, bool result) =>
            Assert.Equal(result, StringUtil.ExisteNumeroNaString(valor));
        

        [Theory]
        [InlineData("teste  ", -1)]
        [InlineData("teste  1", 1)]
        [InlineData("teste1  ", -1)]
        [InlineData("teste 100 ", 100)]
        public void GetNumero(string valor, decimal result) =>
             Assert.Equal(result, StringUtil.GetNumero(valor));
        

        [Theory]
        [InlineData("teste", "teste")]
        [InlineData("teste  teste", "teste")]
        public void GetPrimeiraDescricao(string valor, string result) =>
            Assert.Equal(result, StringUtil.GetPrimeiraDescricao(valor));
        
    }
}
