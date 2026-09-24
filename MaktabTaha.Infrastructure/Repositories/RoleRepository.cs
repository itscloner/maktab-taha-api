using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class RoleRepository : GenericRepository<int, Role>, IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context): base(context)
        {
            _context = context;
        }
    }
}
