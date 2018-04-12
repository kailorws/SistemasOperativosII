using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lec09.Models
{
    public class Producto
    {
        [Required(ErrorMessage="IdProducto es requerido")]
        public int IdProducto { get; set; }
        [StringLength(10,ErrorMessage="Maximo diez caracteres")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Range(1000,50000,ErrorMessage="Precio no esta en rango")]
        public double Precio { get; set; }
        public int CantidadDisponibles { get; set; }
    }
}