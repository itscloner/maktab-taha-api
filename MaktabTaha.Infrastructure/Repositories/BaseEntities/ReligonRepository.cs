
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.baseEntities;

public class ReligonRepository : GenericRepository<int, Religon>, IReligonRepository
{
    private readonly ApplicationDbContext _context;
    public ReligonRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
