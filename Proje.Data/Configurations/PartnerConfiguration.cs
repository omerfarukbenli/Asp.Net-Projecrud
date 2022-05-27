using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Data.Configurations
{
    public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.HasOne(o => o.Product).WithMany(b => b.Partners).HasForeignKey(c => c.ProductId);
            builder.HasOne(o => o.Sparepart).WithMany(b => b.Partners).HasForeignKey(c => c.SparepartId);
        }
    }
}
