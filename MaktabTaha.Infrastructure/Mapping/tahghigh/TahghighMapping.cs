using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml.Permissions;

namespace MaktabTaha.Infrastructure.Mapping.tahghigh
{
    public class TahghighMapping : IEntityTypeConfiguration<Tahghigh>
    {
        public void Configure(EntityTypeBuilder<Tahghigh> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TahghighDate);

            builder.Property(x => x.CaseNumber);
            builder.HasOne(x => x.Case)
                .WithMany()
                .HasForeignKey(x => x.CaseNumber)
                .HasPrincipalKey(x => x.CaseNumber)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.MoshaverehId);
            builder.HasOne(x => x.Moshavereh)
                .WithMany()
                .HasForeignKey(x => x.MoshaverehId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.ClientDescription);

            builder.Property(x => x.FirstMohagheghId);
            builder.HasOne(x => x.FirstMohaghegh)
                .WithMany()
                .HasForeignKey(x => x.FirstMohagheghId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.SecondMohagheghId);
            builder.HasOne(x => x.SecondMohaghegh)
                .WithMany()
                .HasForeignKey(x => x.SecondMohagheghId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.MohagheghIdeaId);
            builder.HasOne(x => x.MohagheghIdea)
                .WithMany()
                .HasForeignKey(x => x.MohagheghIdeaId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.MohagheghDescription);
        }
    }
}
