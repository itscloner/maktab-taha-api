using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.casePerson.Command.Create
{
    public class CreateCasePersonCommand : IRequest<OperationResult<CasePerson>>
    {
        public int CaseId { get; set; }
        public int PersonId { get; set; }
        public int RelationId { get; set; }
        public int IsDependent { get; set; }

    }
}
