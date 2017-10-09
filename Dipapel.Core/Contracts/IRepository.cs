using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.Contracts
{
    public interface IRepository<T>: IDisposable
    {
        IEnumerable<T> Obter();
        T ObterById(int id);
        T Adicionar(T obj);
        T Editar(T obj);
        void Delete(T obj);
    }
}
