using Dipapel.Core.EF.Repositories;
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
    }
}