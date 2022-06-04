using HERNANDEZ_T3.WEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HERNANDEZ_T3.WEB.DB.Mapping
{
    public class EmpleadoMapping : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado", "dbo");
            builder.HasKey(o => o.EmpleadoId);
        }
    }
}
