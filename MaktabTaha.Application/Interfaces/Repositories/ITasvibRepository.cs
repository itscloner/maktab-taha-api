using MaktabTaha.Application.DTO_s.tasvib.ListCaseOfTasvib;
using MaktabTaha.Application.DTO_s.tasvib.Search;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface ITasvibRepository : IGenericRepository<int, Tasvib>
    {
        Task<Tasvib> FirstOrDefaultWith(string caseNumber);
        Task<List<ListCaseOfTasvibDTO>> SearchCaseOfTasvibList(SearchCaseOfTasvibDTO filters);

    }
}
