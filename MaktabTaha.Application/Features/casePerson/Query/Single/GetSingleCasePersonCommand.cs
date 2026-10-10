using MaktabTaha.Application.DTO_s.casePerson.Single;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.casePerson.Query.Single
{
    public class GetSingleCasePersonCommand :  IRequest<OperationResult<CasePersonSingleDTO>>
    {
        public int Id { get; set; }
    }
}
