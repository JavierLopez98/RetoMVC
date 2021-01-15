using RetoMVC.Intefaces;
using RetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RetoMVC.Data
{
    public class EmpleadoContext : DbContext, IEmpleadoContext
    {
        public EmpleadoContext() : base("name=casaReto") { }

        
        public DbSet<Empleado> Empleados { get; set; }
    }
}