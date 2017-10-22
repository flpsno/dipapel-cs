using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Entities
{
    public abstract class Entity
    {

        public DateTime DataCadastro { get; private set; } = DateTime.Now;
    }
}
