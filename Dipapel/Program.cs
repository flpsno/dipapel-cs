using Dipapel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel
{
    class Program
    {
        static void Main(string[] args)
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

            var pedidoDao = new PedidoDAO();

            foreach (var linha in pedidosElo7)
            {
                string[] campos = linha.Split(';');

                var pedidoAux = new Pedido();
                pedidoAux.Codigo = campos[0];
                pedidoAux.Comprador = campos[1];
                pedidoAux.Status = StatusPedido.PEDIDO_ENVIADO; // hard code
                pedidoAux.DataPedido = campos[3];
                pedidoAux.TotalItens = 2; // hard code
                pedidoAux.ValorTotal = 1.00; // hard code
                pedidoAux.TipoFrete = campos[6];
                pedidoAux.ValorFrete = 2.00; // hard code

                pedidoDao.Adicionar(pedidoAux);
            }

            //var listaPedidos = pedidoDao.ObterTodos();
            pedidoDao.ObterTodos()
                .OrderBy(x => x.Comprador)
                .ToList().ForEach(x =>
                {
                    var saida = new StringBuilder();
                    saida.Append("================ novo pedido ====================");
                    saida.Append("\nCodigo: " + x.Codigo + " - Comprador:" + x.Comprador);
                    saida.Append("\nData Pedido: " + x.DataPedido);
                    saida.Append("\nTipo Frete: " + x.TipoFrete);
                    Console.WriteLine(saida.ToString());
                });


            Console.WriteLine("Total de Pedidos é: {0}", pedidoDao.TotalPedidos());

            Console.ReadLine();

        }
    }
}
