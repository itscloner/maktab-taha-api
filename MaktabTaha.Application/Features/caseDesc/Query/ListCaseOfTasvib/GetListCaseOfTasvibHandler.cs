using MaktabTaha.Application.DTO_s.tasvib.ListCaseOfTasvib;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.caseDesc.Query.ListCaseOfTasvib
{
    public class GetListCaseOfTasvibHandler : IRequestHandler<GetListCaseOfTasvibCommand, OperationResult<List<ListCaseOfTasvibDTO>>>
    {
        
        public Task<OperationResult<List<ListCaseOfTasvibDTO>>> Handle(GetListCaseOfTasvibCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
