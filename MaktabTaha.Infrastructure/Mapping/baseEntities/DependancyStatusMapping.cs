using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.baseEntities
{
    public class DependancyStatusMapping : IEntityTypeConfiguration<DependancyStatus>
    {
        public void Configure(EntityTypeBuilder<DependancyStatus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DependencyStatusName);
        }
    }
}
