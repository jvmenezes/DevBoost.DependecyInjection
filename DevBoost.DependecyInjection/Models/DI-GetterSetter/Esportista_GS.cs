using DevBoost.DependecyInjection.Interfaces;
using System;

namespace DevBoost.DependecyInjection.Models.DI_GetterSetter
{
    public class Esportista_GS
    {

        private IAtividades _atividades;

        public IAtividades Atividades
        {
            get { return _atividades; }
            set { _atividades = value; }
        }        

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Pais { get; set; }
        public string Atividade { get; set; }

        public IAtividades GetAtividade()
        {
            return _atividades;
        }
    }
}
