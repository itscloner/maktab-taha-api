using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.tasvib
{
    public class TasvibMapping : IEntityTypeConfiguration<Tasvib>
    {
        public void Configure(EntityTypeBuilder<Tasvib> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TasvibDate);

            builder.Property(x => x.TahghighId);
            builder.HasOne(x => x.Tahghigh)
                .WithMany()
                .HasForeignKey(x => x.TahghighId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.CaseNumber);
            builder.HasOne(x => x.Case)
                .WithMany()
                .HasForeignKey(x => x.CaseNumber)
                .HasPrincipalKey(x => x.CaseNumber)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.ClientRequestDescription);

            builder.Property(x => x.MosavebId);
            builder.HasOne(x => x.Mosaveb)
                .WithMany()
                .HasForeignKey(x => x.MosavebId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.TasvibStatus).HasConversion<string>();

            builder.Property(x => x.TasvibReason);
            builder.Property(x => x.Description);

            builder.Property(x => x.ManagerTasvibStatus).HasConversion<string>();
        }
    }
}
