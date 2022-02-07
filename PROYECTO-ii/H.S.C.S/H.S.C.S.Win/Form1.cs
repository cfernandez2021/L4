using ShoppingBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H.S.C.S.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var productosBL = new ProductosBL();
            var listadodeProductos = productosBL.ObtenerProductos();

            listadodeProductosBindingSource.DataSource = listadodeProductos;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
