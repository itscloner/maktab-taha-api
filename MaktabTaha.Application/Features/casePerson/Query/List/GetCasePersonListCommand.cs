using MaktabTaha.Application.DTO_s.casePerson.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.casePerson.Query.List
{
    public class GetCasePersonListCommand : IRequest<OperationResult<List<CasePersonListDTO>>>
    {
    }
}
