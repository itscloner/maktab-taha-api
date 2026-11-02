using MaktabTaha.Application.DTO_s.tasvib.Single;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.tasvib.Query.Single
{
    public class GetTavibSingleCommand : IRequest<OperationResult<SingleTasvibDTO>>
    {
        public int Id { get; set; }
    }
}
