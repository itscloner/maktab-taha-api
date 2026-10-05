using AutoMapper;
using MaktabTaha.Application.DTO_s.attachment.List;
using MaktabTaha.Application.Features.attachment.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.baseEntities.attachment.Query.List
{
    public class GetAttachmentListHandler : IRequestHandler<GetAttachmentListCommand, OperationResult<List<AttachmentListDTO>>>
    {
        private readonly IAttachmentRepository _repository;
        private readonly IMapper _mapper;
        public GetAttachmentListHandler(IAttachmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<AttachmentListDTO>>> Handle(GetAttachmentListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<AttachmentListDTO>>();

            var Attachments = await _repository.List();

            var mappedData = _mapper.Map<List<AttachmentListDTO>>(Attachments);
            return operation.Succedded(mappedData);
        }
    }
}
