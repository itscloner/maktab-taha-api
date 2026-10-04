
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.baseEntities;

public class RelationRepository : GenericRepository<int, Relation>, IRelationRepository
{
    private readonly ApplicationDbContext _context;
    public RelationRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
