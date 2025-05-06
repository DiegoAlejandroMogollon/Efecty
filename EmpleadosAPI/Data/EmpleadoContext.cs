// Uso de entity framework para mapear la base de datos

using EmpleadosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpleadosAPI.Data
{

    public class EmpleadoContext : DbContext
    {
     public EmpleadoContext(DbContextOptions<EmpleadoContext> options) : base(options){}
     public DbSet<Empleado> Empleados {get; set;}
    }
}

