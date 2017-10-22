using Dipapel.Core.Contracts;
using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.EF.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        //private List<T> _BancoDeDadosFake = new List<T>();
        protected readonly DipapelDB _ctx = new DipapelDB();

        public T Adicionar(T obj)
        {
            _ctx.Set<T>().Add(obj);
            _ctx.SaveChanges();
            return obj;
        }

        public void Delete(T obj)
        {
            _ctx.Set<T>().Remove(obj);
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public T Editar(T obj)
        {
            _ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            _ctx.SaveChanges();
            return obj;            
        }

        public IEnumerable<T> Obter()
        {
            return _ctx.Set<T>().ToList();
        }

        public T ObterById(int id)
        {
            return _ctx.Set<T>().Find(id);
        }
    }
}
