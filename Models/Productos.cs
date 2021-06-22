using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Registro_Detalle2_Ap2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Concepto { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public double Existencia { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public decimal Costo { get; set; }
        public decimal ValorInventario { get; set; }

    }
    
}