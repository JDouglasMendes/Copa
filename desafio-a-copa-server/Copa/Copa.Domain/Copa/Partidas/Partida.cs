using Copa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Copa.Domain.Copa.Partidas
{
    public class Partida
    {
        public Equipe PrimeiraEquipe { get; }
        public Equipe SegundaEquipe { get; }

        public Partida(Equipe primeiraEquipe, Equipe segundaEquipe)
        {
            PrimeiraEquipe = primeiraEquipe;
            SegundaEquipe = segundaEquipe;
        }

        public Equipe ObtenhaVencedor()
        {
            var regras = GetRegras();
            regras.Sort((x,y) => x.PrioridadeRegra.CompareTo(y.PrioridadeRegra));
            foreach (var regra in regras)
            {
                var resultado = regra.ExecuteRegra(PrimeiraEquipe, SegundaEquipe);
                if (resultado != null)
                    return resultado;
            }
            throw new PartidaInconclusivaException("Não foi possível identificar o ganhador da partida");
        }
  
        private List<IRegraVencedorPartida> GetRegras()
        {
           var tiposSelecionados =  Assembly.GetAssembly(typeof(Partida))
                .GetTypes().ToList().Where(tipo => tipo.IsClass && tipo.GetInterface(typeof(IRegraVencedorPartida).FullName) != null).ToList();

            var regras = new List<IRegraVencedorPartida>();
            tiposSelecionados.ForEach(tipo => regras.Add(Activator.CreateInstance(tipo) as IRegraVencedorPartida));

            return regras;

        }
    }
}
