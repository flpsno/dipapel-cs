﻿using System;
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
        public DbSet<StatusPedido> StatusPedidos { get; set; }
    }

    internal class CargaInicialDados : CreateDatabaseIfNotExists<DipapelDB>
    {

        protected override void Seed(DipapelDB context)
        {
            var aguardandoPagamento = new StatusPedido() { Codigo = "AGUARDANDO_PAGAMENTO", Descricao = "Aguardando Pagamento" };
            var pedidoEnviado = new StatusPedido() { Codigo = "PEDIDO_ENVIADO", Descricao = "Pedido Enviado" };
            var aguardandoConfirmacaoPagamento = new StatusPedido() { Codigo = "AGUARDANDO_CONFIRMACAO_PAGAMENTO", Descricao = "Aguardando Confirmação Pag." };
            var aguardandoFrete = new StatusPedido() { Codigo = "AGUARDANDO_FRETE", Descricao = "Aguardando Frete" };
            var aguardandoCompradorEscolherFrete = new StatusPedido() { Codigo = "AGUARDANDO_COMPRADOR_ESCOLHER_FRETE", Descricao = "Aguardando Comprador Escolher o Frete" };
            var pagoEsperandoVendedor = new StatusPedido() { Codigo = "PAGO_ESPERANDO_VENDEDOR", Descricao = "Pago Esperando o Vendedor" };

            var pedidos = new List<Pedido> {
                    new Pedido { Codigo = "CODIGO1", Comprador = "teste", DataPedido = DateTime.Now, TipoFrete = "sedex",
                        TotalItens = 1, ValorFrete = 0.00, ValorTotal = 0.00, StatusPedido = aguardandoPagamento},
                    new Pedido { Codigo = "CODIGO2", Comprador = "teste", DataPedido = DateTime.Now, TipoFrete = "sedex",
                        TotalItens = 1, ValorFrete = 0.00, ValorTotal = 0.00, StatusPedido = pedidoEnviado},
                    new Pedido { Codigo = "CODIGO3", Comprador = "teste", DataPedido = DateTime.Now, TipoFrete = "sedex",
                        TotalItens = 1, ValorFrete = 0.00, ValorTotal = 0.00, StatusPedido = aguardandoConfirmacaoPagamento},
                    new Pedido { Codigo = "CODIGO4", Comprador = "teste", DataPedido = DateTime.Now, TipoFrete = "sedex",
                        TotalItens = 1, ValorFrete = 0.00, ValorTotal = 0.00, StatusPedido = aguardandoFrete},
                    new Pedido { Codigo = "CODIGO5", Comprador = "teste", DataPedido = DateTime.Now, TipoFrete = "sedex",
                        TotalItens = 1, ValorFrete = 0.00, ValorTotal = 0.00, StatusPedido = aguardandoCompradorEscolherFrete},
                    new Pedido { Codigo = "CODIGO6", Comprador = "teste", DataPedido = DateTime.Now, TipoFrete = "sedex",
                        TotalItens = 1, ValorFrete = 0.00, ValorTotal = 0.00, StatusPedido = pagoEsperandoVendedor}
            };

            context.Pedidos.AddRange(pedidos);
            context.SaveChanges();
        }
    }
}
