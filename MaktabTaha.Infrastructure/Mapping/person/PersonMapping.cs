using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Mapping.person
{
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NationalCode);
            builder.Property(x => x.FirstName);
            builder.Property(x => x.LastName);
            builder.Property(x => x.NickName);
            builder.Property(x => x.FatherName);
            builder.Property(x => x.MotherName);
            builder.Property(x => x.Mobile);
            builder.Property(x => x.HomeNumber);

            builder.Property(x => x.GenderId);
            builder.HasOne(x => x.Gender)
                .WithMany()
                .HasForeignKey(x => x.GenderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.BirthDate);
            builder.Property(x => x.ShenasnamehNumber);
            builder.Property(x => x.ShenasnamehSeries);

            builder.Property(x => x.BirthProvinceId);
            builder.HasOne(x => x.BirthProvince)
                .WithMany()
                .HasForeignKey(x => x.BirthProvinceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.BirthCityId);
            builder.HasOne(x => x.BirthCity)
                .WithMany()
                .HasForeignKey(x => x.BirthCityId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.MaritalStatusId);
            builder.HasOne(x => x.MaritalStatus)
                .WithMany()
                .HasForeignKey(x => x.MaritalStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.NationalityId);
            builder.HasOne(x => x.Nationality)
                .WithMany()
                .HasForeignKey(x => x.NationalityId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.ReligonId);
            builder.HasOne(x => x.Religon)
                .WithMany()
                .HasForeignKey(x => x.ReligonId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.JobId);
            builder.HasOne(x => x.Job)
                .WithMany()
                .HasForeignKey(x => x.JobId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.SkillId);
            builder.HasOne(x => x.Skill)
                .WithMany()
                .HasForeignKey(x => x.SkillId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Interest);
            builder.Property(x => x.Wish);

            builder.Property(x => x.DependancyStatusId);
            builder.HasOne(x => x.DependancyStatus)
                .WithMany()
                .HasForeignKey(x => x.DependancyStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.EducationLevelId);
            builder.HasOne(x => x.EducationLevel)
                .WithMany()
                .HasForeignKey(x => x.EducationLevelId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.EducationStatusId);
            builder.HasOne(x => x.EducationStatus)
                .WithMany()
                .HasForeignKey(x => x.EducationStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.AverageScore);

            builder.Property(x => x.OrphanStatusId);
            builder.HasOne(x => x.OrphanStatus)
                .WithMany()
                .HasForeignKey(x => x.OrphanStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Income);
            builder.Property(x => x.IncomeDesc);

            builder.Property(x => x.PhysicalStatusId);
            builder.HasOne(x => x.PhysicalStatus)
                .WithMany()
                .HasForeignKey(x => x.PhysicalStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.SicknessType);

            builder.Property(x => x.EmploymentStatusId);
            builder.HasOne(x => x.EmploymentStatus)
                .WithMany()
                .HasForeignKey(x => x.EmploymentStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.UnemploymentReasonId);
            builder.HasOne(x => x.UnemploymentReason)
                .WithMany()
                .HasForeignKey(x => x.UnemploymentReasonId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.SadatStatusId);
            builder.HasOne(x => x.SadatStatus)
                .WithMany()
                .HasForeignKey(x => x.SadatStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            
        }
    }
}
