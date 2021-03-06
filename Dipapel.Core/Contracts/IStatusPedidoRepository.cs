﻿using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Contracts
{
    public interface IStatusPedidoRepository: IRepository<StatusPedido>
    {
        StatusPedido ObterByCodigo(string codigo);
    }
}
