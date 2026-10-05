using AutoMapper;
using MaktabTaha.Application.DTO_s.attachment.Single;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.attachment.Query.Single
{
    public class GetSingleAttachmentHandler : IRequestHandler<GetSingleAttachmentCommand, OperationResult<AttachmentSingleDTO>>
    {
        private readonly IAttachmentRepository _repository;
        private readonly IMapper _mapper;

        public GetSingleAttachmentHandler(IAttachmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<AttachmentSingleDTO>> Handle(GetSingleAttachmentCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<AttachmentSingleDTO>();
            
            var attachment = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (attachment == null) return operation.Failure("فایل یافت نشد");

            var mappedData = _mapper.Map<AttachmentSingleDTO>(attachment);
            return operation.Succedded(mappedData);
        }
    }
}
