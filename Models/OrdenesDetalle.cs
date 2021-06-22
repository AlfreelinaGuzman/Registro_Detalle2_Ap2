using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Registro_Detalle2_Ap2.Models
{
    public class OrdenesDetalle{
        [Key]
        public int ID { get; set; }
        public int OrdenID { get; set; }
        public string Suplidor { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
       
    }
}