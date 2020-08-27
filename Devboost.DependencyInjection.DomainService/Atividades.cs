using DevBoost.DependecyInjection.Domain.Interfaces.Services;

namespace DevBoost.DependecyInjection.DomainServices
{
    public class Atividades : IAtividades
    {
        public string Nome { get; set; }

        public string GetNome()
        {
            return Nome;
        }

    }
}
