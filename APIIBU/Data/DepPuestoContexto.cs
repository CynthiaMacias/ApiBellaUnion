using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIBU.Controllers;
using APIIBU.Models;
using Microsoft.EntityFrameworkCore;

namespace APIIBU.Data
{
 
        public class DepPuestoContexto : DbContext
        {
            public DepPuestoContexto(DbContextOptions<DepPuestoContexto> options) :
                base(options)
            {

            }
            public DbSet<Departamento> Departamento { get; set; }
            public DbSet<Puesto> Puesto { get; set; }
            public DbSet<Horario> Horario { get; set; }
            public DbSet<Contrato> Contrato { get; set; }
            public DbSet<Empresa> Empresas { get; set; }
            public DbSet<Empleado> Empleado { get; set; }
            public DbSet<Reloj> Reloj { get; set; }
    }
}
