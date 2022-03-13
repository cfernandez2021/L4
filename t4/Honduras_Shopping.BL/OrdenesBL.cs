using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honduras_Shopping.BL
{
    public class OrdenesBL
    {
        Contexto _contexto;
        public List<Orden> ListadeOrdenes { get; set; }

        public OrdenesBL()
        {
            _contexto = new Contexto();

        }

        public List<Orden>ObtnerOrdenes()
        {
            ListadeOrdenes = _contexto.Ordenes
                .Include("Cliente")
                .ToList();


            return ListadeOrdenes;
        }

       public List<OrdenDetalle>ObtenerOrdenDetalle(int ordenId)
        {
            var Listadeordenesdetalle = _contexto.OrdenDetalle.Where(o => o.OrdenId == ordenId).ToList();
            return Listadeordenesdetalle;
        }


        public Orden ObtenerOrden(int id)
        {
            var orden = _contexto.Ordenes
                .Include("Cliente").FirstOrDefault(p => p.Id == id);

            return orden;
        }


        public void GuardarOrden(Orden orden)
        {
            if (orden.Id == 0)
            {
                _contexto.Ordenes.Add(orden);
            }
            else
            {
                var ordenExistente = _contexto.Ordenes.Find(orden.Id);
                ordenExistente.ClienteId = orden.ClienteId;
                ordenExistente.Activo = orden.Activo;
            }

            _contexto.SaveChanges();
        }

        public void GuardarOrdenDetalle(OrdenDetalle ordenDetalle)
        {
            _contexto.OrdenDetalle.Add(ordenDetalle);
            _contexto.SaveChanges();

        }
    }
}
