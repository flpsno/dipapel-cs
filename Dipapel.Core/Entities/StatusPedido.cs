﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Entities
{
    public class StatusPedido: Entity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
