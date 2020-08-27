using DevBoost.DependecyInjection.Domain.Models.DI_Construtor;
using DevBoost.DependecyInjection.Domain.Models.DI_GetterSetter;
using DevBoost.DependecyInjection.Domain.Models.DI_Interface;
using System.Collections.Generic;

namespace DevBoost.DependecyInjection.Domain.Interfaces.Services
{
    public interface IEsportistas
    {
        List<Esportista_C> ObterTodos_C();
        List<Esportista_GS> ObterTodos_GS();
        List<Esportista_I> ObterTodos_I();
    }
}
