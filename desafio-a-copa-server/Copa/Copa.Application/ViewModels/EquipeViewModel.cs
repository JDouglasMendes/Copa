using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Application.ViewModels
{
    public class EquipeViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public short Gols { get; set; }
    }
}
