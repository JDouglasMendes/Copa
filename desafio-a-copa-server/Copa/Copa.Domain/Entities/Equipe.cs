using System;
using System.Diagnostics.CodeAnalysis;

namespace Copa.Domain.Entities
{
    public class Equipe : IComparable<Equipe>
    {
        public Equipe(Guid id, string nome, string sigla, short gols)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
            Gols = gols;
        }

        public Guid Id { get; }
        public string Nome { get; }
        public string Sigla { get; }
        public short Gols { get; }

        public int CompareTo([AllowNull] Equipe equipe) =>
            this.Nome.CompareTo(equipe.Nome);        

        public override bool Equals(object obj) => obj is Equipe equipe && Id.Equals(equipe.Id);

        public override int GetHashCode() => HashCode.Combine(Id);        
    }
}
