using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Copa.Domain.Utils
{
    public static class StringUtil
    {
        public static string RetiraEspacoDuplicado(this string valor)
        {
            while(valor.Contains("  "))
                valor = valor.Replace("  ", " ");            
            return valor;
        }

        public static bool ExisteNumeroNaString(this string valor)
        {
            valor = valor.RetiraEspacoDuplicado();
            var conteudo = valor.Split(" ");
            return conteudo.ToList().Any(x => Information.IsNumeric(x));
        }

        public static decimal GetNumero(this string valor)
        {
            valor = valor.RetiraEspacoDuplicado();
            var conteudo = valor.Split(" ");
            var numero = conteudo.ToList().SingleOrDefault(x => Information.IsNumeric(x));
            if (string.IsNullOrEmpty(numero))
                return -1;
            return decimal.Parse(numero);
        }

        public static string GetPrimeiraDescricao(this string valor)
        {
            valor = valor.RetiraEspacoDuplicado();
            return valor.Split(" ")[0];
        }

    }
}
