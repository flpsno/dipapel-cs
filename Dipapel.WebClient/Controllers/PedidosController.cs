using Dipapel.Core.EF.Repositories;
using Dipapel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dipapel.WebClient.Controllers
{
    public class PedidosController : Controller
    {
        private PedidoRepository _ctx = new PedidoRepository();

        // GET: Pedidos
        public ActionResult Index()
        {
            return View(_ctx.Obter());
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Pedido pedido)
        {
            _ctx.Adicionar(pedido);
            return RedirectToAction("Index");
        }
    }
}