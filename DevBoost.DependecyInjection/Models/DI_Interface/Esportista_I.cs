using DevBoost.DependecyInjection.Interfaces;
using System;

namespace DevBoost.DependecyInjection.Models.DI_Interface
{
    public class Esportista_I : IAtividadesDI_I
    {        

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Pais { get; set; }
        public string Atividade { get; set; }

        public void setAtividade(IAtividades atividades)
        {
            Atividade = atividades.GetNome();
        }
    }
}
