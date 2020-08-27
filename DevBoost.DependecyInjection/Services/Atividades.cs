using DevBoost.DependecyInjection.Interfaces;
using DevBoost.DependecyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.DependecyInjection.Services
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
