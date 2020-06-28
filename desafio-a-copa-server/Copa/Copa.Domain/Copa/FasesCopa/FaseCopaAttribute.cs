using System;

namespace Copa.Domain.Copa.FasesCopa
{
    internal class FaseCopaAttribute : Attribute
    {
        public EnumFaseCopa Fase { get; }
        public FaseCopaAttribute(EnumFaseCopa primeiraFase) => Fase = primeiraFase;        
    }
}