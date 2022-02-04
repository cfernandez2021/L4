using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_BL
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Estado { get; set; }
        public string Envio { get; set; } //Definiremos si el envio es gratis o con costo adicional//


    }
}

