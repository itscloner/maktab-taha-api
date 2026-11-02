using MaktabTaha.Application.DTO_s.caseDesc.ListCaseOfTasvib;
using MaktabTaha.Application.DTO_s.tasvib.ListCaseOfTasvib;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.caseDesc.Query.ListCaseOfTasvib
{
    public class GetListCaseOfTasvibCommand : IRequest<OperationResult<List<ListCaseOfTasvibDTO>>>
    {
        public SearchCaseOfTasvibDTO Filters { get; set; }
    }
}
