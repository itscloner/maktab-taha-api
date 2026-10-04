using MaktabTaha.Application.Interfaces;
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
    public class DependancyStatusRepository : GenericRepository<int, DependancyStatus>, IDependancyStatusRepository
    {
        private readonly ApplicationDbContext _context;
        public DependancyStatusRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
