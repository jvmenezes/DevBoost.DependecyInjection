using DevBoost.DependecyInjection.Interfaces;
using System;

namespace DevBoost.DependecyInjection.Models.DI_Interface
{
    public class Esportista_I : IAtividadesDI
    {

        private IAtividades _atividades;

        public string Nome { get; set; }
        public int Idade { get; set; }
        public String Pais { get; set; }

        public void setAtividade(IAtividades atividades)
        {
            _atividades = atividades;
        }
    }
}
