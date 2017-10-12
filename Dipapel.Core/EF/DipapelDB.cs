using Dipapel.ConsoleTeste.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.EF
{
    public class DipapelDB : DbContext
    {
        private const string _StringConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dipapeldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public DipapelDB()
            : base(_StringConnection)
        {
            Database.SetInitializer(new CargaInicialDados());
        }

        public DbSet<Pedido> Pedidos;
    }

    internal class CargaInicialDados : CreateDatabaseIfNotExists<DipapelDB>
    {

        protected override void Seed(DipapelDB context)
        {
            var pedidos = new List<Pedido> {
                    new Pedido { Codigo = "teste", Comprador = "teste", DataPedido = DateTime.Now.ToString(), TipoFrete = "sedex", TotalItens = 1,
                    ValorFrete = 0.00, ValorTotal = 0.00}
            };

            context.Pedidos.AddRange(pedidos);
            context.SaveChanges();
        }
    }
}
