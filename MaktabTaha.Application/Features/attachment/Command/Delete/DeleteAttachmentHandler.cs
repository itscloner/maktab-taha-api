using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.attachment.Command.Delete
{
    public class DeleteAttachmentHandler : IRequestHandler<DeleteAttachmentCommand, OperationResult<bool>>
    {
        private readonly IAttachmentRepository _repository;

        public DeleteAttachmentHandler(IAttachmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<bool>> Handle(DeleteAttachmentCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var Attachment = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (Attachment == null) return operation.Failure("فایل یافت نشد");

            await _repository.Delete(Attachment);
            return operation.Succedded(true);
        }
    }
}
