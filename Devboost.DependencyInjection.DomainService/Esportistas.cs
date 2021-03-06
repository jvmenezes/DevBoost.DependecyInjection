﻿using DevBoost.DependecyInjection.Domain.Interfaces.Services;
using DevBoost.DependecyInjection.Domain.Models.DI_Construtor;
using DevBoost.DependecyInjection.Domain.Models.DI_GetterSetter;
using DevBoost.DependecyInjection.Domain.Models.DI_Interface;
using System.Collections.Generic;

namespace DevBoost.DependecyInjection.DomainServices
{
    public class Esportistas : IEsportistas
    {

        #region Injeção de dependência via contrutor dentro da classe "Esportista_C"
        public List<Esportista_C> ObterTodos_C()
        {

            return new List<Esportista_C>() {
                new Esportista_C(new Atividades() { Nome = "Jogador de Futebol" }){ Nome = "Fulano",  Idade = 31, Pais = "Brasil" },
                new Esportista_C(new Atividades() { Nome = "Nadador" }){ Nome = "Ciclano", Idade = 25, Pais = "Brasil" },
                new Esportista_C(new Atividades() { Nome = "Ciclista" }){ Nome = "Beltrano", Idade = 20, Pais = "Brasil" }
            };
        }
        #endregion

        #region Injeção de dependência via Getters e Setters dentro da classe "Esportista_GS"
        public List<Esportista_GS> ObterTodos_GS()
        {

            return new List<Esportista_GS>() {
                new Esportista_GS(){ Nome = "Fulano",  Idade = 31, Pais = "Brasil", Atividades = new Atividades() { Nome = "Jogador de Futebol" } },
                new Esportista_GS(){ Nome = "Ciclano", Idade = 25, Pais = "Brasil", Atividades = new Atividades() { Nome = "Nadador" } },
                new Esportista_GS(){ Nome = "Beltrano", Idade = 20, Pais = "Brasil", Atividades = new Atividades() { Nome = "Ciclista" } }
            };
        }
        #endregion

        #region Injeção de dependência via interface dentro da classe "Esportista_I"
        public List<Esportista_I> ObterTodos_I()
        {
            List<Esportista_I> listReturn = new List<Esportista_I>();

            Esportista_I eF = new Esportista_I() { Nome = "Fulano", Idade = 31, Pais = "Brasil" };
            eF.setAtividade(new Atividades() { Nome = "Jogador de Futebol" });
            listReturn.Add(eF);

            Esportista_I eC = new Esportista_I() { Nome = "Ciclano", Idade = 25, Pais = "Brasil" };
            eC.setAtividade(new Atividades() { Nome = "Nadador" });
            listReturn.Add(eC);

            Esportista_I eB = new Esportista_I() { Nome = "Beltrano", Idade = 20, Pais = "Brasil" };
            eB.setAtividade(new Atividades() { Nome = "Ciclista" });
            listReturn.Add(eB);

            return listReturn;
        }
        #endregion
    }
}
