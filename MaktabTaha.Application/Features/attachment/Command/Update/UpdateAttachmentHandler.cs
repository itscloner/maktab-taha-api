using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.attachment.Command.Update
{
    public class UpdateAttachmentHandler : IRequestHandler<UpdateAttachmentCommand, OperationResult<Attachments>>
    {
        private readonly IAttachmentRepository _repository;
        private readonly IMapper _mapper;

        public UpdateAttachmentHandler(IAttachmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Attachments>> Handle(UpdateAttachmentCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Attachments>();

            var attachment = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (attachment == null) return operation.Failure("فایل یافت نشد");

            _mapper.Map(request, attachment);

            if (request.Attach != null)
            {
                using var memoryStream = new MemoryStream();
                await request.Attach.CopyToAsync(memoryStream, cancellationToken);
                attachment.Attach = memoryStream.ToArray();
            }

            await _repository.Update(attachment);
            return operation.Succedded(attachment);
        }
    }
}
