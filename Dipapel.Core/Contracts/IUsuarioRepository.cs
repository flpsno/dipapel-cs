﻿using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Contracts
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario ObterByEmail(string codigo);
    }
}
