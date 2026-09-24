using MaktabTaha.Domain.Entites;
using MaktabTaha.Domain.Entites.BaseEntities;

using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<InitialRequest> InitialRequests { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<CharityMainRole> CharityMainRoles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<EducationLevel> EducationLevel { get; set; }
        public DbSet<EducationStatus> EducationStatus { get; set; }
        public DbSet<EmploymentStatus> EmploymantStatus { get; set; }
        public DbSet<GoodWorkType> GoodWorkTypes { get; set; }
        public DbSet<HouseHeadStatusDesc> HouseHeadStatusDescs { get; set; }
        public DbSet<HouseHeadStatus> HouseHeadStatus { get; set; }
        public DbSet<HousingStatus> HousingStatus { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Nationalty> Nationalties { get; set; }
        public DbSet<OrphanStatus> OrphanStatus { get; set; }
        public DbSet<PhysicalStatus> PhysicalStatus { get; set; }
        public DbSet<PrivatenessStatus> PrivatenessStatus { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Religon> Religons { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UnemploymentReason> UnemploymentReasons { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ApplicationDbContext).Assembly
            );
        }
    }
}
