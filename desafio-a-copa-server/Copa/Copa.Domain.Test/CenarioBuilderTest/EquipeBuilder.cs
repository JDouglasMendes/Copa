using Copa.Application.ViewModels;
using Copa.Domain.Entities;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Copa.Domain.Test.CenarioBuilderTest
{
    public class EquipeBuilder
    {
        private Equipe _equipe;
      
        public EquipeBuilder InicieCenarioConsiderandoGols(short gols)
        {
            _equipe = new Equipe(Guid.NewGuid(), "equipe teste", "eqp", gols);
            return this;
        }

        public Equipe GetEquipe => _equipe;

        public static  List<Equipe> CrieEquipes(params Equipe[] equipes) =>  equipes.ToList();
        
        public static List<Equipe> CrieEquipesAleatorias(short quantidade)
        {
            var retorno = new List<Equipe>(quantidade);
            while(quantidade > 0)
            {
                retorno.Add(new Equipe(Guid.NewGuid(), "EQUIPE " + quantidade, "AQP", quantidade));
                quantidade--;
            }
            return retorno;
        }

        public static List<EquipeViewModel> CrieEquipesViewModelAletorias(short quantidade)
        {
            var retorno = new List<EquipeViewModel>(quantidade);
            while (quantidade > 0)
            {
                retorno.Add(new EquipeViewModel
                {
                    Id = Guid.NewGuid(),
                    Gols = quantidade,
                    Nome = "EQUIPE " + quantidade,
                    Sigla = "EQP"
                });
                quantidade--;
            }

            return retorno; 
        }

        public static Equipe CrieEquipeRegraNomeAlfanumerico(string nome) =>
            new Equipe(Guid.NewGuid(), nome, "eqp", 1);

    }
}
