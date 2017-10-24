using Dipapel.Core.EF.Repositories;
using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipapel.Ui.Integracao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnProcessarArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                var textLines = File.ReadAllLines(txtFilePath.Text);
                ProcessarPedidos(textLines);
            }
            catch (IOException)
            {
            }
        }

        private void ProcessarPedidos(string[] textLines)
        {
            using (var ctxPedidoRepository = new PedidoRepository())
            {
                foreach (var linha in textLines)
                {
                    string[] campos = linha.Split(';');

                    if (campos[0].Trim() != "Pedido")
                    {
                        using (var ctxStatusPedido = new StatusPedidoRepository())
                        {

                            var statusPedido = ctxStatusPedido.ObterByCodigo(campos[2].Trim());

                            var pedidoAux = new Pedido();
                            pedidoAux.Codigo = campos[0];
                            pedidoAux.Comprador = campos[1];
                            pedidoAux.IdStatusPedido = statusPedido.Id;
                            pedidoAux.DataPedido = DateTime.ParseExact(campos[3].Trim(), "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture); 
                            pedidoAux.TotalItens = String.IsNullOrEmpty(campos[4].Trim()) ? 0 : int.Parse(campos[4].Trim(), CultureInfo.InvariantCulture.NumberFormat); // hard code
                            pedidoAux.ValorTotal = String.IsNullOrEmpty(campos[5].Trim()) ? 0.00F : float.Parse(campos[5].Trim(), CultureInfo.InvariantCulture.NumberFormat);
                            pedidoAux.TipoFrete = campos[6];
                            pedidoAux.ValorFrete = String.IsNullOrEmpty(campos[7].Trim()) ? 0.00F : float.Parse(campos[7].Trim(), CultureInfo.InvariantCulture.NumberFormat);

                            if (ctxPedidoRepository.ObterByCodigo(pedidoAux.Codigo) == null)
                                ctxPedidoRepository.Adicionar(pedidoAux);
                            else
                                ctxPedidoRepository.Editar(pedidoAux);
                        }
                    }
                }
            }
        }
    }
}
