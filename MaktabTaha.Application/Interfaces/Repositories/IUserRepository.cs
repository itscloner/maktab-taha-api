using MaktabTaha.Application.DTOs.users.list;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<int, User>
    {
        Task<List<UserListDTO>> GetAllList();
    }
}
