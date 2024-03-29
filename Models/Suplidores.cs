using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registro_Detalle2_Ap2.Models{

    public class Suplidores{
        [Key]
        public int SuplidorID { get; set; }
        public string Nombres { get; set; }
        public int ProductoId {get; set;}

        [ForeignKey("SuplidorID")]
        public virtual List<OrdenesDetalle> OrdenesDetalle {get; set;} 

        public Suplidores()
        {
            OrdenesDetalle = new List<OrdenesDetalle>();
        }

    }
    
}