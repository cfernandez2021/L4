using Honduras_Shopping.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Honduras_Shopping.Web.Controllers
{
    public class CategoriaController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriaController()
        {
            _categoriasBL = new CategoriasBL();
        }
        // GET: Categorias
        public ActionResult Index()
        {
            var listadecategorias = _categoriasBL.ObtenerCategorias();

            return View(listadecategorias);
        }
    
        public ActionResult Crear()
        {
            var nuevacategoria = new Categoria();

            return View(nuevaCategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {

            _categoriasBL.GuardarCategoria(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int Id)
        {
            var producto = _categoriasBL.ObtenerCategoria(Id);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar(Categoria producto)
        {
            _categoriasBL.GuardarCategoria(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int Id)
        {
            var producto = _categoriasBL.ObtenerCategoria(Id);
            return View(producto);
        }

        public ActionResult Eliminar(int Id)
        {
            var producto = _categoriasBL.ObtenerCategoria(Id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Categoria producto)
        {
            _categoriasBL.EliminarCategoria(producto.Id);
            return RedirectToAction("Index");
        }
    }
}