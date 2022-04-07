﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Honduras_Shopping.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBL _seguridadBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();
        }
        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SighOut();
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            var nombreUsuario = data["username"];
            var contrasena = data["password"];

            var usuarioValido = _seguridadBL.Autorizar(nombreUsuario, contrasena);

            if (usuarioValido)
            {
                FormsAuthentication.SetAuthCookie(nombreUsuario, true);
                return RedirectToAction("Index", "Home");
            }

            modelstate.AddModelError("", "usuario o contrasena invalido");
            return view();
        }

    }
}