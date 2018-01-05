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
    public partial class frmPrincipal : Form
    {
        private List<Pedido> _pedidos = new List<Pedido>();
        private int _pedidosNovos = 0;
        private int _pedidosEditados = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK)
                return;

            txtFilePath.Text = openFileDialog1.FileName;

            CarregarArquivo();
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

        private void CarregarArquivo()
        {
            _pedidos.Clear();
            _pedidosNovos = 0;
            _pedidosEditados = 0;

            if (!File.Exists(txtFilePath.Text.Trim()))
                return;

            try
            {
                var textLines = File.ReadLines(txtFilePath.Text.Trim());

                pgbPedidos.Minimum = 0;
                pgbPedidos.Maximum = textLines.Count() - 1;

                // pula a primeira linha, porque é o cabeçalho
                for (int i = 1; i < textLines.Count(); i++)
                {
                    pgbPedidos.Value = i;

                    var campos = textLines.ElementAt(i).Split(';');

                    var pedidoAux = new Pedido();
                    pedidoAux.Codigo = campos[0].Trim();
                    pedidoAux.Comprador = campos[1].Trim();
                    pedidoAux.StatusSTR = campos[2].Trim();
                    pedidoAux.DataPedido = DateTime.ParseExact(campos[3].Trim(), "dd/MM/yyyy",
                               System.Globalization.CultureInfo.InvariantCulture);
                    pedidoAux.TotalItens = String.IsNullOrEmpty(campos[4].Trim()) ? 0 : int.Parse(campos[4].Trim(), CultureInfo.InvariantCulture.NumberFormat); // hard code
                    pedidoAux.ValorTotal = String.IsNullOrEmpty(campos[5].Trim()) ? 0.00F : float.Parse(campos[5].Trim(), CultureInfo.InvariantCulture.NumberFormat);
                    pedidoAux.TipoFrete = campos[6];
                    pedidoAux.ValorFrete = String.IsNullOrEmpty(campos[7].Trim()) ? 0.00F : float.Parse(campos[7].Trim(), CultureInfo.InvariantCulture.NumberFormat);

                    _pedidos.Add(pedidoAux);
                }
            }
            catch (IOException) 
            {

            }

            AtualizarDadosTela();
        }

        private void AtualizarDadosTela()
        {
            AtualizarLabels();
            var bindingList = new BindingList<Pedido>(_pedidos);
            var source = new BindingSource(bindingList, null);
            dtgvPedidos.DataSource = source;
        }

        private void AtualizarLabels()
        {
            lblTotalPedidos.Text = _pedidos.Count().ToString();
            lblNovos.Text = _pedidosNovos.ToString();
            lblEditados.Text = _pedidosEditados.ToString();
        }

        private void ProcessarPedidos(string[] textLines)
        {
            _pedidosNovos = 0;
            _pedidosEditados = 0;

            pgbPedidos.Minimum = 0;
            pgbPedidos.Maximum = _pedidos.Count();

            using (var ctxPedidoRepository = new PedidoRepository())
            {
                var i = 1;

                foreach (var pedido in _pedidos)
                {
                    pgbPedidos.Value = i;
                    i += 1;

                    using (var ctxStatusPedido = new StatusPedidoRepository())
                    {
                        var statusPedido = ctxStatusPedido.ObterByCodigo(pedido.StatusSTR);
                        pedido.IdStatusPedido = statusPedido.Id;
                    }

                    // se não encontrar pelo código, adiciona
                    var pedidoAux = ctxPedidoRepository.ObterByCodigo(pedido.Codigo);
                    if (pedidoAux == null)
                    {
                        ctxPedidoRepository.Adicionar(pedido);
                        _pedidosNovos += 1;
                    }
                    // senão edita existente
                    else
                    {
                        pedidoAux.IdStatusPedido = pedido.IdStatusPedido;
                        ctxPedidoRepository.Editar(pedidoAux);
                        _pedidosEditados += 1;
                    }

                    AtualizarLabels();
                }
            }
            MessageBox.Show("Processamento finalizado!");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AtualizarDadosTela();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
