using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Repositories.baseEntities
{
    public class CaseLevelRepository : GenericRepository<int, CaseLevel>, ICaseLevelRepository
    {
        private readonly ApplicationDbContext _context;
        public CaseLevelRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
