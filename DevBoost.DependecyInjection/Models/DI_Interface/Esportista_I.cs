using DevBoost.DependecyInjection.Interfaces;
using System;

namespace DevBoost.DependecyInjection.Models.DI_Interface
{
    public class Esportista_I : IAtividadesDI_I
    {

        private IAtividades _atividades;

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Pais { get; set; }
        public string Atividade
        {
            get { return _atividades.GetNome(); }
        }

        public void setAtividade(IAtividades atividades)
        {
            _atividades = atividades;
        }
    }
}
