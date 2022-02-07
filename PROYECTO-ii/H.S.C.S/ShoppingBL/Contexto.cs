using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBL
{
    public class Contexto:DbContext
    {
        public Contexto():base("ShoppinDB")
        {

        }
        
        public DbSet<Producto> Productos { get; set; }

    }
}
