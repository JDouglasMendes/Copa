using Copa.Domain.Copa.FasesCopa;
using System;

namespace Copa.Domain.Copa.Partidas
{
    internal class RegraFaseCopaAttribute : Attribute
    {
        private EnumFaseCopa _faseCopa;
        public RegraFaseCopaAttribute(EnumFaseCopa final) => _faseCopa = final;       
    }
}