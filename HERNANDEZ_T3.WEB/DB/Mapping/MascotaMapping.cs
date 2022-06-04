using HERNANDEZ_T3.WEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HERNANDEZ_T3.WEB.DB.Mapping
{
    public class MascotaMapping : IEntityTypeConfiguration<Mascota>
    {
        public void Configure(EntityTypeBuilder<Mascota> builder)
        {
            builder.ToTable("Mascota", "dbo");
            builder.HasKey(o => o.MascotaId);
        }
    }
}
