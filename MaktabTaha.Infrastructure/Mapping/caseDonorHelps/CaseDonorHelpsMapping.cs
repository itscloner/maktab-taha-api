using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.caseDonorHelps
{
    public class CaseDonorHelpsMapping : IEntityTypeConfiguration<CaseDonorHelps>
    {
        public void Configure(EntityTypeBuilder<CaseDonorHelps> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TasvibId);
            builder.HasOne(x => x.Tasvib)
                .WithMany()
                .HasForeignKey(x => x.TasvibId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.CaseNumber);
            builder.HasOne(x => x.Case)
                .WithMany()
                .HasForeignKey(x => x.CaseNumber)
                .HasPrincipalKey(x => x.CaseNumber)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.CaseTypeId);
            builder.HasOne(x => x.CaseType)
                .WithMany()
                .HasForeignKey(x => x.CaseTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.MoneyAmount);

            builder.Property(x => x.FromDate).HasColumnType("Date");
            builder.Property(x => x.ToDate).HasColumnType("Date");
        }
    }
}
