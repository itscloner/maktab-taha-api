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
    public class ManagerTasvibStatusMapping : IEntityTypeConfiguration<ManagerTasvibStatus>
    {
        public void Configure(EntityTypeBuilder<ManagerTasvibStatus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);

            builder.HasData(
                new ManagerTasvibStatus
                {
                    Id = (int)ManagerTasvibStatusEnum.WaitingForApprove,
                    Title = "منتظر تایید"
                },
                new ManagerTasvibStatus
                {
                    Id = (int)ManagerTasvibStatusEnum.Approve,
                    Title = "تایید"
                });
        }
    }
}
