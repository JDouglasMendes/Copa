using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Copa.Domain.Entities
{
    public class NomeEquipe : IComparable<NomeEquipe>
    {
        public string NomeCompleto { get; }
        public string Sigla { get;  }
        public NomeEquipe(string nome, string sigla)
        {
            NomeCompleto = nome;
            Sigla = sigla;
        }

        public static NomeEquipe Crie(string nome, string sigla) => new NomeEquipe(nome, sigla);

        public int CompareTo(NomeEquipe other) => NomeCompleto.CompareTo(other.NomeCompleto);

        public static bool operator >(NomeEquipe nomeEquipe1, NomeEquipe nomeEquipe2) =>
                nomeEquipe1.NomeCompleto.CompareTo(nomeEquipe2.NomeCompleto) > 0;
        
        public static bool operator <(NomeEquipe nomeEquipe1, NomeEquipe nomeEquipe2) =>        
                nomeEquipe1.NomeCompleto.CompareTo(nomeEquipe2.NomeCompleto) <= 0;
        
    }
}
