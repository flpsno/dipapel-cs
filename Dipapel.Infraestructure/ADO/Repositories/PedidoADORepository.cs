using Dipapel.Domain.Contracts.Repositories;
using Dipapel.Domain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Dipapel.Infraestructure.ADO.Repositories
{
    public class PedidoADORepository : IPedidoRepository
    {
        private readonly DipapelADODataContext _ctx = new DipapelADODataContext();

        public void Delete(Pedido pedido)
        {
            try
            {
                _ctx.OpenDB();
                var sql = "DELETE FROM tblpedidos WHERE IDPEDIDO = @IDPEDIDO";
                var cmd = new MySqlCommand(sql, _ctx.Connection);
                cmd.Parameters.AddWithValue("@IDPEDIDO", pedido.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _ctx.CloseDB();
            }

        }

        public Pedido Edit(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pedido GetByID(int id)
        {
            try
            {
                _ctx.OpenDB();
                var sql = "SELECT * FROM tblpedidos WHERE IDPEDIDO = @IDPEDIDO";
                var cmd = new MySqlCommand(sql, _ctx.Connection);
                cmd.Parameters.AddWithValue("@IDPEDIDO", id);
                var dr = cmd.ExecuteReader();

                var pedido = new Pedido();

                while (dr.Read())
                {
                    pedido.Id = id;
                    pedido.Codigo = dr["PEDIDO_ELO7"].ToString();
                    pedido.Comprador = dr["COMPRADOR"].ToString();
                    pedido.DataPedido = Convert.ToDateTime(dr["DATA_PEDIDO"]);
                    pedido.TotalItens = Convert.ToInt32(dr["TOTAL_ITENS"]);
                    pedido.ValorTotal = Convert.ToDouble(dr["VALOR_TOTAL"]);
                    pedido.TipoFrete = dr["TIPO_FRETE"].ToString();
                    pedido.ValorFrete = Convert.ToDouble(dr["VALOR_FRETE"]);
                    pedido.IdStatusPedido = Convert.ToInt32(dr["IDSTATUSPEDIDO"]);
                }

                return pedido;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _ctx.CloseDB();

            }

        }

        public Pedido Insert(Pedido pedido)
        {
            try
            {
                _ctx.OpenDB();
                var sql = "INSERT INTO tblpedidos(PEDIDO_ELO7,STATUS_ELO7,DATA_PEDIDO,TOTAL_ITENS,VALOR_TOTAL,TIPO_FRETE,VALOR_FRETE,COMPRADOR,ITENS,IDPEDIDOSCFG,IDSTATUSPEDIDO,"
                    + "DATA_IMPORTACAO,EMAIL) VALUES (@PEDIDO_ELO7,@STATUS_ELO7,now(),@TOTAL_ITENS,@VALOR_TOTAL,@TIPO_FRETE,@VALOR_FRETE,@COMPRADOR,@ITENS,@IDPEDIDOSCFG,@IDSTATUSPEDIDO,"
                    + "now(),@EMAIL)";

                var cmd = new MySqlCommand(sql, _ctx.Connection);
                cmd.Parameters.AddWithValue("@PEDIDO_ELO7", pedido.Codigo);
                cmd.Parameters.AddWithValue("@STATUS_ELO7", "TESTE_STATUS");
                cmd.Parameters.AddWithValue("@TOTAL_ITENS", pedido.TotalItens);
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", pedido.ValorTotal);
                cmd.Parameters.AddWithValue("@TIPO_FRETE", pedido.TipoFrete);
                cmd.Parameters.AddWithValue("@VALOR_FRETE", pedido.ValorFrete);
                cmd.Parameters.AddWithValue("@COMPRADOR", pedido.Comprador);
                cmd.Parameters.AddWithValue("@ITENS", "TESTE_ITENS");
                cmd.Parameters.AddWithValue("@IDPEDIDOSCFG", 1);
                cmd.Parameters.AddWithValue("@IDSTATUSPEDIDO", 1);
                cmd.Parameters.AddWithValue("@EMAIL", "TESTE@EMAIL");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _ctx.CloseDB();
            }

            return pedido;
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
