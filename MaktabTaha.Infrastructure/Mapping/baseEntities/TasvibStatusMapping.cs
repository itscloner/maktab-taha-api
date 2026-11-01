using MaktabTaha.Domain.Entites.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.baseEntities
{
    public class TasvibStatusMapping : IEntityTypeConfiguration<TasvibStatus>
    {
        public void Configure(EntityTypeBuilder<TasvibStatus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);

            builder.HasData(
                new TasvibStatus
                {
                    Id = (int)TasvibStatusEnum.NotApprove,
                    Title = "عدم تصویب"
                },
                new TasvibStatus
                {
                    Id = (int)TasvibStatusEnum.Approve,
                    Title = "تصویب"
                });
        }
    }
}
