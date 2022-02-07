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

        public ProductosBL()
        {
            _contexto = new Contexto();

        }
        public List<Producto> ObtenerProductos()
        {
         _contexto.Productos.ToList();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Iphonex";
            producto1.Precio = 1500;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "PC Gammer";
            producto2.Precio = 250;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Xioami Mi Band 6";
            producto3.Precio = 26;


            var listaProductos = new List<Producto>();
            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);


            return listaProductos;

        }

    }
}
