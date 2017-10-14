using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dipapel.Core.Contracts;
using Dipapel.Core.Entities;

namespace Dipapel.Core.EF
{
    public class DipapelDB : DbContext
    {
        public DipapelDB()
            : base(Contracts.Constantes.CONNECTION_STRING_PRODUCAO)
        {
            Database.SetInitializer(new CargaInicialDados());
        }

        public DbSet<Pedido> Pedidos { get; set; }
    }

    internal class CargaInicialDados : CreateDatabaseIfNotExists<DipapelDB>
    {

        protected override void Seed(DipapelDB context)
        {
            var pedidos = new List<Pedido> {
                    new Pedido { Comprador = "teste", DataPedido = DateTime.Now.ToString(), TipoFrete = "sedex", TotalItens = 1,
                    ValorFrete = 0.00, ValorTotal = 0.00}
            };

            context.Pedidos.AddRange(pedidos);
            context.SaveChanges();
        }
    }
}
