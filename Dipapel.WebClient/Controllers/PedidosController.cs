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
            var pedidos = _ctx.Obter();
            return View(pedidos);
        }

        public ActionResult Add()
        {
            var statusRepo = new StatusPedidoRepository();

            var listaStatusPedido = statusRepo.Obter();
            ViewBag.ListaStatusPedido = listaStatusPedido;

            statusRepo.Dispose();

            return View();
        }

        [HttpPost]
        public ActionResult Add(Pedido pedido)
        {
            _ctx.Adicionar(pedido);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var pedido = _ctx.ObterById(id);
            if (pedido == null)
                return HttpNotFound();

            var statusRepo = new StatusPedidoRepository();

            var listaStatusPedido = statusRepo.Obter();
            ViewBag.ListaStatusPedido = listaStatusPedido;

            statusRepo.Dispose();

            return View(pedido);
        }

        [HttpPost]
        public ActionResult Edit(Pedido pedido)
        {
            _ctx.Editar(pedido);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var pedido = _ctx.ObterById(id);

            if (pedido == null)
                return HttpNotFound();

            return View(pedido);
        }

        [HttpPost]
        public ActionResult Delete(Pedido pAux)
        {

            var pedido = _ctx.ObterById(pAux.Id);
            _ctx.Delete(pedido);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}