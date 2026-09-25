using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface IRolePermissionRepository : IGenericRepository<int, RolePermission>
    {
        Task<List<RolePermission>> GetListWithoutIsDeleted();
    }
}
