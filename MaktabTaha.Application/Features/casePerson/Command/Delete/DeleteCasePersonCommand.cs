using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.casePerson.Command.Delete
{
    public class DeleteCasePersonCommand : IRequest<OperationResult<bool>>
    {
        public int Id { get; set; }
    }
}
