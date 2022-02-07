using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBL
{
    public class ProductosBL
    {

        Contexto _contexto;
        public List<Producto>  ListadodeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadodeProductos = new List<Producto>();

        }
        public List<Producto> ObtenerProductos()
        {
         ListadodeProductos= _contexto.Productos.ToList();
            return ListadodeProductos;

        }

    }
}
