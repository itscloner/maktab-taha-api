using MaktabTaha.Application.DTO_s.person.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.person.Query.List
{
    public class GetPersonListCommand : IRequest<OperationResult<List<PersonListDTO>>>
    {
    }
}
