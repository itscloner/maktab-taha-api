using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.caseLevel
{
    public class ClassLevelMapping : IEntityTypeConfiguration<CaseLevel>
    {
        public void Configure(EntityTypeBuilder<CaseLevel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CaseLevelName);
        }
    }
}
