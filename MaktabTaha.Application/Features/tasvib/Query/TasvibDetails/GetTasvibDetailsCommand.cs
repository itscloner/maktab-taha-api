using MaktabTaha.Application.DTO_s.tasvib.TasvibDetails;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.tasvib.Query.TasvibDetails
{
    // اطلاعات جزئیات تصویب
    public class GetTasvibDetailsCommand : IRequest<OperationResult<TasvibDetailsDTO>>
    {
        public int Id { get; set; }
    }
}
