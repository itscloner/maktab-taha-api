using MaktabTaha.Application.DTO_s.tasvib.ListCaseOfTasvib;
using MaktabTaha.Application.DTO_s.tasvib.Search;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.tasvib.Query.ListCaseOfTasvib
{
    public class GetListCaseOfTasvibCommand : IRequest<OperationResult<List<ListCaseOfTasvibDTO>>>
    {
        // لیست پرونده های تصویب

        public SearchCaseOfTasvibDTO Filters { get; set; }

    }
}
