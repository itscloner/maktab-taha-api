using MaktabTaha.Application.DTO_s.caseDesc.List;
using MaktabTaha.Application.DTO_s.caseDesc.Search;
using MaktabTaha.Application.DTO_s.caseDesc.Single;
using MaktabTaha.Application.DTO_s.tasvib.CaseHeaderWithTasvibs;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface ICaseRepository : IGenericRepository<int, Case>
    {
        Task<List<CaseListDTO>> SearchCaseList(SearchCaseDTO filters);

        Task<CaseMoshaverehSingleDTO> GetCaseMoshaverehSingle(string caseNumber);


        // فرم نمایش تصویب : اطلاعات هدر فرم و اطلاعات تصویب های انجام شده
        Task<CaseHeaderWithTasvibsDTO> GetCaseHeaderWithTasvibs(string caseNumber);
    }
}
