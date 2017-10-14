using Dipapel.Core.EF;
using Dipapel.Core.EF.Repositories;
using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipapel.Core.ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ctx = new Repository<Pedido>();

            _ctx.Adicionar(new Pedido { Comprador = "adfs", DataPedido = "adfasd", TipoFrete = "afdsf", TotalItens = 1, ValorFrete = 1.00, ValorTotal = 4.10});


            var pedidoRepository = new PedidoRepository();
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

            // var pedidoDao = new PedidoDAO();

            foreach (var linha in pedidosElo7)
            {
                string[] campos = linha.Split(';');

                var pedidoAux = new Pedido();
                pedidoAux.Codigo = campos[0];
                pedidoAux.Comprador = campos[1];
                //pedidoAux.Status = new StatusPedido() { Codigo = campos[2] };
                pedidoAux.DataPedido = campos[3];
                pedidoAux.TotalItens = 2; // hard code
                pedidoAux.ValorTotal = 1.00; // hard code
                pedidoAux.TipoFrete = campos[6];
                pedidoAux.ValorFrete = 2.00; // hard code

                pedidoRepository.Adicionar(pedidoAux);
                //                pedidoDao.Adicionar(pedidoAux);
            }



            Console.ReadLine();

        }
    }
}
