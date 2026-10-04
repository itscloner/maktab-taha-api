using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.person.Command.Delete
{
    public class DeletePersonCommand : IRequest<OperationResult<bool>>
    {
        public int Id { get; set; }
    }
}
