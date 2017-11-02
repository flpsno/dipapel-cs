using Dipapel.Core.EF.Repositories;
using Dipapel.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dipapel.Core.Helpers;
using Dipapel.Core.Entities;
using System.Web.Security;

namespace Dipapel.WebClient.Controllers
{
    public class ContaController : Controller
    {
        private readonly UsuarioRepository _ctx = new UsuarioRepository();

        public ActionResult Login(string returnUrl)
        {
            ViewBag.url = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario login)
        {
            ModelState.Clear();
            var usuario = _ctx.ObterByEmail(login.Email.ToLower());

            if (usuario == null)
                ModelState.AddModelError("Email", "Email não localizado");
            else
            {
                if (usuario.Senha != login.Senha.Encrypt())
                    ModelState.AddModelError("Senha", "Senha incorreta");

                if (!usuario.Habilitado)
                    ModelState.AddModelError("", "Usuário Desativado");
            }

            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(login.Email, false);

                /*if (!string.IsNullOrEmpty(login.Url) && Url.IsLocalUrl(login.Url))
                {
                    return Redirect(login.Url);
                }*/

                return RedirectToAction("Index", "Home");
            }
            return View(login);

        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}