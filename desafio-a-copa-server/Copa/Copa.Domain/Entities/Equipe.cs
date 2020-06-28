using Copa.Domain.Utils;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Copa.Domain.Entities
{
    public class Equipe : IComparable<Equipe>
    {
        public Equipe(Guid id, string nome, string sigla, short gols)
        {
            Id = id;
            NomeEquipe = NomeEquipe.Crie(nome, sigla);          
            Gols = gols;
        }

        public Guid Id { get; }
        public NomeEquipe NomeEquipe { get; }        
        public short Gols { get; }

        public int CompareTo([AllowNull] Equipe equipe) =>
            this.NomeEquipe.CompareTo(equipe.NomeEquipe);        

        public override bool Equals(object obj) => obj is Equipe equipe && Id.Equals(equipe.Id);

        public override int GetHashCode() => HashCode.Combine(Id);        

        public bool ExisteNumeroNoNome() => NomeEquipe.NomeCompleto.ExisteNumeroNaString();

        public decimal GetNumeroNomeEquipe() => NomeEquipe.NomeCompleto.GetNumero();

        public string GetPrimeiroNome() => NomeEquipe.NomeCompleto.GetPrimeiraDescricao();

        public int TamanhoNome => NomeEquipe.NomeCompleto.Length;
    }
}
