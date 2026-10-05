using MaktabTaha.Application.DTO_s.attachment.Single;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.attachment.Query.Single
{
    public class GetSingleAttachmentCommand : IRequest<OperationResult<AttachmentSingleDTO>>
    {
        public int Id { get; set; }
    }
}
