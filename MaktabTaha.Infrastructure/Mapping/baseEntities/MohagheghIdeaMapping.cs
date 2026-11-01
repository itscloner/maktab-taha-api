using MaktabTaha.Domain.Entites.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.baseEntities
{
    public class MohagheghIdeaMapping : IEntityTypeConfiguration<MohagheghIdea>
    {
        public void Configure(EntityTypeBuilder<MohagheghIdea> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Title);

            builder.HasData(
                new MohagheghIdea
                {
                    Id = (int)MohagheghIdeaEnum.NotApprove,
                    Title = "عدم تایید"
                },
                new MohagheghIdea
                {
                    Id = (int)MohagheghIdeaEnum.Approve,
                    Title = "تایید"
                }); 
        }
    }
}
