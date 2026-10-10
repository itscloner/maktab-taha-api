using MaktabTaha.Application.DTO_s.person.Search;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.person.Query.SearchCasePerson
{
    public class GetCasePersonListCommand : IRequest<OperationResult<List<SearchCasePersonListDTO>>>
    {
        public SearchCasePersonListDTO Filters { get; set; }
    }
}
