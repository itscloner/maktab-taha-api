using MaktabTaha.Application.DTO_s.attachment.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.attachment.Query.List
{
    public class GetAttachmentListCommand : IRequest<OperationResult<List<AttachmentListDTO>>>
    {
    }
}
