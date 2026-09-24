using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabTaha.Infrastructure.Mapping.Role
{
    public class RoleMapping : IEntityTypeConfiguration<Domain.Entites.Role>
    {
        public void Configure(
            EntityTypeBuilder<Domain.Entites.Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.IsSystemAdmin)
                .IsRequired();
        }
    }
}