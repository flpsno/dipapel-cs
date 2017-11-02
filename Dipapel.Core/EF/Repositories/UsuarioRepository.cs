using Dipapel.Core.Contracts;
using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.EF.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public Usuario ObterByEmail(string codigo)
        {
            var usuario = _ctx.Usuarios.Where(p => p.Email.Contains(codigo));
            return usuario.FirstOrDefault<Usuario>();
        }
    }
}
