using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Domain.Copa.Partidas
{
    public class PartidaInconclusivaException : Exception
    {
        public PartidaInconclusivaException(string mensagem): base(mensagem) { }
    }
}
