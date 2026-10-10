using MaktabTaha.Application.DTO_s.caseDesc.List;
using MaktabTaha.Application.DTO_s.caseDesc.Search;
using MaktabTaha.Application.DTO_s.casePerson.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.caseDesc.Query.List
{
    public class GetCaseListCommand : IRequest<OperationResult<List<CaseListDTO>>>
    {
        public SearchCaseDTO Filters { get; set; }
    }
}
