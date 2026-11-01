using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class TasvibRepository : GenericRepository<int, Tasvib>, ITasvibRepository
    {
        private readonly ApplicationDbContext _context;
        public TasvibRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
