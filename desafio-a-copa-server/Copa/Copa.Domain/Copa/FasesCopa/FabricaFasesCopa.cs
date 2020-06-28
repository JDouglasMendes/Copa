using Copa.Domain.Copa.DefinicaoPartidas;
using Copa.Domain.Copa.Partidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Copa.Domain.Copa.FasesCopa
{
    public class FabricaFasesCopa
    {
        private FabricaFasesCopa() 
        {
            _instanciasFases = new Dictionary<EnumFaseCopa, IFaseCopa>();
            Assembly.GetAssembly(typeof(FabricaFasesCopa)).GetTypes().ToList()
                .ForEach(tipo =>
                {
                    tipo.GetCustomAttributes(false).ToList()
                    .ForEach(atributo =>
                    {
                        var atributoFaseCalculo = atributo as FaseCopaAttribute;
                        if(atributoFaseCalculo != null)
                        {
                            var regraDeDefinicaoDePartidas = ObtenhaRegraPeloPartidasPelaFase(atributoFaseCalculo.Fase);
                            var faseCopa = Activator.CreateInstance(tipo, new[] { regraDeDefinicaoDePartidas }) as IFaseCopa;
                            _instanciasFases.Add(atributoFaseCalculo.Fase, faseCopa);
                        }
                    });                    
                });

        }
        private Dictionary<EnumFaseCopa, IFaseCopa> _instanciasFases;
        private static volatile FabricaFasesCopa instance;
        private static object syncRoot = new Object();
        public static FabricaFasesCopa Singleton
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new FabricaFasesCopa();
                    }
                }

                return instance;
            }
        }

        private IRegraDefinicaoPartida ObtenhaRegraPeloPartidasPelaFase(EnumFaseCopa enumFase)
        {
            IRegraDefinicaoPartida regra = null; ;
            Assembly.GetAssembly(typeof(FabricaFasesCopa)).GetTypes().ToList()
                .ForEach(tipo =>
                {
                    tipo.GetCustomAttributes(false).ToList()
                    .ForEach(atributo =>
                    {
                        var atributoFaseCalculo = atributo as RegraFaseCopaAttribute;
                        if (atributoFaseCalculo != null)
                        {
                            regra = Activator.CreateInstance(tipo) as IRegraDefinicaoPartida;
                        }
                    });
                });
            return regra;
        }

        public IFaseCopa CrieInstancia(EnumFaseCopa enumFaseCopa)
        {
            if (_instanciasFases.ContainsKey(enumFaseCopa))
                return _instanciasFases[enumFaseCopa];

            throw new ArgumentException(string.Format("Não foi encontrada uma fase para o indicador {0}", enumFaseCopa.ToString()));
        }
    }
}
