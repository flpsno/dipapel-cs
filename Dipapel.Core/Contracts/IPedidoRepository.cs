﻿using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Contracts
{
    public interface IPedidoRepository: IRepository<Pedido>
    {
        Pedido ObterByCodigo(string codigo);
    }
}
