﻿using DevBoost.DependecyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.DependecyInjection.Interfaces
{
    public interface IAtividadesDI
    {
        void setAtividade(IAtividades atividades);
    }
}