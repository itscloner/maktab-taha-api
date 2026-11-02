using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class TasvibRepository : GenericRepository<int, Tasvib>, ITasvibRepository
    {
        private readonly ApplicationDbContext _context;
        public TasvibRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Tasvib> FirstOrDefaultWith(string caseNumber)
        {
            return await _context.Tasvib
                .Include(x => x.Case)
                .FirstOrDefaultAsync(x => x.CaseNumber == caseNumber);
        }
    }
}
