using ShoppingBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H.S.C.S_WEB.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {

            var productosBL = new ProductosBL();
            var listadoProductos = productosBL.ObtenerProductos();

            
            return View(listadoProductos);
        }
    }
}