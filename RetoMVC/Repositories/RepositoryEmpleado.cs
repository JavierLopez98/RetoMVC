using RetoMVC.Intefaces;
using RetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RetoMVC.Repositories
{
    public class RepositoryEmpleado: IRepositoryEmpleado
    {
        IEmpleadoContext context;

        public RepositoryEmpleado(IEmpleadoContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in this.context.Empleados select datos;
            return consulta.ToList();
        }
    }
}