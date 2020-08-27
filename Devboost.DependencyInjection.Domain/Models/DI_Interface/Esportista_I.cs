using DevBoost.DependecyInjection.Domain.Interfaces;
using DevBoost.DependecyInjection.Domain.Interfaces.Services;

namespace DevBoost.DependecyInjection.Domain.Models.DI_Interface
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
