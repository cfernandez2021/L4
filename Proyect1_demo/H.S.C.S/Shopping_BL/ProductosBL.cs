using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_BL
{
    public class ProductosBL
    {

        public List<Producto> ObtenerProductos()
        {

            var producto1 = new Producto();
            producto1.Codigo = 1;
            producto1.Descripcion = "IPHONE XS";
            producto1.Precio = 250;

            var producto2 = new Producto();
            producto2.Codigo = 2;
            producto2.Descripcion = "Powe Bank 10000Mbp";
            producto2.Precio = 30;

            var producto3 = new Producto();
            producto3.Codigo = 3;
            producto3.Descripcion = "Redmi Xiaomi 7";
            producto3.Precio = 350;

            var listaProductos = new List<Producto>();
            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);

            return listaProductos;
        }


    }
}
