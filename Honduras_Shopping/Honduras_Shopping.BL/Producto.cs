using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honduras_Shopping.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "ingrese la descripcion")]
        [MinLength(3, ErrorMessage = "ingrese minimo 3 caracteres")]
        [MaxLength(60, ErrorMessage = "ingrese minimo 60 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "ingrese el precio")]
        [Range(0, 1000, ErrorMessage = "ingrese un precio entre 0 y 1000")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        [Display(Name = "imagen")]
        public string UrlImagen { get; set; }
        public bool Activo { get; set; }
    }
}
