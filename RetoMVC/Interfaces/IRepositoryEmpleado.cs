﻿using RetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RetoMVC.Intefaces
{
    public interface IRepositoryEmpleado
    {
        List<Empleado> GetEmpleados();
    }
}