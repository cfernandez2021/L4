
using Honduras_Shopping.BL;
using System.Web.Mvc;

namespace Honduras_Shopping.Web.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;

        public ProductosController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();

            var listadeProductos = productosBL.ObtenerProductos();

            return View(listadeProductos);
        }
    }
}