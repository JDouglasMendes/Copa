using Copa.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Web.API.Integration.Test
{
    public class EquipeBuilder
    {
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
    }
}
