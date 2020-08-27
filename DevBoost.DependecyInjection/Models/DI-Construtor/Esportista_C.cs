using DevBoost.DependecyInjection.Interfaces;
using System;

namespace DevBoost.DependecyInjection.Models.DI_Construtor
{
    public class Esportista_C
    {

        public Esportista_C(IAtividades atividades)
        {
            Atividade = atividades.GetNome();
        }        

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Pais { get; set; }
        public string Atividade { get; set; }
    }
}
