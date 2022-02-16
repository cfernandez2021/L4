using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honduras_Shopping.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public List<Producto> ListadeProductos { get; set; }
        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }



       public  List<Producto> ObtenerProductos()
        {


            ListadeProductos = _contexto.Productos.ToList();

            return ListadeProductos; 
        }

        public void GuardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            }
            else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
            }
                
            _contexto.SaveChanges();
        }

        public Producto ObtenerProducto(int Id)
        {
            var producto = _contexto.Productos.Find(Id);

            return producto;
        }

        public void EliminarProducto(int Id)
        {
            var producto = _contexto.Productos.Find(Id);
            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
    }
}
