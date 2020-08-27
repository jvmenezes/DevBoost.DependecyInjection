using DevBoost.DependecyInjection.Models;
using DevBoost.DependecyInjection.Models.DI_Construtor;
using DevBoost.DependecyInjection.Models.DI_GetterSetter;
using DevBoost.DependecyInjection.Models.DI_Interface;
using DevBoost.DependecyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.DependecyInjection.Interfaces
{
    public interface IEsportistas
    {
        List<Esportista_C> ObterTodos_C();
        List<Esportista_GS> ObterTodos_GS();
        List<Esportista_I> ObterTodos_I();
    }
}
