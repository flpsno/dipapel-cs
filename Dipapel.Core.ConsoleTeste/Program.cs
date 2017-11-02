using Dipapel.Core.EF;
using Dipapel.Core.EF.Repositories;
using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dipapel.Core.Helpers;

namespace Dipapel.Core.ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            /*using (var ctx = new UsuarioRepository())
            {
                var felipe = new Usuario() { NOME = "Felipe", Email = "flpsno@hotmail.com", Senha = "metal001".Encrypt(), Habilitado = true };

                ctx.Adicionar(felipe);

            }*/


            using (var ctx = new PedidoRepository())
            {
                var fazImport = true;

                if (fazImport)
                {

                    string[] pedidosElo7 = {
                //            'Pedido; Comprador; Status Pedido; Data Pedido; Total Itens; Valor Pedido; Tipo Frete; Valor Frete'
                                "B965EF; Barbara Weinert; PAGO_ESPERANDO_VENDEDOR; 29 / 07 / 2017; 1; 139.95; PAC; 19.32",
                                "B9496A; Sarah de Souza portugal; AGUARDANDO_CONFIRMACAO_PAGAMENTO; 28 / 07 / 2017; 1; 127.97; PAC; 25.49",
                                "B7A949; geany zanin; AGUARDANDO_FRETE; 20 / 07 / 2017; 1; 90.00; ;",
                                "B77E07; Priscila Adilson; PAGO_ESPERANDO_VENDEDOR; 19 / 07 / 2017; 1; 133.31; SEDEX; 9.51",
                                "B6E3CA; Clarice Ap; PAGO_ESPERANDO_VENDEDOR; 17 / 07 / 2017; 1; 89.89; SEDEX; 17.50",
                                "B67025; LUANA LAZZARETTI; PAGO_ESPERANDO_VENDEDOR; 14 / 07 / 2017; 1; 76.85; PAC; 18.35",
                                "B302F6; any; PAGO_ESPERANDO_VENDEDOR; 29 / 06 / 2017; 1; 742.25; SEDEX; 37.18",
                                "B0DC33; Jeane Leão; PAGO_ESPERANDO_VENDEDOR; 19 / 06 / 2017; 1; 78.59; PAC; 17.24",
                                "AF5F54; Gabriela Fonseca; PEDIDO_ENVIADO; 09 / 06 / 2017; 1; 163.98; SEDEX; 9.76",
                                "AD6A40; karen; PEDIDO_ENVIADO; 01 / 06 / 2017; 1; 175.54; PAC; 31.27"
                            };

                    foreach (var linha in pedidosElo7)
                    {
                        string[] campos = linha.Split(';');

                        var ctxStatusPedido = new StatusPedidoRepository();

                        var statusPedido = ctxStatusPedido.ObterByCodigo(campos[2].Trim());
                        //var statusPedido = new StatusPedido() { Id = 1, Codigo = "teste" }; 

                        ctxStatusPedido.Dispose();

                        var pedidoAux = new Pedido();
                        pedidoAux.Codigo = campos[0];
                        pedidoAux.Comprador = campos[1];
                        pedidoAux.IdStatusPedido = statusPedido.Id;
                        pedidoAux.DataPedido = DateTime.Now; // campos[3];
                        pedidoAux.TotalItens = String.IsNullOrEmpty(campos[4].Trim()) ? 0 : int.Parse(campos[4].Trim(), CultureInfo.InvariantCulture.NumberFormat); // hard code
                        pedidoAux.ValorTotal = String.IsNullOrEmpty(campos[5].Trim()) ? 0.00F : float.Parse(campos[5].Trim(), CultureInfo.InvariantCulture.NumberFormat);
                        pedidoAux.TipoFrete = campos[6];
                        pedidoAux.ValorFrete = String.IsNullOrEmpty(campos[7].Trim()) ? 0.00F : float.Parse(campos[7].Trim(), CultureInfo.InvariantCulture.NumberFormat);

                        ctx.Adicionar(pedidoAux);
                    }
                }


                var listaPedidos = ctx.Obter().OrderBy(c => c.ValorTotal);
                foreach (var pedido in listaPedidos)
                {
                    Console.WriteLine("Id: {0} - Codigo: {1} - Comprador: {2} - Status: {3} - Data Pedido: {4} - Total Itens: {5} - Valor Total: {6}"
                        , pedido.Id, pedido.Codigo, pedido.Comprador, pedido.StatusPedido.Descricao, pedido.DataPedido.ToString("dd/MM/yyyy"), pedido.TotalItens, pedido.ValorTotal);
                }


            }
            Console.ReadLine();
        }
    }
}
