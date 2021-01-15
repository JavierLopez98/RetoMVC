using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RetoMVC.Models
{
    [Table("Emp")]
    public class Empleado
    {
        [Key]
        [Column("Emp_No")]
        public int codigo { get; set; }
        public String Apellido { get; set; }
        public String Oficio { get; set; }
        public int Salario { get; set; }
        public int Comision { get; set; }
    }
}