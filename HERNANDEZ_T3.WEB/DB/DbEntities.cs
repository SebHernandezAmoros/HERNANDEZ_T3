using HERNANDEZ_T3.WEB.DB.Mapping;
using HERNANDEZ_T3.WEB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HERNANDEZ_T3.WEB.DB
{
    public class DbEntities: DbContext
    {
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Mascota> Mascotas { get; set; }
        public DbEntities() 
        { 
        }
        public DbEntities(DbContextOptions<DbEntities> options) : base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmpleadoMapping());
            modelBuilder.ApplyConfiguration(new MascotaMapping());
        }
    }
}
