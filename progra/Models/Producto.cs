using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace progra.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        [Required(ErrorMessage = "Por favor ingrese nombre de producto")]
        [Display(Name="Nombre Producto")]
        public String Name {get; set;}

        [Required(ErrorMessage = "Please enter Price")]
        public Decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter Image Name")]
        public String ImagenName { get; set; }

        [Required(ErrorMessage = "Please enter categoria")]
        public String categoria { get; set; }

        

        public virtual ICollection<Proforma> ProformaItems { get; set; }

    }
}